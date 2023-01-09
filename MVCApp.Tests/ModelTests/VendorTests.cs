using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCApp.Models;
using System.Collections.Generic;
using System;

namespace MVCApp.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("testName1", "testInfo1");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor testVendor1 = new Vendor("testName1", "testInfo1");
      Vendor testVendor2 = new Vendor("testName2", "testInfo2");
      int result = testVendor2.Id;
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendorObjects_List()
    {
      Vendor testVendor1 = new Vendor("testName1", "testInfo1");
      Vendor testVendor2 = new Vendor("testName2", "testInfo2");
      List<Vendor> vendorList = new List<Vendor> { testVendor1, testVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(vendorList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor testVendor1 = new Vendor("testName1", "testInfo1");
      Vendor testVendor2 = new Vendor("testName2", "testInfo2");
      List<Vendor> vendorList = new List<Vendor> { testVendor1, testVendor2 };
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(testVendor2, result);
    }

    [TestMethod]
    public void AddOrder_CreatesOrderWithinVendor_OrderList()
    {
      Order newOrder = new Order("test", "test", "test", 1);
      List<Order> newList = new List<Order> { newOrder };
      Vendor newVendor = new Vendor("testName1", "testInfo1");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}