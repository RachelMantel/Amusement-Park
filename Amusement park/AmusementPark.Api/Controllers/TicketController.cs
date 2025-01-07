using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmusementPark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {

        readonly Iservice<TicketEntity> _ticketService;

        public TicketController(Iservice<TicketEntity> ticketService)
        {
            _ticketService = ticketService;
        }
        // GET: api/<TicketController>
        [HttpGet]
        public List<TicketEntity> Get()
        {
            return _ticketService.getall().ToList();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public ActionResult<TicketEntity> Get(int id)
        {
            if (_ticketService.getById(id) == null)
                return NotFound();
            return Ok(_ticketService.getById(id));
        }

        // POST api/<TicketController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] TicketEntity ticket)
        {
            if (_ticketService.add(ticket) != null)
                return Ok();
            return BadRequest();
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TicketEntity ticket)
        {
            if (_ticketService.update(id, ticket) == null)
                return NotFound();
            return Ok();
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
