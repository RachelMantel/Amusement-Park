using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmusementPark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly Iservice<CustomerEntity> _customerService;

        public CustomerController(Iservice<CustomerEntity> customerService)
        {
            _customerService = customerService;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public List<CustomerEntity> Get()
        {
            return _customerService.getall().ToList();
 
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult<CustomerEntity> Get(int id)
        {
            if (_customerService.getById(id) == null)
                return NotFound();
            return Ok(_customerService.getById(id));
        }


        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] CustomerEntity customer)
        {
            if (_customerService.add(customer)!=null)
                return Ok();
            return BadRequest();
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CustomerEntity customer)
        {
            if (_customerService.update(id, customer)==null)
                return NotFound();
            return Ok();
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
