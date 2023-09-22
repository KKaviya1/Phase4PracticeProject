using Microsoft.AspNetCore.Mvc;
using RainbowSchool.Models;

namespace RainbowSchool.Controllers
{
    public class StudentController : Controller
    {
        List<Student> student = new List<Student>()
        {
            new Student { Id = 1, Name = "Viya", Class = "9B", Age = 17, Address = "Mission Street"},
            new Student { Id = 2, Name = "Prakash", Class = "7A", Age = 15, Address = "Pattanur"},
            new Student { Id = 3, Name = "Praveen", Class = "8C", Age = 16, Address = "432 some where "},
        };
        public IActionResult Index()
        {
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                student.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}