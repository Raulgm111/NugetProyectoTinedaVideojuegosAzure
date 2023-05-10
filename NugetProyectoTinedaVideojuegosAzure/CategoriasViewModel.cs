using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetProyectoTinedaVideojuegosAzure
{
    public class CategoriasViewModel
    {
        public List<Categoria> Categorias { get; set; }

        public List<Producto> Productos { get; set; }

        public List<SubCategoria> Subcategorias { get; set; }

        public Producto Producto { get; set; }

        public List<Producto> ProductosPS4 { get; set; }
        public List<Producto> ProductosPS5 { get; set; }
        public List<Producto> Tazas { get; set; }

        public List<string> Generos { get; set; }
    }
}
