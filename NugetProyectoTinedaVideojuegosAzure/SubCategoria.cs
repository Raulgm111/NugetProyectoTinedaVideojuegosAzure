using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetProyectoTinedaVideojuegosAzure
{
    [Table("SUBCATEGORIAS")]
    public class SubCategoria
    {
        [Key]
        [Column("IDSUBCATEGORIA")]
        public int IdSubCategoria { get; set; }

        [Column("NOMBRESUBCATEGORIA")]
        public string NombreSubCategoria { get; set; }

        [Column("IDCATEGORIA")]
        public int IdCategoria { get; set; }
    }
}
