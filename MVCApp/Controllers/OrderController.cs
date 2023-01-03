using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace Bakery.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/Vendors/{vendorId}/Orders/Create")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
  }
}