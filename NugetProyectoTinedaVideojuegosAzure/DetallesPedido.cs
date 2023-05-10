using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetProyectoTinedaVideojuegosAzure
{
    [Table("DETALLESPEDIDO")]
    public class DetallesPedido
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("IDDETALLEPEDIDO")]
        public int IdDetallesPedido { get; set; }

        [Column("IDPEDIDO")]
        public int IdPedido { get; set; }

        [Column("IDPRODUCTO")]
        public int IdProducto { get; set; }

        [Column("CANTIDAD")]
        public int Cantidad { get; set; }

        [Column("PRECIOTOTAL")]
        public int PrecioTotal { get; set; }

        [NotMapped]
        public string NombreProducto { get; set; }


    }
}
