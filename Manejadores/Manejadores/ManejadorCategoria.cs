using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;
using Dominio.Interfaces;
using Manejadores.IManejadores;


namespace Manejadores.Manejadores
{
    public class ManejadorCategoria : IManejadorCategoria
    {
      public IRepositorioCategoria  RepoCate { get; set; }
      public ManejadorCategoria(IRepositorioCategoria repoInj)
        {
            RepoCate = repoInj;
        }

        public bool DarDeAltaCategoria(Categoria nuevaCategoria)
        {

            bool ok = RepoCate.Add(nuevaCategoria);

            return ok;
        }

        public bool EliminarCategoria(Categoria categoriaDelted)
        {
            throw new NotImplementedException();
        }

        public Categoria ObtenerProductoPorId(int idCategoria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> ObtenerTodosLasCategorias()
        {

            return RepoCate.FindAll();

        }

        public bool Update(Categoria categoriaUpdatear)
        {
            throw new NotImplementedException();
        }
    }
}
