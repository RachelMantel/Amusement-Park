using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Core.InterfaceRepository
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();

        T? GetById(int id);

        T Add(T entity);

        T Update(int id,T entity);

        bool Delete(int id);
    }
}
