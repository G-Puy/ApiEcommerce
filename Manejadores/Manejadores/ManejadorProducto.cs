using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;
using Dominio.Interfaces;
using Manejadores.IManejadores;

namespace Manejadores.Manejadores
{
    public class ManejadorProducto : IManejadorProducto
    {

        public IRepositorioFoto RepoFoto { get; set; }
        public IRepositorioProducto RepoProduct { get; set; }
        public ManejadorProducto(IRepositorioFoto repoFoto, IRepositorioProducto repoProduct)
        {
            RepoFoto = repoFoto;
            RepoProduct = repoProduct;
        }

        public bool DarDeAltaProducto(Producto prod)
        {
            throw new NotImplementedException();
        }

        public bool EliminarProducto(Producto prod)
        {
            throw new NotImplementedException();
        }

        public bool Update(Producto prod)
        {
            throw new NotImplementedException();
        }

        public Producto ObtenerProductoPorId(int idProducto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> ObtenerTodosLosProductos()
        {
            throw new NotImplementedException();
        }
    }
}
