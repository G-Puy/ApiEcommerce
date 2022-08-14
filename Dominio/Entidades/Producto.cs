using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public Categoria CategoriaProducto { get; set; }
        public IEnumerable<Foto> MyProperty { get; set; }


    }
}
