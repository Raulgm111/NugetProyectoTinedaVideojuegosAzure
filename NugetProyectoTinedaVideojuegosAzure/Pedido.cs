using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetProyectoTinedaVideojuegosAzure
{
    [Table("PEDIDOS")]
    public class Pedido
    {
        [Key]
        [Column("IDPEDIDO")]
        public int IdPedido { get; set; }

        [Column("IDPRODUCTO")]
        public int IdProducto { get; set; }


        [Column("IDCLIENTE")]
        public int IdCliente { get; set; }


        [Column("PRECIOTOTAL")]
        public int PrecioTotal { get; set; }


        [Column("CANTIDAD")]
        public int Cantidad { get; set; }


    }
}
