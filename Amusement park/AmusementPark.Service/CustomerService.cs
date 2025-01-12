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
        readonly IRepositoryManager _repositoryManager;

        public CustomerService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public IEnumerable<CustomerEntity> getall()
        {
            return _repositoryManager._customerRepository.GetFull();
        }

        public CustomerEntity? getById(int id)
        {

            return _repositoryManager._customerRepository.GetById(id);
        }

        public CustomerEntity add(CustomerEntity customer)
        {
            if (customer == null)
                return null;
           
            var help =_repositoryManager._customerRepository.Add(customer);
            _repositoryManager.save();
            return help;
        }

        public CustomerEntity update(int id,CustomerEntity customer)
        {
            var help = _repositoryManager._customerRepository.Update(id,customer);
            _repositoryManager.save();
            return help;
        }

        public bool delete(int id)
        {
            var b=_repositoryManager._customerRepository.Delete(id);
            _repositoryManager.save();
            return b;
        }

    }
}
