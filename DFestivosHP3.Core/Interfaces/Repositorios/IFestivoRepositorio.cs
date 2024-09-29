using DFestivosHP3.Dominio.Entidades;

namespace DFestivosHP3.Core.Interfaces.Repositorios
{
    public interface IFestivoRepositorio
    {
        Task<IEnumerable<Festivo>> ObtenerTodos();
        Task<Festivo> Obtener(int Id);
        Task<IEnumerable<Festivo>> Buscar(int Indice, string Dato);
        Task<Festivo> Agregar(Festivo Dato);
        Task<Festivo> Modificar(Festivo Dato);
        Task<bool> Eliminar(int Id);
    }
}
