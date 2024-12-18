using System.Diagnostics;
using System.Net.Cache;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();

        }
        public IActionResult Myform()
        {
            //var model = new
            //{
            //    Name = "enter your name",
            //    Age = 0,
            //    Address = Address,
            //    faculty = faculty,
            //};


            return View();

        }

        //[HttpPost]
        //public IActionResult Myform(string Name, int Age, string Address, string Faculty, string Email)
        //{
        //    var model = new
        //    {
        //        Name = Name,
        //        Age = Age,
        //        Address = Address,
        //        Faculty = Faculty,
        //        Email = Email,
        //    };


        //    return View(model);

        //}
        [HttpPost]
        public IActionResult Myform(Persons model)
        {
            if (!ModelState.IsValid)
            { 
                ViewBag.message = "data not dubmitted";
                return View(model);
            }
            ViewBag.Message = "data submit successfully";
            return View(model);

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}