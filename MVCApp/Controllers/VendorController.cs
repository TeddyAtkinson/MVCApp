using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/tamas")]
    public ActionResult Index()
    {
      List<Tama> allTamas = Tama.GetAll();
      return View(allTamas);
    }
  }
}