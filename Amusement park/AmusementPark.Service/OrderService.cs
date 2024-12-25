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
    public class OrderService : Iservice<OrderEntity>
    {
        readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public IEnumerable<OrderEntity> getall()
        {
            return _orderRepository.GetFull();
        }

        public OrderEntity getById(int id)
        {

            return _orderRepository.GetById(id);
        }

        public OrderEntity add(OrderEntity order)
        {
            if (order == null)
                return null;

            return _orderRepository.Add(order);
        }

        public OrderEntity update(int id,OrderEntity order)
        {
            return _orderRepository.Update(id, order);
        }

        public bool delete(int id)
        {

          return _orderRepository.Delete(id);
        }
    }
}
