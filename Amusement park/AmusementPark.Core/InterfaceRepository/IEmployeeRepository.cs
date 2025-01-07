using AmusementPark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Core.InterfaceRepository
{
    public interface IEmployeeRepository:IRepository<EmployeeEntity>
    {
        public IEnumerable<EmployeeEntity> GetFull();
    }
}
