using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Core.InterfaceRepository
{
    public interface IRepositoryManager
    {
        ICustomerRepository _customerRepository { get; set; }
        IEmployeeRepository _employeeRepository { get; set; }
        IFacilitieRepository _facilitieRepository { get; set; }
        IOrderRepository _orderRepository { get; set; }
        ITicketRepository _ticketRepository { get; set; }
        void save();
      
    }
}
