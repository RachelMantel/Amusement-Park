
using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmusementPark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly Iservice<EmployeeEntity> _employeeService;

        public EmployeeController(Iservice<EmployeeEntity> employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public List<EmployeeEntity> Get()
        {
            return _employeeService.getall().ToList();
        }
        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<EmployeeEntity> Get(int id)
        {
            if (_employeeService.getById(id) == null)
                return NotFound();
            return Ok(_employeeService.getById(id));
        }


        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] EmployeeEntity employee)
        {
            if (_employeeService.add(employee) != null)
                return Ok();
            return BadRequest();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] EmployeeEntity employee)
        {
            if (_employeeService.update(id, employee) == null)
                return NotFound();
            return Ok();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!_employeeService.delete(id))
                return NotFound();
            return Ok();
        }
    }
}
