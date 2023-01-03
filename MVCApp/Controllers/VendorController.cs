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
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/Vendors/Create")]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost("/Vendor")]
    public ActionResult Create(string name, string description)
    {
      Vendor myVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }
  }
}