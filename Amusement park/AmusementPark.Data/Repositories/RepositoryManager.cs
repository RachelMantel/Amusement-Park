using AmusementPark.Core.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Data.Repositories
{
    public class RepositoryManager:IRepositoryManager
    {
        private readonly DataContext _context;

        public RepositoryManager(DataContext context)
        {
            _context = context;
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
