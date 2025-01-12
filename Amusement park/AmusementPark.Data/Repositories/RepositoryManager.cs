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

       public ICustomerRepository _customerRepository { get; set; }
       public IEmployeeRepository _employeeRepository { get; set; }
       public IFacilitieRepository _facilitieRepository { get; set; }
       public IOrderRepository _orderRepository { get; set; }
       public  ITicketRepository _ticketRepository { get; set; }
        public RepositoryManager(DataContext context,
            ICustomerRepository customerRepository,
            IEmployeeRepository employeeRepository,
            IFacilitieRepository facilitieRepository,
            IOrderRepository orderRepository,
            ITicketRepository ticketRepository)
        {
            _context = context;
            _customerRepository = customerRepository;
            _employeeRepository = employeeRepository;
            _facilitieRepository = facilitieRepository;
            _orderRepository = orderRepository;
            _ticketRepository = ticketRepository;
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
