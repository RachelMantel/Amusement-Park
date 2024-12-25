using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmusementPark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilitieController : ControllerBase
    {
        readonly Iservice<FacilitieEntity> _facilityService;

        public FacilitieController(Iservice<FacilitieEntity> facilityService)
        {
            _facilityService = facilityService;
        }

        // GET: api/<FacilitieController>
        [HttpGet]
        public List<FacilitieEntity> Get()
        {
            return _facilityService.getall().ToList();
        }

        // GET api/<FacilitieController>/5
        [HttpGet("{id}")]
        public ActionResult<FacilitieEntity> Get(int id)
        {
            if (_facilityService.getById(id) == null)
                return NotFound();
            return Ok(_facilityService.getById(id));
        }
        // POST api/<FacilitieController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] FacilitieEntity facilitie)
        {
            if (_facilityService.add(facilitie) != null)
                return Ok();
            return BadRequest();
        }

        // PUT api/<FacilitieController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] FacilitieEntity facilitie)
        {
            if (_facilityService.update(id, facilitie)==null)
                return NotFound();
            return Ok();
        }


        // DELETE api/<FacilitieController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           if(!_facilityService.delete(id))
            return NotFound();
            return Ok();
        }
    }
}
