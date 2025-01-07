using AmusementPark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Core.InterfaceService
{
    public interface Iservice<T>
    {
        IEnumerable<T> getall();

         T? getById(int id);

         T add(T item);

         T update(int id, T item);

         bool delete(int id);
    }
}
