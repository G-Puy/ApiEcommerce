using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface IRepositorioT<T>
    {
        bool Add(T obj);

        bool Remove(T obj);

        bool Update(T obj);

        T FindByID(int id);

        IEnumerable<T> FindAll();
    }
}
