
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
    public class EmployeeController : ControllerBase
    {
        readonly Iservice<EmployeeDto> _employeeService;
        private readonly IMapper _mapper;

        public EmployeeController(Iservice<EmployeeDto> employeeService,IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public List<EmployeeDto> Get()
        {
            return _employeeService.getall().ToList();
        }
        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<EmployeeDto> Get(int id)
        {
            if (_employeeService.getById(id) == null)
                return NotFound();
            return Ok(_employeeService.getById(id));
        }


        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] EmployeePostModel employee)
        {
            var employeeDto = _mapper.Map<EmployeeDto>(employee);
            employeeDto = _employeeService.add(employeeDto);
            return Ok(employeeDto);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] EmployeePostModel employee)
        {
            var customerDto = _mapper.Map<EmployeeDto>(employee);
            customerDto = _employeeService.update(id,customerDto);
            return Ok(customerDto);
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
