using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;

namespace Manejadores.IManejadores
{
    public interface IManejadorCategoria
    {
        bool DarDeAltaCategoria(Categoria nuevaCategoria);// Add
        bool EliminarCategoria(Categoria categoriaDelted); //Delete
        bool Update(Categoria categoriaUpdatear);//Update
        Categoria ObtenerProductoPorId(int idCategoria);//Find by ID
        IEnumerable<Categoria> ObtenerTodosLasCategorias(); //FIND ALL
    }
}
