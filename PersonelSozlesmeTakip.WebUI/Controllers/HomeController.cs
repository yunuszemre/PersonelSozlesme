using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PersonelSozlesmeTakip.BL.Abstract;
using PersonelSozlesmeTakip.Entities.Concreate;
using PersonelSozlesmeTakip.WebUI.Models;
using System.Diagnostics;

namespace PersonelSozlesmeTakip.WebUI.Controllers
{
    public class HomeController : Controller
    {

        string uri = "https://localhost:7113";
        private readonly ILogger<HomeController> _logger;
        private readonly IUniversityService _service;
        private readonly IPersonelService _personelService;

        public HomeController(ILogger<HomeController> logger, IUniversityService service, IPersonelService personelService)
        {
            _logger = logger;
            this._service = service;
            this._personelService = personelService;
        }

        public async Task<IActionResult> Index()
        {

            var value = _service.GetAll(x => x.Faculties, x1 => x1.Campuses, x2 => x2.Admin).ToList();
            return View(value);
        }
        public IActionResult CreateUniversity()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUniversity(University university)
        {
            if (university != null)
            {
                university.CerateDate = DateTime.Now;
                university.ModifiedDate = DateTime.Now;

                _service.Add(university);
            }

            return RedirectToAction("Index", "Home");
        }
        public IActionResult ShowUniDetail(Guid Id)
        {
            var uni = _service.GetById(Id);
            return View(uni);
        }
        public IActionResult CreatePersonel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePersonel(Personel personel)
        {
            if (personel != null)
            {
                personel.CerateDate = DateTime.Now;
                personel.ModifiedDate = DateTime.Now;
                personel.FacultyId = Guid.Parse("28b93dc0-7d0b-447f-bb8c-955a95ea876a");
                personel.UniversityId = Guid.Parse("f67a871d-ce39-472d-bc5f-88f0a184c55c");

                _personelService.Add(personel);
            }
            return View();
        }
        public IActionResult EditPersonel(Guid Id)
        {
            var personel = _personelService.GetById(Id);
            var uni = _service.GetById(personel.UniversityId);
            ViewBag.Uni = uni;
            return View(personel);
        }
        [HttpPost]
        public IActionResult EditPersonel(Personel personel)
        {
            if (personel != null)
            {
                var updatedPersonel = _personelService.GetById(personel.Id);
                updatedPersonel.ModifiedDate = DateTime.Now;
                updatedPersonel.ContractEndDate = personel.ContractEndDate;
                updatedPersonel.ImagePath = personel.ImagePath;
                updatedPersonel.Email = personel.Email;
                updatedPersonel.Name = personel.Name;
                updatedPersonel.FacultyId = personel.FacultyId;
                updatedPersonel.ImagePath = personel.ImagePath;
                updatedPersonel.LastName = personel.LastName;
                updatedPersonel.Phone = personel.Phone;
                updatedPersonel.IntegratedPhone = personel.IntegratedPhone;
                updatedPersonel.UniversityId = personel.UniversityId;

                _personelService.Update(updatedPersonel);
            }
            return RedirectToAction("EditPersonel", "Home");
        }

        public IActionResult PersonelList()
        {
            var personels = _personelService.GetAll(x => x.Faculty, x1 => x1.Departments, x2 => x2.University).OrderBy(x3 => x3.ContractEndDate).ToList();

            return View(personels);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}