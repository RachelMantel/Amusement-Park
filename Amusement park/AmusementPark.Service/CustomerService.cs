using AmusementPark.Core.DTOs;
using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceRepository;
using AmusementPark.Core.InterfaceService;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Service
{
    public class CustomerService : Iservice<CustomerDto>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public CustomerService(IRepositoryManager repositoryManager,IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CustomerDto>> getallAsync()
        {
            var customers = await _repositoryManager._customerRepository.GetFullAsync();
            var customerDtos = _mapper.Map<List<CustomerDto>>(customers);
            return customerDtos;
        }

        public CustomerDto? getById(int id)
        {
            var customer = _repositoryManager._customerRepository.GetById(id);
            var customerDtos = _mapper.Map<CustomerDto>(customer);

            return customerDtos;
        }

        public CustomerDto add(CustomerDto customer)
        {
            if (customer == null)
                return null;

            var customerModel = _mapper.Map<CustomerEntity>(customer);
            _repositoryManager._customerRepository.Add(customerModel);
            _repositoryManager.save();

            return _mapper.Map<CustomerDto>(customer);

        }

        public CustomerDto update(int id,CustomerDto customer)
        {
           
            var customerModel = _mapper.Map<CustomerEntity>(customer);
            var help = _repositoryManager._customerRepository.Update(id,customerModel);
            if (help == null)
                return null;
            _repositoryManager.save();
           customer = _mapper.Map<CustomerDto>(help);
            return customer;
        }

        public bool delete(int id)
        {
            var b=_repositoryManager._customerRepository.Delete(id);
            _repositoryManager.save();
            return b;
        }

    }
}
