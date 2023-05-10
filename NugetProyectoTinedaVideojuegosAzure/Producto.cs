using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetProyectoTinedaVideojuegosAzure
{
    [Table("PRODUCTOS")]
    public class Producto
    {
        [Key]
        [Column("IDPRODUCTO")]
        public int IdProducto { get; set; }

        [Column("IDCATEGORIA")]
        public int IdCategoria { get; set; }


        [Column("IDSUBCATEGORIA")]
        public int IdSubCategoria { get; set; }


        [Column("NOMBREPRODUCTO")]
        public string NombreProducto { get; set; }


        [Column("LANZAMIENTO")]
        public DateTime? Lanzamiento { get; set; }


        [Column("IMAGEN")]
        public string Imagen { get; set; }

        [Column("PRECIO")]
        public int Precio { get; set; }


        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }

        [Column("GENERO")]
        public string Genero { get; set; }

    }
}
