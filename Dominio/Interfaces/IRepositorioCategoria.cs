using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface IRepositorioCategoria : IRepositorioT<Categoria>
    {
        Categoria BuscarCategoriaPorNombre(string nombre);
    }
}
