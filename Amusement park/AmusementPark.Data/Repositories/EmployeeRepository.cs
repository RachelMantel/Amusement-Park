
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
        public EmployeeRepository(DataContext dataContext)
            : base(dataContext)
        {
            _dbset = dataContext.Set<EmployeeEntity>();
        }
        public async Task<IEnumerable<EmployeeEntity>> GetFullAsync()
        {
            return await _dbset.Include(e=>e.facilitie).ToListAsync();
        }
    }
}
