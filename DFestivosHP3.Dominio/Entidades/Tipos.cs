using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DFestivosHP3.Dominio.Entidades
{
    [Table("Tipo")]
    public class Tipos
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Tipo")]
        public string Tipo { get; set; } = string.Empty;

    }
}
