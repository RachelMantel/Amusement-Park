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
        readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public IEnumerable<TicketEntity> getall()
        {
            return _ticketRepository.GetFull();
        }

        public TicketEntity getById(int id)
        {

            return _ticketRepository.GetById(id);
        }

        public TicketEntity add(TicketEntity ticket)
        {
            if (ticket == null)
                return null;

            return _ticketRepository.Add(ticket);
        }

        public TicketEntity update(int id,TicketEntity ticket)
        {
            return _ticketRepository.Update(id,ticket);
        }

        public bool delete(int id)
        {

           return _ticketRepository.Delete(id);
        }
    }
}
