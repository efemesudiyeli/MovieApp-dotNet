using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

using MvcMovie.Models;


namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/


        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name = "Kullanıcı", int numTimes = 2)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();

        }

        public IActionResult Movie()
        {
            var mov = new List<Movie>()
            {
                new Movie(){Id=1,Title="Titanic",ReleaseDate=DateTime.Now,Genre="Dram",Price=35},
                new Movie(){Id=2,Title="Aquaman",ReleaseDate=DateTime.Now,Genre="Fantastic",Price=40},
                new Movie(){Id=3,Title="Family Guy",ReleaseDate=DateTime.Now,Genre="Comedy",Price=40},
            };
            return View(mov);
        }
    }
}