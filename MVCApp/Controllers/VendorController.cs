using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
  // private static List<Vendor> vendors = new List<Vendor>();

  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View();
    }
  }
}