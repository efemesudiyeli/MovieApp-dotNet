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

        [HttpGet]
        public IActionResult AddMovie()
        {
            Console.WriteLine("Get çalıştı");
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie m)
        {
            Console.WriteLine("Post çalıştı");
            contex.Add(m);
            contex.SaveChanges();
            
            return RedirectToAction("Movie");
        }

        public IActionResult DeleteMovie(int id)
        {
            var mov = contex.movies.Find(id);
            contex.movies.Remove(mov);
            contex.SaveChanges();
            
            return RedirectToAction("Movie");
        }

        
        public IActionResult GetMovie(int id)
        {
            var movi = contex.movies.Find(id);
            return View(movi);
        }

        [HttpPost]
        public IActionResult EditMovie()
        {
            return View();
        }


        Context contex = new Context();
        public IActionResult Movie()
        {

            var props = contex.movies.ToList();

            // var mov = new List<Movie>()
            // {
            //     new Movie(){Id=1,Title="Titanic",ReleaseDate=DateTime.Now.ToString("dd/MM/yyyy"),Genre="Dram",Price=35},
            //     new Movie(){Id=2,Title="Aquaman",ReleaseDate=DateTime.Now.ToString("dd/MM/yyyy"),Genre="Fantastic",Price=40},
            //     new Movie(){Id=3,Title="Family Guy",ReleaseDate=DateTime.Now.ToString("dd/MM/yyyy"),Genre="Comedy",Price=40},
            // };
            return View(props      /*mov*/ );
        }
    }
}