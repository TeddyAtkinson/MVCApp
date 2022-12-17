using System.Collections.Generic;
using MVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/Vendors")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/Vendors/Create")]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost("/Vendors")]
    public ActionResult Create(string name)
    {
      Vendor myVendor = new Vendor(name, description);
        return RedirectToAction("Index");
    }
  }
}