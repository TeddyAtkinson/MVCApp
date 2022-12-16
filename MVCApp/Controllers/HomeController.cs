using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}