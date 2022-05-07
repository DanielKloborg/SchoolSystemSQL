using Microsoft.AspNetCore.Mvc;
using School.Models;
using System.Linq;

namespace School.Controllers {
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult InsertStudent()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InsertStudent(StudentCheck studentCheck)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(studentCheck);
                return View("Exit", studentCheck);
            }
            else
            {
                return View();
            }
        }
        public ViewResult ListStudents()
        {
            return View(Repository.Responses.Where(r => r.Semester >= 1 && r.Semester < 6));
        }

        private ISchoolRepository repository;
        public HomeController(ISchoolRepository repo)
        {
            repository = repo;
        }

        public IActionResult Indexed() => View(repository.StudentCheck);

        public IActionResult Admin() => View(repository.StudentCheck);
    }
}