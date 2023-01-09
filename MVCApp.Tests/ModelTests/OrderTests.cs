using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCApp.Models;
using System.Collections.Generic;
using System;

namespace MVCApp.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void Constructor_CreatesInstanceofOrder_Order()
    {
      Order testOrder = new Order("test", "test", "test", 1);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      Order testOrder = new Order("test", "test", "test", 1);
      Assert.AreEqual(1, testOrder.Id);
    }

    [TestMethod]
    public void GetTotalPrice_ReturnsTotalPrice_Int()
    {
      Order testOrder = new Order("test", "test", "test", 1);
      Assert.AreEqual(2, testOrder.Price);
    }

    [TestMethod]
    public void GetAll_ReturnsListofOrders_OrderList()
    {
      Order testOrder1 = new Order("test", "test", "test", 1);
      Order testOrder2 = new Order("test", "test", "test", 1);
      List<Order> orderList = new List<Order> { testOrder1, testOrder2 };
      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(orderList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order testOrder1 = new Order("test", "test", "test", 1);
      Order testOrder2 = new Order("test", "test", "test", 1);
      Order result = Order.Find(2);
      Assert.AreEqual(testOrder2, result);
    }
  }
}