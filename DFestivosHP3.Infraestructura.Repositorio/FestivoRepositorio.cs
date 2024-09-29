using DFestivosHP3.Core.Interfaces.Repositorios;
using DFestivosHP3.Dominio.Entidades;
using DFestivosHP3.Infraestructura.Repositorio.Contextos;
using Microsoft.EntityFrameworkCore;

namespace DFestivosHP3.Infraestructura.Repositorio
{
    public class FestivoRepositorio : IFestivoRepositorio
    {
        private readonly DFestivosHP3Context context;

        public FestivoRepositorio(DFestivosHP3Context context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Festivo>> ObtenerTodos()
        {
            return await context.Festivos.ToArrayAsync();
        }

        public Task<Festivo> Agregar(Festivo Dato)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Festivo>> Buscar(int Indice, string Dato)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Festivo> Modificar(Festivo Dato)
        {
            throw new NotImplementedException();
        }

        public Task<Festivo> Obtener(int Id)
        {
            throw new NotImplementedException();
        }
       
    }
}
