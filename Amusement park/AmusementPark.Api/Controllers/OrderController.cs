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
    public class OrderController : ControllerBase
    {
        readonly Iservice<OrderDto> _orderService;
        private readonly IMapper _mapper;
        public OrderController(Iservice<OrderDto> orderService,IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        // GET: api/<OrderController>
        [HttpGet]
        public async Task<List<OrderDto>> Get()
        {
            return (List<OrderDto>)await _orderService.getallAsync();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public ActionResult<OrderDto> Get(int id)
        {
            if (_orderService.getById(id) == null)
                return NotFound();
            return Ok(_orderService.getById(id));
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] OrderPostModel order)
        {
            var orderDto = _mapper.Map<OrderDto>(order);
            orderDto = _orderService.add(orderDto);
            return Ok(orderDto);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] OrderPostModel order)
        {
            var orderDto = _mapper.Map<OrderDto>(order);
            orderDto = _orderService.update(id,orderDto);
            return Ok(orderDto);
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
