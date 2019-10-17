using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    //localhost:5000
    //localhost:5000/home
    public class HomeController : Controller
    {
        //localhost:5000/home/index => home/index.cshtml
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewBag.Greeting = saat > 12 ? "Günaydın" : "İyi Günler";
            ViewBag.UserName = "Mehmet";


            return View();
        }
        //localhost:5000/home/about => home/about.cshtml
        public IActionResult About()
        {
            return View();
        }
    }
}