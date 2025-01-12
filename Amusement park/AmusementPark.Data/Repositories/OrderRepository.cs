
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
    public class OrderRepository : Repository<OrderEntity>, IOrderRepository
    {
        readonly DbSet<OrderEntity> _dbset;
        public OrderRepository(DataContext dataContext)
            : base(dataContext)
        {
            _dbset = dataContext.Set<OrderEntity>();
        }
        public IEnumerable<OrderEntity> GetFull()
        {
            return _dbset.Include(o =>o.ticket).Include(o => o.Customer).ToList();
        }
    }
}
