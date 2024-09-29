using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFestivosHP3.Dominio.Entidades
{
    [Table("Festivo")]
    public class Festivo
    {
        [Column("Id")]
        public int Id { get; set; }
      
        [Column("Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Column("Dia")]
        public int Dia { get; set; }

        [Column("DiasPascua")]
        public int DiasPascua { get; set; }

        [Column("IdTipo")]
        public int IdTipo { get; set; }

        public Tipos Tipo { get; set; } 
    }
}
