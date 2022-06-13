using Microsoft.AspNetCore.Mvc;
using MVCCourse.Models;

namespace MVCCourse.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() //ViewModel
            { Name="Sif",Age = 12};

            return View(doggo);
        }

        public String Hello()
        {
            return "Who's there";//NewViewt
        }
    }
}
