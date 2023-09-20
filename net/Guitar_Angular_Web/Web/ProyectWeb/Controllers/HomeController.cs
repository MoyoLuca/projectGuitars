using Microsoft.AspNetCore.Mvc;

namespace Guitar.Angular.Web.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View("~/Views/Home/Index.cshtml");
    }

  }
}
