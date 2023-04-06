using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //Get: /HelloWorld
        public IActionResult Index()
        {
            return View();
        }
        //Get: /HelloWorld/Welcome?name=...&number=
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["message"] = "Hello, " + name;
            ViewData["numTimes"] = numTimes;
            return View();
        }
    }
}
