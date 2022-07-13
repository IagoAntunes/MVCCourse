using Microsoft.AspNetCore.Mvc;
using MVCCourse.Models;

namespace MVCCourse.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(dogs);
        }
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
            //return View("Index");
        }
        public IActionResult DeleteDog(String Name)
        {
            dogs.RemoveAll(a => a.Name.Equals(Name));
            return RedirectToAction(nameof(Index));
        }

        public String Hello()
        {
            return "Who's there";//NewViewt
        }
    }
}
