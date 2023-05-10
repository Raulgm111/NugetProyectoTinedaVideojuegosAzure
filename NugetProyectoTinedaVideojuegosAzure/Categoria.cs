using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetProyectoTinedaVideojuegosAzure
{
    [Table("CATEGORIAS")]
    public class Categoria
    {
        [Key]
        [Column("IDCATEGORIA")]
        public int IdCategoria { get; set; }

        [Column("NOMBRECATEGORIA")]
        public string NombreCategoria { get; set; }
    }
}
