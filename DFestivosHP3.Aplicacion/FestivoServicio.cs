using DFestivosHP3.Core.Interfaces.Repositorios;
using DFestivosHP3.Core.Interfaces.Servicios;
using DFestivosHP3.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DFestivosHP3.Aplicacion
{
    public class FestivoServicio : IFestivoServicio
    {
        private readonly IFestivoRepositorio repositorio;

        public FestivoServicio(IFestivoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public Task<IEnumerable<Festivo>> ObtenerTodos()
        {
            return repositorio.ObtenerTodos();
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
