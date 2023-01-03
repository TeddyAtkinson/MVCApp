using System;
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

    [HttpPost("/Vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor myVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }
    
    [HttpGet("/Vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("Vendor", selectedVendor);
      model.Add("Orders", vendorOrders);
      return View(model);
    }
  }
}