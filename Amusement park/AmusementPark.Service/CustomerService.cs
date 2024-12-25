using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceRepository;
using AmusementPark.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Service
{
    public class CustomerService : Iservice<CustomerEntity>
    {
        readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public IEnumerable<CustomerEntity> getall()
        {
            return _customerRepository.GetFull();
        }

        public CustomerEntity? getById(int id)
        {

            return _customerRepository.GetById(id);
        }

        public CustomerEntity add(CustomerEntity customer)
        {
            if (customer == null)
                return null;

            return _customerRepository.Add(customer);
        }

        public CustomerEntity update(int id,CustomerEntity customer)
        {
            return _customerRepository.Update(id,customer);
        }

        public bool delete(int id)
        {
            return _customerRepository.Delete(id);
        }

    }
}
