using Datos;
using Entidades;

namespace Negocios;

public class ServicioIndicadores
{
    public Task<ResumenInicio> ConsultarAsync(DateTime mes, uint departamento, SesionUsuario autor) =>
        new RepositorioIndicadores().ConsultarAsync(mes, departamento, autor);
}
