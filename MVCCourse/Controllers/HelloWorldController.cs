using Microsoft.AspNetCore.Mvc;

namespace MVCCourse.Controllers
{
    public class HelloWorldController : Controller
    {
        public String Index()
        {
            return "This is the Index Page";
        }

        public String Hello()
        {
            return "Who's there";
        }
    }
}
