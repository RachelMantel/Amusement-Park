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
    public class OrderService : Iservice<OrderDto>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public OrderService(IRepositoryManager repositoryManager,IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<IEnumerable<OrderDto>> getallAsync()
        {
            var orders = await _repositoryManager._orderRepository.GetFullAsync();
            var orderD = _mapper.Map<List<OrderDto>>(orders);
            return orderD;
        }

        public OrderDto getById(int id)
        {
            var order = _repositoryManager._orderRepository.GetById(id);
            var orderDto = _mapper.Map<OrderDto>(order);

            return orderDto;
        }

        public OrderDto add(OrderDto order)
        {
            if (order == null)
                return null;

            var orderD = _mapper.Map<OrderEntity>(order);
            _repositoryManager._orderRepository.Add(orderD);
            _repositoryManager.save();

            return _mapper.Map<OrderDto>(order);
        }

        public OrderDto update(int id,OrderDto order)
        {
            var orderModel = _mapper.Map<OrderEntity>(order);
            var help = _repositoryManager._orderRepository.Update(id, orderModel);
            if (help == null)
                return null;
            _repositoryManager.save();
            order = _mapper.Map<OrderDto>(help);
            return order;
        }

        public bool delete(int id)
        {

            var help = _repositoryManager._orderRepository.Delete(id);
            _repositoryManager.save();
            return help;
        }
    }
}
