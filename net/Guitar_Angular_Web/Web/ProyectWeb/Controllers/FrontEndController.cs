using Microsoft.AspNetCore.Mvc;

namespace AngularFront1.Controllers
{
    public class FrontEndController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
