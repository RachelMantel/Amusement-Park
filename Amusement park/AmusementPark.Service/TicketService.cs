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
    public class TicketService : Iservice<TicketEntity>
    {
        readonly IRepositoryManager _repositoryManager;

        public TicketService(IRepositoryManager repositoryManager)
        {
            repositoryManager = _repositoryManager;
        }
        public IEnumerable<TicketEntity> getall()
        {
            return _repositoryManager._ticketRepository.GetFull();
        }

        public TicketEntity getById(int id)
        {

            return _repositoryManager._ticketRepository.GetById(id);
        }

        public TicketEntity add(TicketEntity ticket)
        {
            if (ticket == null)
                return null;

            var help=_repositoryManager._ticketRepository.Add(ticket);
            _repositoryManager.save();
            return help;
        }

        public TicketEntity update(int id,TicketEntity ticket)
        {
            var help = _repositoryManager._ticketRepository.Update(id,ticket);
            _repositoryManager.save();
            return help;
        }

        public bool delete(int id)
        {
            var help = _repositoryManager._ticketRepository.Delete(id);
            _repositoryManager.save();
            return help;
        }
    }
}
