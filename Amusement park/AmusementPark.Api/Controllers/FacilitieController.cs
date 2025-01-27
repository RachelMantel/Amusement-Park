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
    public class FacilitieController : ControllerBase
    {
        readonly Iservice<FacilitieDto> _facilityService;
        private readonly IMapper _mapper;
        public FacilitieController(Iservice<FacilitieDto> facilityService,IMapper mapper)
        {
            _facilityService = facilityService;
            _mapper = mapper;
        }

        // GET: api/<FacilitieController>
        [HttpGet]
        public List<FacilitieDto> Get()
        {
            return _facilityService.getall().ToList();
        }

        // GET api/<FacilitieController>/5
        [HttpGet("{id}")]
        public ActionResult<FacilitieDto> Get(int id)
        {
            if (_facilityService.getById(id) == null)
                return NotFound();
            return Ok(_facilityService.getById(id));
        }
        // POST api/<FacilitieController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] FacilitiePostModel facilitie)
        {
            var facilitieDto = _mapper.Map<FacilitieDto>(facilitie);
            facilitieDto = _facilityService.add(facilitieDto);
            return Ok(facilitieDto);
        }

        // PUT api/<FacilitieController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] FacilitiePostModel facilitie)
        {
            var facilitieDto = _mapper.Map<FacilitieDto>(facilitie);
            facilitieDto = _facilityService.update(id,facilitieDto);
            return Ok(facilitieDto);
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
