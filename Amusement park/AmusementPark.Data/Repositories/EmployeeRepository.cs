
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
    public class EmployeeRepository : Repository<EmployeeEntity>, IEmployeeRepository
    {
        readonly DbSet<EmployeeEntity> _dbset;
        public EmployeeRepository(DataContext dataContext, IRepositoryManager repositoryManager)
            : base(dataContext, repositoryManager)
        {
            _dbset = dataContext.Set<EmployeeEntity>();
        }
        public IEnumerable<EmployeeEntity> GetFull()
        {
            return _dbset.Include(e=>e.facilitie).ToList();
        }
    }
}
