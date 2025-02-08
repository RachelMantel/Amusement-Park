using AmusementPark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Core.InterfaceRepository
{
    public interface ICustomerRepository:IRepository<CustomerEntity>
    {
        public Task<IEnumerable<CustomerEntity>> GetFullAsync();
    }
}
