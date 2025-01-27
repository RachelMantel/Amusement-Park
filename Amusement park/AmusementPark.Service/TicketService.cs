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
    public class TicketService : Iservice<TicketDto>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper; 

        public TicketService(IRepositoryManager repositoryManager,IMapper mapper)
        {
            repositoryManager = _repositoryManager;
            _mapper = mapper;
        }
        public IEnumerable<TicketDto> getall()
        {
            var tickets = _repositoryManager._ticketRepository.GetFull();
            //map to dto
            var ticketDtos = _mapper.Map<List<TicketDto>>(tickets);
            return ticketDtos;
        }

        public TicketDto getById(int id)
        {

            var ticket = _repositoryManager._ticketRepository.GetById(id);
            var ticketDto = _mapper.Map<TicketDto>(ticket);

            return ticketDto;
        }

        public TicketDto add(TicketDto ticket)
        {
            if (ticket == null)
                return null;

            var ticketD = _mapper.Map<TicketEntity>(ticket);
            _repositoryManager._ticketRepository.Add(ticketD);
            _repositoryManager.save();

            return _mapper.Map<TicketDto>(ticket);
        }

        public TicketDto update(int id,TicketDto ticket)
        {
            var ticketModel = _mapper.Map<TicketEntity>(ticket);
            var help = _repositoryManager._ticketRepository.Update(id, ticketModel);
            if (help == null)
                return null;
            _repositoryManager.save();
            ticket = _mapper.Map<TicketDto>(help);
            return ticket;
        }

        public bool delete(int id)
        {
            var help = _repositoryManager._ticketRepository.Delete(id);
            _repositoryManager.save();
            return help;
        }
    }
}
