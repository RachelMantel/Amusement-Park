using AmusementPark.Api.PostModels;
using AmusementPark.Core.DTOs;
using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceService;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmusementPark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly Iservice<CustomerDto> _customerService;
        private readonly IMapper _mapper;
        public CustomerController(Iservice<CustomerDto> customerService,IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public List<CustomerDto> Get()
        {
            return _customerService.getall().ToList();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult<CustomerDto> Get(int id)
        {
            if (_customerService.getById(id) == null)
                return NotFound();
            return Ok(_customerService.getById(id));
        }


        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] CustomerPostModel customer)
        {
            var customerDto = _mapper.Map<CustomerDto>(customer);
            customerDto = _customerService.add(customerDto);
            return Ok(customerDto);

        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CustomerPostModel customer)
        {
            var customerDto = _mapper.Map<CustomerDto>(customer);
            customerDto = _customerService.update(id,customerDto);
            return Ok(customerDto);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!_customerService.delete(id))
                return NotFound();
            return Ok();
        }
    }
}
