using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonelSozlesmeTakip.BL.Abstract;
using PersonelSozlesmeTakip.Entities.Concreate;

namespace PersonelSozlesmeTakip.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        private readonly IGenericService<University> _service;

        public UniversityController(IGenericService<University> service)
        {
            this._service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(_service.GetAll());
        }

        [HttpGet]
        public IActionResult GetById(Guid Id)
        {
            var entity = _service.GetById(Id);
            if (entity!=null)
            {
                return Ok(entity);
            }
            else
            {
                return BadRequest();    
            }
        }
    }
}
