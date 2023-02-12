using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using PersonelSozlesmeTakip.BL.Abstract;
using PersonelSozlesmeTakip.Entities.Concreate;


namespace PersonelSozlesmeTakip.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        private readonly IUniversityService _service;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;

        public UniversityController(IUniversityService service, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            this._service = service;
            this._environment = environment;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var universities = _service.GetAll(x => x.Faculties, x => x.Admin, x => x.Campuses).ToList();
            return Ok(universities);
        }

        [HttpGet]
        public IActionResult GetById(Guid Id)
        {
            var entity = _service.GetById(Id);
            if (entity != null)
            {
                return Ok(entity);
            }
            else
            {
                return BadRequest("Girilen Id'ye sahip bir Üniversite bulunamadı");
            }
        }
        [HttpPost]
        public IActionResult CreateUniversity([FromBody] University university)
        {



            if (ModelState.IsValid)
            {
                _service.Add(university);
                return Ok();

            }
            else
            {
                return BadRequest();
            }

        }
    }
}
