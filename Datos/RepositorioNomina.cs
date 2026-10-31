using System.Globalization;
using System.Security.Cryptography;
using Datos.Seguridad;
using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioNomina
{
    public async Task<uint> CrearPeriodoAsync(PeriodoPago periodo, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "nomina");
        await using var comando = new MySqlCommand("""
            INSERT INTO periodos_nomina (nombre,fecha_inicio,fecha_fin,id_usuario_genera,observaciones)
            VALUES (@nombre,@inicio,@fin,@autor,@observaciones);
            """, conexion, transaccion);
        comando.Parameters.AddWithValue("@nombre", periodo.Nombre);
        comando.Parameters.AddWithValue("@inicio", periodo.Inicio.Date);
        comando.Parameters.AddWithValue("@fin", periodo.Fin.Date);
        comando.Parameters.AddWithValue("@autor", autor.IdUsuario);
        comando.Parameters.AddWithValue("@observaciones", (object?)periodo.Observaciones ?? DBNull.Value);
        try
        {
            await comando.ExecuteNonQueryAsync();
            uint id = checked((uint)comando.LastInsertedId);
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, "INSERT", "periodos_nomina", id, "Creación de período mensual de nómina.");
            await transaccion.CommitAsync();
            return id;
        }
        catch (MySqlException ex) when (ex.Number == 1062) { throw new InvalidOperationException("Ya existe un período con esas fechas."); }
    }
    public async Task<uint> BuscarPeriodoIdAsync(DateTime desde, DateTime hasta)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var comando = new MySqlCommand("SELECT id_periodo_nomina FROM periodos_nomina WHERE fecha_inicio=@inicio AND fecha_fin=@fin;", conexion);
        comando.Parameters.AddWithValue("@inicio", desde.Date);
        comando.Parameters.AddWithValue("@fin", hasta.Date);
        var id = await comando.ExecuteScalarAsync();
        if (id is null)
            throw new InvalidOperationException("El período ya no existe.");
        return Convert.ToUInt32(id);
    }
    public async Task<PeriodoPago> LeerPeriodoAsync(uint id)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        return await LeerPeriodoInternoAsync(conexion, null, id);
    }
    private static async Task<PeriodoPago> LeerPeriodoInternoAsync(MySqlConnection conexion, MySqlTransaction? transaccion, uint id)
    {
        await using var comando = new MySqlCommand("SELECT nombre,fecha_inicio,fecha_fin,estado,observaciones FROM periodos_nomina WHERE id_periodo_nomina=@id FOR UPDATE;", conexion, transaccion);
        comando.Parameters.AddWithValue("@id", id);
        await using var lector = await comando.ExecuteReaderAsync();
        if (!await lector.ReadAsync())
            throw new InvalidOperationException("El período ya no existe.");
        return new PeriodoPago
        {
            IdPeriodo = id,
            Nombre = lector.GetString(0),
            Inicio = lector.GetDateTime(1),
            Fin = lector.GetDateTime(2),
            Estado = lector.GetString(3),
            Observaciones = lector.IsDBNull(4) ? null : lector.GetString(4)
        };
    }
    public async Task GenerarAsync(uint id, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, transaccion, autor, "nomina");
        try
        {
            var periodo = await LeerPeriodoInternoAsync(conexion, transaccion, id);
            if (periodo.Estado != "Borrador")
                throw new InvalidOperationException("Solo se puede calcular un período en borrador.");
            await using (var existentes = new MySqlCommand("SELECT COUNT(*) FROM detalle_nomina WHERE id_periodo_nomina=@id;", conexion, transaccion))
            {
                existentes.Parameters.AddWithValue("@id", id);
                if (Convert.ToInt32(await existentes.ExecuteScalarAsync()) > 0)
                    throw new InvalidOperationException("El período ya fue calculado. Usa los movimientos para registrar ajustes.");
            }
            var pagos = new List<PagoEmpleado>();
            await using (var consultar = new MySqlCommand("""
                SELECT e.id_empleado,e.codigo,CONCAT(e.nombres,' ',e.apellidos),d.id_departamento,d.nombre,
                    p.id_puesto,p.nombre,t.nombre,h.salario_cifrado,h.fecha_inicio
                FROM empleados e JOIN historial_laboral h ON h.id_empleado=e.id_empleado
                    AND h.fecha_inicio<=@fin AND (h.fecha_fin IS NULL OR h.fecha_fin>@fin)
                JOIN puestos p ON p.id_puesto=h.id_puesto JOIN departamentos d ON d.id_departamento=p.id_departamento
                JOIN tipos_contrato t ON t.id_tipo_contrato=h.id_tipo_contrato
                WHERE e.fecha_contratacion<=@fin AND (e.fecha_baja IS NULL OR e.fecha_baja>=@inicio)
                    AND (e.estado<>'Inactivo' OR e.fecha_baja IS NOT NULL)
                ORDER BY e.id_empleado;
                """, conexion, transaccion))
            {
                consultar.Parameters.AddWithValue("@inicio", periodo.Inicio);
                consultar.Parameters.AddWithValue("@fin", periodo.Fin);
                await using var lector = await consultar.ExecuteReaderAsync();
                while (await lector.ReadAsync())
                {
                    uint empleado = lector.GetUInt32(0);
                    pagos.Add(new PagoEmpleado
                    {
                        IdPeriodo = id,
                        IdEmpleado = empleado,
                        Codigo = lector.GetString(1),
                        Empleado = lector.GetString(2),
                        IdDepartamento = lector.GetUInt32(3),
                        Departamento = lector.GetString(4),
                        IdPuesto = lector.GetUInt32(5),
                        Puesto = lector.GetString(6),
                        Contrato = lector.GetString(7),
                        Dias = (periodo.Fin - periodo.Inicio).Days + 1,
                        SalarioBase = CifradoDatos.DescifrarImporte((byte[])lector.GetValue(8), clave, "salario:" + empleado + ":" + lector.GetDateTime(9).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))
                    });
                }
            }
            if (pagos.Count == 0)
                throw new InvalidOperationException("No hay empleados con condición laboral vigente al cierre del mes.");
            foreach (var pago in pagos)
            {
                await using var guardar = new MySqlCommand("""
                    INSERT INTO detalle_nomina (id_periodo_nomina,id_empleado,id_departamento,id_puesto,codigo_empleado,nombre_empleado,
                        nombre_departamento,nombre_puesto,tipo_contrato,dias_pagados,salario_base_cifrado,total_ingresos_cifrado,total_deducciones_cifrado,neto_cifrado)
                    VALUES (@periodo,@empleado,@departamento,@puesto,@codigo,@nombre,@nombreDepartamento,@nombrePuesto,@contrato,@dias,@base,@ingresos,@deducciones,@neto);
                    """, conexion, transaccion);
                guardar.Parameters.AddWithValue("@periodo", id);
                guardar.Parameters.AddWithValue("@empleado", pago.IdEmpleado);
                guardar.Parameters.AddWithValue("@departamento", pago.IdDepartamento);
                guardar.Parameters.AddWithValue("@puesto", pago.IdPuesto);
                guardar.Parameters.AddWithValue("@codigo", pago.Codigo);
                guardar.Parameters.AddWithValue("@nombre", pago.Empleado);
                guardar.Parameters.AddWithValue("@nombreDepartamento", pago.Departamento);
                guardar.Parameters.AddWithValue("@nombrePuesto", pago.Puesto);
                guardar.Parameters.AddWithValue("@contrato", pago.Contrato);
                guardar.Parameters.AddWithValue("@dias", pago.Dias);
                guardar.Parameters.AddWithValue("@base", CifradoDatos.CifrarImporte(pago.SalarioBase, clave, Contexto(id, pago.IdEmpleado, "base")));
                guardar.Parameters.AddWithValue("@ingresos", CifradoDatos.CifrarImporte(pago.SalarioBase, clave, Contexto(id, pago.IdEmpleado, "ingresos")));
                guardar.Parameters.AddWithValue("@deducciones", CifradoDatos.CifrarImporte(0, clave, Contexto(id, pago.IdEmpleado, "deducciones")));
                guardar.Parameters.AddWithValue("@neto", CifradoDatos.CifrarImporte(pago.SalarioBase, clave, Contexto(id, pago.IdEmpleado, "neto")));
                await guardar.ExecuteNonQueryAsync();
            }
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, "INSERT", "detalle_nomina", id, "Generación de nómina mensual con sueldo completo; ajustes manuales.");
            await transaccion.CommitAsync();
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }
    public async Task<List<PagoEmpleado>> PagosAsync(uint periodo, uint departamento, string buscar, int pagina, int tamano, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, null, autor, "nomina");
        try
        {
            await using var comando = new MySqlCommand("""
                SELECT d.*,p.nombre AS periodo,p.estado AS estado_periodo FROM detalle_nomina d
                JOIN periodos_nomina p ON p.id_periodo_nomina=d.id_periodo_nomina
                WHERE d.id_periodo_nomina=@periodo AND (@departamento=0 OR d.id_departamento=@departamento)
                    AND (d.nombre_empleado LIKE @buscar OR d.codigo_empleado LIKE @buscar)
                ORDER BY d.nombre_empleado,d.id_detalle_nomina LIMIT @limite OFFSET @inicio;
                """, conexion);
            comando.Parameters.AddWithValue("@periodo", periodo);
            comando.Parameters.AddWithValue("@departamento", departamento);
            comando.Parameters.AddWithValue("@buscar", "%" + buscar + "%");
            comando.Parameters.AddWithValue("@limite", tamano + 1);
            comando.Parameters.AddWithValue("@inicio", pagina * tamano);
            await using var lector = await comando.ExecuteReaderAsync();
            var pagos = new List<PagoEmpleado>();
            while (await lector.ReadAsync())
                pagos.Add(LeerPago(lector, clave));
            return pagos;
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }
    public async Task<List<PagoEmpleado>> BoletasAsync(uint periodo, uint departamento, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, null, autor, "nomina");
        try
        {
            var pagos = new List<PagoEmpleado>();
            var porDetalle = new Dictionary<uint, PagoEmpleado>();
            await using (var comando = new MySqlCommand("""
                SELECT d.*,p.nombre AS periodo,p.estado AS estado_periodo FROM detalle_nomina d
                JOIN periodos_nomina p ON p.id_periodo_nomina=d.id_periodo_nomina
                WHERE d.id_periodo_nomina=@periodo AND (@departamento=0 OR d.id_departamento=@departamento)
                ORDER BY d.nombre_departamento,d.nombre_empleado,d.id_detalle_nomina;
                """, conexion))
            {
                comando.Parameters.AddWithValue("@periodo", periodo);
                comando.Parameters.AddWithValue("@departamento", departamento);
                await using var lector = await comando.ExecuteReaderAsync();
                while (await lector.ReadAsync())
                {
                    var pago = LeerPago(lector, clave);
                    pagos.Add(pago);
                    porDetalle.Add(pago.IdDetalle, pago);
                }
            }
            await using var movimientos = new MySqlCommand("""
                SELECT m.id_movimiento_nomina,m.id_detalle_nomina,m.orden,m.tipo,m.concepto,m.cantidad,m.importe_cifrado
                FROM movimientos_nomina m JOIN detalle_nomina d ON d.id_detalle_nomina=m.id_detalle_nomina
                WHERE d.id_periodo_nomina=@periodo AND (@departamento=0 OR d.id_departamento=@departamento)
                ORDER BY m.id_detalle_nomina,m.orden;
                """, conexion);
            movimientos.Parameters.AddWithValue("@periodo", periodo);
            movimientos.Parameters.AddWithValue("@departamento", departamento);
            await using var filas = await movimientos.ExecuteReaderAsync();
            while (await filas.ReadAsync())
            {
                uint detalle = filas.GetUInt32(1);
                int orden = filas.GetInt32(2);
                if (porDetalle.TryGetValue(detalle, out var pago))
                    pago.Movimientos.Add(new MovimientoPago
                    {
                        IdMovimiento = filas.GetUInt32(0),
                        IdDetalle = detalle,
                        Orden = orden,
                        Tipo = filas.GetString(3),
                        Concepto = filas.GetString(4),
                        Cantidad = filas.GetDecimal(5),
                        Importe = CifradoDatos.DescifrarImporte((byte[])filas.GetValue(6), clave, $"movimiento:{detalle}:{orden}")
                    });
            }
            return pagos;
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }

    public async Task<PagoEmpleado> LeerPagoAsync(uint detalle, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, null, autor, "nomina");
        try
        {
            await using var comando = new MySqlCommand("SELECT d.*,p.nombre AS periodo,p.estado AS estado_periodo FROM detalle_nomina d JOIN periodos_nomina p ON p.id_periodo_nomina=d.id_periodo_nomina WHERE d.id_detalle_nomina=@id;", conexion);
            comando.Parameters.AddWithValue("@id", detalle);
            await using var lector = await comando.ExecuteReaderAsync();
            if (!await lector.ReadAsync())
                throw new InvalidOperationException("El detalle de nómina ya no existe.");
            return LeerPago(lector, clave);
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }
    private static PagoEmpleado LeerPago(MySqlDataReader lector, byte[] clave)
    {
        uint periodo = lector.GetUInt32("id_periodo_nomina"), empleado = lector.GetUInt32("id_empleado");
        return new PagoEmpleado
        {
            IdDetalle = lector.GetUInt32("id_detalle_nomina"),
            IdPeriodo = periodo,
            IdEmpleado = empleado,
            IdDepartamento = lector.GetUInt32("id_departamento"),
            IdPuesto = lector.GetUInt32("id_puesto"),
            Codigo = lector.GetString("codigo_empleado"),
            Empleado = lector.GetString("nombre_empleado"),
            Departamento = lector.GetString("nombre_departamento"),
            Puesto = lector.GetString("nombre_puesto"),
            Contrato = lector.GetString("tipo_contrato"),
            Dias = lector.GetDecimal("dias_pagados"),
            Periodo = lector.GetString("periodo"),
            EstadoPeriodo = lector.GetString("estado_periodo"),
            SalarioBase = CifradoDatos.DescifrarImporte((byte[])lector["salario_base_cifrado"], clave, Contexto(periodo, empleado, "base")),
            Ingresos = CifradoDatos.DescifrarImporte((byte[])lector["total_ingresos_cifrado"], clave, Contexto(periodo, empleado, "ingresos")),
            Deducciones = CifradoDatos.DescifrarImporte((byte[])lector["total_deducciones_cifrado"], clave, Contexto(periodo, empleado, "deducciones")),
            Neto = CifradoDatos.DescifrarImporte((byte[])lector["neto_cifrado"], clave, Contexto(periodo, empleado, "neto"))
        };
    }
    public async Task<List<MovimientoPago>> MovimientosAsync(uint detalle, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, null, autor, "nomina");
        try
        {
            await using var comando = new MySqlCommand("SELECT id_movimiento_nomina,orden,tipo,concepto,cantidad,importe_cifrado FROM movimientos_nomina WHERE id_detalle_nomina=@id ORDER BY orden;", conexion);
            comando.Parameters.AddWithValue("@id", detalle);
            await using var lector = await comando.ExecuteReaderAsync();
            var movimientos = new List<MovimientoPago>();
            while (await lector.ReadAsync())
                movimientos.Add(new MovimientoPago
                {
                    IdMovimiento = lector.GetUInt32(0),
                    IdDetalle = detalle,
                    Orden = lector.GetInt32(1),
                    Tipo = lector.GetString(2),
                    Concepto = lector.GetString(3),
                    Cantidad = lector.GetDecimal(4),
                    Importe = CifradoDatos.DescifrarImporte((byte[])lector.GetValue(5), clave, $"movimiento:{detalle}:{lector.GetInt32(1)}")
                });
            return movimientos;
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }
    public Task GuardarMovimientoAsync(MovimientoPago movimiento, SesionUsuario autor) => ModificarMovimientoAsync(movimiento, autor, false);
    public Task EliminarMovimientoAsync(uint movimiento, uint detalle, SesionUsuario autor) =>
        ModificarMovimientoAsync(new MovimientoPago { IdMovimiento = movimiento, IdDetalle = detalle }, autor, true);

    private async Task ModificarMovimientoAsync(MovimientoPago movimiento, SesionUsuario autor, bool eliminar)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, transaccion, autor, "nomina");
        try
        {
            uint periodo, empleado;
            decimal salario;
            await using (var bloquear = new MySqlCommand("""
                SELECT d.id_periodo_nomina,d.id_empleado,d.salario_base_cifrado,p.estado FROM detalle_nomina d
                JOIN periodos_nomina p ON p.id_periodo_nomina=d.id_periodo_nomina WHERE d.id_detalle_nomina=@id FOR UPDATE;
                """, conexion, transaccion))
            {
                bloquear.Parameters.AddWithValue("@id", movimiento.IdDetalle);
                await using var lector = await bloquear.ExecuteReaderAsync();
                if (!await lector.ReadAsync() || lector.GetString(3) != "Borrador")
                    throw new InvalidOperationException("Solo se pueden modificar movimientos de un período en borrador.");
                periodo = lector.GetUInt32(0);
                empleado = lector.GetUInt32(1);
                salario = CifradoDatos.DescifrarImporte((byte[])lector.GetValue(2), clave, Contexto(periodo, empleado, "base"));
            }
            bool nuevo = movimiento.IdMovimiento == 0;
            await using (var orden = new MySqlCommand(nuevo ? "SELECT COALESCE(MAX(orden),0)+1 FROM movimientos_nomina WHERE id_detalle_nomina=@detalle;"
                : "SELECT orden FROM movimientos_nomina WHERE id_movimiento_nomina=@id AND id_detalle_nomina=@detalle;", conexion, transaccion))
            {
                orden.Parameters.AddWithValue("@detalle", movimiento.IdDetalle);
                orden.Parameters.AddWithValue("@id", movimiento.IdMovimiento);
                var valor = await orden.ExecuteScalarAsync();
                if (valor is null)
                    throw new InvalidOperationException("El movimiento ya no existe.");
                movimiento.Orden = Convert.ToInt32(valor);
            }
            string sql = eliminar ? "DELETE FROM movimientos_nomina WHERE id_movimiento_nomina=@id AND id_detalle_nomina=@detalle;"
                : nuevo ? "INSERT INTO movimientos_nomina (id_detalle_nomina,orden,tipo,concepto,cantidad,importe_cifrado) VALUES (@detalle,@orden,@tipo,@concepto,@cantidad,@importe);"
                : "UPDATE movimientos_nomina SET tipo=@tipo,concepto=@concepto,cantidad=@cantidad,importe_cifrado=@importe WHERE id_movimiento_nomina=@id AND id_detalle_nomina=@detalle;";
            await using var guardar = new MySqlCommand(sql, conexion, transaccion);
            guardar.Parameters.AddWithValue("@id", movimiento.IdMovimiento);
            guardar.Parameters.AddWithValue("@detalle", movimiento.IdDetalle);
            guardar.Parameters.AddWithValue("@orden", movimiento.Orden);
            guardar.Parameters.AddWithValue("@tipo", movimiento.Tipo);
            guardar.Parameters.AddWithValue("@concepto", movimiento.Concepto);
            guardar.Parameters.AddWithValue("@cantidad", movimiento.Cantidad);
            guardar.Parameters.AddWithValue("@importe", CifradoDatos.CifrarImporte(movimiento.Importe, clave, $"movimiento:{movimiento.IdDetalle}:{movimiento.Orden}"));
            if (await guardar.ExecuteNonQueryAsync() != 1)
                throw new InvalidOperationException("El movimiento ya no existe.");
            uint id = nuevo ? checked((uint)guardar.LastInsertedId) : movimiento.IdMovimiento;
            decimal ingresos = salario, deducciones = 0;
            await using (var sumar = new MySqlCommand("SELECT orden,tipo,cantidad,importe_cifrado FROM movimientos_nomina WHERE id_detalle_nomina=@id;", conexion, transaccion))
            {
                sumar.Parameters.AddWithValue("@id", movimiento.IdDetalle);
                await using var lector = await sumar.ExecuteReaderAsync();
                while (await lector.ReadAsync())
                {
                    decimal importe = CifradoDatos.DescifrarImporte((byte[])lector.GetValue(3), clave, $"movimiento:{movimiento.IdDetalle}:{lector.GetInt32(0)}");
                    decimal total = decimal.Round(lector.GetDecimal(2) * importe, 2, MidpointRounding.AwayFromZero);
                    if (lector.GetString(1) == "Ingreso")
                        ingresos += total;
                    else
                        deducciones += total;
                }
            }
            if (deducciones > ingresos || ingresos > 999999999999.99m || deducciones > 999999999999.99m)
                throw new InvalidOperationException("Las deducciones no pueden superar los ingresos ni el importe máximo permitido.");
            await using var actualizar = new MySqlCommand("UPDATE detalle_nomina SET total_ingresos_cifrado=@ingresos,total_deducciones_cifrado=@deducciones,neto_cifrado=@neto WHERE id_detalle_nomina=@id;", conexion, transaccion);
            actualizar.Parameters.AddWithValue("@id", movimiento.IdDetalle);
            actualizar.Parameters.AddWithValue("@ingresos", CifradoDatos.CifrarImporte(ingresos, clave, Contexto(periodo, empleado, "ingresos")));
            actualizar.Parameters.AddWithValue("@deducciones", CifradoDatos.CifrarImporte(deducciones, clave, Contexto(periodo, empleado, "deducciones")));
            actualizar.Parameters.AddWithValue("@neto", CifradoDatos.CifrarImporte(ingresos - deducciones, clave, Contexto(periodo, empleado, "neto")));
            await actualizar.ExecuteNonQueryAsync();
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, eliminar ? "DELETE" : nuevo ? "INSERT" : "UPDATE", "movimientos_nomina", id, "Ajuste manual de nómina y actualización de totales.");
            await transaccion.CommitAsync();
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }
    public async Task CambiarEstadoAsync(uint id, string estado, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "nomina");
        var periodo = await LeerPeriodoInternoAsync(conexion, transaccion, id);
        if (periodo.Estado == "Anulado" || estado == "Cerrado" && periodo.Estado != "Borrador")
            throw new InvalidOperationException("El período ya está cerrado o anulado.");
        if (estado == "Cerrado")
        {
            await using var cantidad = new MySqlCommand("SELECT COUNT(*) FROM detalle_nomina WHERE id_periodo_nomina=@id;", conexion, transaccion);
            cantidad.Parameters.AddWithValue("@id", id);
            if (Convert.ToInt32(await cantidad.ExecuteScalarAsync()) == 0)
                throw new InvalidOperationException("Calcula la nómina antes de cerrar el período.");
        }
        await using var comando = new MySqlCommand("""
            UPDATE periodos_nomina SET estado=@estado,
                fecha_cierre=IF(@estado='Cerrado',UTC_TIMESTAMP(),fecha_cierre),
                id_usuario_cierra=IF(@estado='Cerrado',@autor,id_usuario_cierra) WHERE id_periodo_nomina=@id;
            """, conexion, transaccion);
        comando.Parameters.AddWithValue("@id", id);
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@autor", autor.IdUsuario);
        await comando.ExecuteNonQueryAsync();
        await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, estado == "Cerrado" ? "CIERRE" : "ANULACION", "periodos_nomina", id, "Cambio de estado del período a " + estado + ".");
        await transaccion.CommitAsync();
    }
    private static string Contexto(uint periodo, uint empleado, string campo) => $"nomina:{periodo}:{empleado}:{campo}";
}
