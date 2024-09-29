using DFestivosHP3.Core.Interfaces.Repositorios;
using DFestivosHP3.Core.Interfaces.Servicios;
using DFestivosHP3.Infraestructura.Repositorio;
using DFestivosHP3.Infraestructura.Repositorio.Contextos;
using Microsoft.EntityFrameworkCore;

namespace DFestivosHP3.Presentacion.InyeccionDependencias.cs
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AgregarDepencias(this IServiceCollection servicios, IConfiguration configuracion)
        {
            servicios.AddDbContext<DFestivosHP3Context>(opciones =>
            {
                opciones.UseSqlServer(configuracion.GetConnectionString("ConexionSqlString"));
            });

            servicios.AddTransient<IFestivoRepositorio, FestivoRepositorio>();
            servicios.AddTransient<IFestivoServicio, IFestivoServicio>();

            return servicios;
        }
    }
}
