using System.Linq;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        //action method
        //localhost:5000/course => course/index.cshtml
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Apply()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View(student);
            }
        }
        public IActionResult Details()
        {
            var course = new Course();
            course.Name = "Core MVC Kursu";
            course.description = "Güzel Bir Kurs";
            course.isPublished = true;
            return View(course);
        }
        //localhost:5000/course => course/List.cshtml
        public IActionResult List()
        {
            var students = Repository.Students.Where(i => i.Confirm == true);
            return View(students);
        }
    }
}