
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
    public class FacilitieRepository : Repository<FacilitieEntity>, IFacilitieRepository
    {
        readonly DbSet<FacilitieEntity> _dbset;
        public FacilitieRepository(DataContext dataContext)
            : base(dataContext)
        {
            _dbset = dataContext.Set<FacilitieEntity>();
        }
        public async Task<IEnumerable<FacilitieEntity>> GetFullAsync()
        {
            return await _dbset.Include(f => f.employees).ToListAsync();
        }
    }
}
