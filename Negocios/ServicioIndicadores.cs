using Datos;
using Entidades;

namespace Negocios;

public class ServicioIndicadores
{
    public async Task<ResumenInicio> ConsultarAsync(DateTime mes, uint departamento, SesionUsuario autor)
    {
        var resumen = await new RepositorioIndicadores().ConsultarAsync(mes, departamento, autor);
        for (int i = 0; i < resumen.Meses.Length; i++)
        {
            int jornadas = resumen.JornadasRegistradas[i];
            if (jornadas == 0)
                continue;
            resumen.IndiceAusentismo[i] = Math.Round(100.0 * resumen.Faltas[i] / jornadas, 2);
            resumen.IndiceTardanzas[i] = Math.Round(100.0 * resumen.Tardanzas[i] / jornadas, 2);
        }
        return resumen;
    }
}
