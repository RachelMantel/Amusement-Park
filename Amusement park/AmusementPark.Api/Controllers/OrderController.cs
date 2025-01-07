using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmusementPark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly Iservice<OrderEntity> _orderService;

        public OrderController(Iservice<OrderEntity> orderService)
        {
            _orderService = orderService;
        }

        // GET: api/<OrderController>
        [HttpGet]
        public List<OrderEntity> Get()
        {
            return _orderService.getall().ToList();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public ActionResult<OrderEntity> Get(int id)
        {
            if (_orderService.getById(id) == null)
                return NotFound();
            return Ok(_orderService.getById(id));
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] OrderEntity order)
        {
            if (_orderService.add(order) != null)
                return Ok();
            return BadRequest();
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] OrderEntity order)
        {
            if (_orderService.update(id, order) == null)
                return NotFound();
            return Ok();
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!_orderService.delete(id))
                return NotFound();
            return Ok();
        }
    }
}
