using Microsoft.AspNetCore.Mvc;

namespace MVCCourse.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String Hello()
        {
            return "Who's there";
        }
    }
}
