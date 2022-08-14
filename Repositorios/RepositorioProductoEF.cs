using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;
using Dominio.Interfaces;

namespace Repositorios
{
    public class RepositorioProductoEF : IRepositorioProducto
    {
        public EcommerceContext ContextEcomm { get; set; }
        public RepositorioProductoEF(EcommerceContext context)
        {
            ContextEcomm = context;
        }
        public bool Add(Producto obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> FindAll()
        {
            throw new NotImplementedException();
        }

        public Producto FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Producto obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Producto obj)
        {
            throw new NotImplementedException();
        }
    }
}
