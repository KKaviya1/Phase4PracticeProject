using Microsoft.AspNetCore.Mvc;
using RainbowSchool.Models;

namespace RainbowSchool.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teacher = new List<Teacher>()
        {
            new Teacher { Id = 1, Name = "Mr.Santhosh", TeachingSubject = "English"},
            new Teacher { Id = 2, Name = "Mrs.Revathi", TeachingSubject = "Tamil"},
            new Teacher { Id = 3, Name = "Mr.Mani", TeachingSubject = "Maths"},
        };
        public IActionResult Index()
        {
            return View(teacher);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Teacher());
        }

        [HttpPost]
        public IActionResult Create(Teacher model)
        {
            if (ModelState.IsValid)
            {
                teacher.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}