using Microsoft.EntityFrameworkCore;
using DFestivosHP3.Dominio.Entidades;

namespace DFestivosHP3.Infraestructura.Repositorio.Contextos
{
    public class DFestivosHP3Context : DbContext
    {
        public DFestivosHP3Context(DbContextOptions<DFestivosHP3Context> options) : base(options)
        {
        }

        public DbSet<Festivo> Festivos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Festivo>(festivo =>
            {
                festivo.HasKey(f => f.Id);
                festivo.HasIndex(f => f.Nombre).IsUnique(); 
            });

        }
    }
}
