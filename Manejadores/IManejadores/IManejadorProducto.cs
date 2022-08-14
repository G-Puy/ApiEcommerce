using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;

namespace Manejadores.IManejadores
{
    public interface IManejadorProducto
    {
        bool DarDeAltaProducto(Producto prod); //ADD
        bool EliminarProducto(Producto prod); //Delete
        bool Update(Producto prod);//Update
        Producto ObtenerProductoPorId(int idProducto);//Find by ID
        IEnumerable<Producto> ObtenerTodosLosProductos(); //FIND ALL
        
    }
}
