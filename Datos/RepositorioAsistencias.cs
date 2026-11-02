using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioAsistencias
{
    public async Task<List<RegistroAsistencia>> ListarAsync(DateTime desde, DateTime hasta, uint departamento,
        string buscar, string estado, int pagina, int tamano)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var comando = new MySqlCommand("""
            SELECT a.id_asistencia,a.id_empleado,CONCAT(e.codigo,' - ',e.nombres,' ',e.apellidos),
                COALESCE(d.nombre,''),a.fecha,a.es_laborable,a.entrada_prevista,a.salida_prevista,
                a.tolerancia_minutos,a.entrada,a.salida,a.estado,a.observaciones
            FROM asistencias a JOIN empleados e ON e.id_empleado=a.id_empleado
            LEFT JOIN historial_laboral h ON h.id_empleado=e.id_empleado
                AND h.fecha_inicio<=a.fecha AND (h.fecha_fin IS NULL OR h.fecha_fin>a.fecha)
            LEFT JOIN puestos p ON p.id_puesto=h.id_puesto LEFT JOIN departamentos d ON d.id_departamento=p.id_departamento
            WHERE a.fecha BETWEEN @desde AND @hasta AND (@departamento=0 OR p.id_departamento=@departamento)
                AND (e.codigo LIKE @buscar OR CONCAT(e.nombres,' ',e.apellidos) LIKE @buscar)
                AND (@estado='Todos' OR a.estado=@estado)
            ORDER BY a.fecha DESC,e.apellidos,e.nombres,a.id_asistencia LIMIT @limite OFFSET @inicio;
            """, conexion);
        comando.Parameters.AddWithValue("@desde", DateOnly.FromDateTime(desde));
        comando.Parameters.AddWithValue("@hasta", DateOnly.FromDateTime(hasta));
        comando.Parameters.AddWithValue("@departamento", departamento);
        comando.Parameters.AddWithValue("@buscar", "%" + buscar + "%");
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@limite", tamano + 1);
        comando.Parameters.AddWithValue("@inicio", pagina * tamano);
        await using var lector = await comando.ExecuteReaderAsync();
        var lista = new List<RegistroAsistencia>();
        while (await lector.ReadAsync())
            lista.Add(new RegistroAsistencia
            {
                IdAsistencia = lector.GetUInt32(0),
                IdEmpleado = lector.GetUInt32(1),
                Empleado = lector.GetString(2),
                Departamento = lector.GetString(3),
                Fecha = lector.GetDateTime(4),
                EsLaborable = lector.GetBoolean(5),
                EntradaPrevista = Local(lector, 6),
                SalidaPrevista = Local(lector, 7),
                Tolerancia = lector.GetInt32(8),
                Entrada = Local(lector, 9),
                Salida = Local(lector, 10),
                Estado = lector.GetString(11),
                Observaciones = lector.IsDBNull(12) ? null : lector.GetString(12)
            });
        return lista;
    }
    public async Task<RegistroAsistencia> JornadaAsync(uint empleado, DateTime fecha)
    {
        var asistencia = new RegistroAsistencia { IdEmpleado = empleado, Fecha = fecha.Date, EsLaborable = false, Estado = "NoLaborable" };
        int dia = (int)fecha.DayOfWeek;
        if (dia == 0)
            dia = 7;
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var comando = new MySqlCommand("""
            SELECT hd.hora_entrada,hd.hora_salida,hd.salida_dia_siguiente,hd.tolerancia_minutos
            FROM historial_laboral h JOIN horario_dias hd ON hd.id_horario=h.id_horario
            WHERE h.id_empleado=@empleado AND h.fecha_inicio<=@fecha AND (h.fecha_fin IS NULL OR h.fecha_fin>@fecha)
                AND hd.dia_semana=@dia;
            """, conexion);
        comando.Parameters.AddWithValue("@empleado", empleado);
        comando.Parameters.AddWithValue("@fecha", DateOnly.FromDateTime(fecha));
        comando.Parameters.AddWithValue("@dia", dia);
        await using var lector = await comando.ExecuteReaderAsync();
        if (await lector.ReadAsync())
        {
            asistencia.EsLaborable = true;
            asistencia.Estado = "Pendiente";
            asistencia.EntradaPrevista = fecha.Date.Add(lector.GetTimeSpan(0));
            asistencia.SalidaPrevista = fecha.Date.AddDays(lector.GetBoolean(2) ? 1 : 0).Add(lector.GetTimeSpan(1));
            asistencia.Tolerancia = lector.GetInt32(3);
        }
        return asistencia;
    }
    public async Task GuardarAsync(RegistroAsistencia asistencia, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "asistencias");
        bool nuevo = asistencia.IdAsistencia == 0;
        await using var comando = new MySqlCommand(nuevo ? """
            INSERT INTO asistencias (id_empleado,fecha,es_laborable,entrada_prevista,salida_prevista,tolerancia_minutos,entrada,salida,estado,observaciones,id_usuario_registra)
            VALUES (@empleado,@fecha,@laborable,@prevista,@finprevisto,@tolerancia,@entrada,@salida,@estado,@observaciones,@autor);
            """ : """
            UPDATE asistencias SET id_empleado=@empleado,fecha=@fecha,es_laborable=@laborable,entrada_prevista=@prevista,
                salida_prevista=@finprevisto,tolerancia_minutos=@tolerancia,entrada=@entrada,salida=@salida,estado=@estado,
                observaciones=@observaciones,id_usuario_registra=@autor WHERE id_asistencia=@id;
            """, conexion, transaccion);
        comando.Parameters.AddWithValue("@id", asistencia.IdAsistencia);
        comando.Parameters.AddWithValue("@empleado", asistencia.IdEmpleado);
        comando.Parameters.AddWithValue("@fecha", DateOnly.FromDateTime(asistencia.Fecha));
        comando.Parameters.AddWithValue("@laborable", asistencia.EsLaborable);
        comando.Parameters.AddWithValue("@prevista", Utc(asistencia.EntradaPrevista));
        comando.Parameters.AddWithValue("@finprevisto", Utc(asistencia.SalidaPrevista));
        comando.Parameters.AddWithValue("@tolerancia", asistencia.Tolerancia);
        comando.Parameters.AddWithValue("@entrada", Utc(asistencia.Entrada));
        comando.Parameters.AddWithValue("@salida", Utc(asistencia.Salida));
        comando.Parameters.AddWithValue("@estado", asistencia.Estado);
        comando.Parameters.AddWithValue("@observaciones", (object?)asistencia.Observaciones ?? DBNull.Value);
        comando.Parameters.AddWithValue("@autor", autor.IdUsuario);
        try
        {
            if (await comando.ExecuteNonQueryAsync() != 1)
                throw new InvalidOperationException("La asistencia ya no existe.");
            uint id = nuevo ? checked((uint)comando.LastInsertedId) : asistencia.IdAsistencia;
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, nuevo ? "INSERT" : "UPDATE", "asistencias", id, "Registro o corrección de jornada y marcas.");
            await transaccion.CommitAsync();
        }
        catch (MySqlException ex) when (ex.Number == 1062) { throw new InvalidOperationException("Ya existe la asistencia de ese empleado y fecha. Ábrela con doble clic para corregirla."); }
    }
    private static DateTime? Local(MySqlDataReader lector, int columna) => lector.IsDBNull(columna) ? null : lector.GetDateTime(columna).AddHours(-6);
    private static object Utc(DateTime? fecha) => fecha is null ? DBNull.Value : DateTime.SpecifyKind(fecha.Value.AddHours(6), DateTimeKind.Utc);
}
