
using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Data.Repositories
{
    public class CustomerRepository : Repository<CustomerEntity>, ICustomerRepository
    {
        readonly DbSet<CustomerEntity> _dbset;
        public CustomerRepository(DataContext dataContext)
            : base(dataContext)
        {
            _dbset = dataContext.Set<CustomerEntity>();
        }
        public IEnumerable<CustomerEntity> GetFull()
        {
            return _dbset.Include(c => c.Orders).ToList();
        }
    }
}
