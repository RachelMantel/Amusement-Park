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
        readonly IRepositoryManager _repositoryManager;

        public OrderService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public IEnumerable<OrderEntity> getall()
        {
            return _repositoryManager._orderRepository.GetFull();
        }

        public OrderEntity getById(int id)
        {
            return _repositoryManager._orderRepository.GetById(id);
        }

        public OrderEntity add(OrderEntity order)
        {
            if (order == null)
                return null;
            var help=_repositoryManager._orderRepository.Add(order);
            _repositoryManager.save();
            return help;
        }

        public OrderEntity update(int id,OrderEntity order)
        {
            var help = _repositoryManager._orderRepository.Update(id, order);
            _repositoryManager.save();
            return help;
        }

        public bool delete(int id)
        {

            var help = _repositoryManager._orderRepository.Delete(id);
            _repositoryManager.save();
            return help;
        }
    }
}
