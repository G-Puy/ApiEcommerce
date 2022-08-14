using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.Entidades;
using Dominio.Interfaces;

namespace Repositorios
{
    public class RepositorioCategoriaEF : IRepositorioCategoria
    {

        public EcommerceContext ContextEcomm { get; set; }
        public RepositorioCategoriaEF(EcommerceContext context)
        {
            ContextEcomm = context;
        }
        public bool Add(Categoria obj)
        {
            bool ok = false;
            try
            {
                if (obj != null)
                {
                    if(BuscarCategoriaPorNombre(obj.Nombre) == null)
                    {
                        ContextEcomm.Categorias.Add(obj);
                        ContextEcomm.SaveChanges();
                        ok = true;
                    }
                    
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return ok;
        }

        public IEnumerable<Categoria> FindAll()
        {
            IEnumerable<Categoria> cat = ContextEcomm.Categorias.ToList();
            return cat;
        }

        public Categoria FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Categoria obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Categoria obj)
        {
            throw new NotImplementedException();
        }

        public Categoria BuscarCategoriaPorNombre(string nombre)
        {
            Categoria ok = ContextEcomm.Categorias.Where(e => e.Nombre == nombre).SingleOrDefault();
            return ok;
        }
    }

}
