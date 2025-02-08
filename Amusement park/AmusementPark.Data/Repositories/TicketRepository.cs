
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
    public class TicketRepository : Repository<TicketEntity>, ITicketRepository
    {
        readonly DbSet<TicketEntity> _dbset;
        public TicketRepository(DataContext dataContext)
            : base(dataContext)
        {
            _dbset = dataContext.Set<TicketEntity>();
        }
        public async Task<IEnumerable<TicketEntity>> GetFullAsync()
        {
            return await _dbset.Include(z => z.orderId).ToListAsync();
        }
    }
}
