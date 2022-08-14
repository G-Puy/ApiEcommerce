using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;
using Dominio.Interfaces;

namespace Repositorios
{
    public class RepositorioFotoEF : IRepositorioFoto
    {
        public EcommerceContext ContextEcomm { get; set; }
        public RepositorioFotoEF(EcommerceContext context)
        {
            ContextEcomm = context;
        }

        public bool Add(Foto obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Foto obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Foto obj)
        {
            throw new NotImplementedException();
        }

        public Foto FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Foto> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
