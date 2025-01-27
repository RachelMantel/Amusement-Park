using AmusementPark.Api.PostModels;
using AmusementPark.Core.DTOs;
using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceService;
using AmusementPark.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmusementPark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {

        readonly Iservice<TicketDto> _ticketService;
        private readonly IMapper _mapper;

        public TicketController(Iservice<TicketDto> ticketService,IMapper mapper)
        {
            _ticketService = ticketService;
            _mapper = mapper;
        }
        // GET: api/<TicketController>
        [HttpGet]
        public List<TicketDto> Get()
        {
            return _ticketService.getall().ToList();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public ActionResult<TicketDto> Get(int id)
        {
            if (_ticketService.getById(id) == null)
                return NotFound();
            return Ok(_ticketService.getById(id));
        }

        // POST api/<TicketController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] TicketPostModel ticket)
        {
            var ticketDto = _mapper.Map<TicketDto>(ticket);
            ticketDto = _ticketService.add(ticketDto);
            return Ok(ticketDto);
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TicketPostModel ticket)
        {
            var ticketDto = _mapper.Map<TicketDto>(ticket);
            ticketDto = _ticketService.update(id,ticketDto);
            return Ok(ticketDto);
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!_ticketService.delete(id))
                return NotFound();
            return Ok();
        }
    }
}
