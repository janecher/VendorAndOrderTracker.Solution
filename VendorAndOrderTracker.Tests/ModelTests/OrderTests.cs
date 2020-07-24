using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order order = new Order("bread", "multigrain", 3, "07/24/2020");
      Assert.AreEqual(typeof(Order), order.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      Order order1 = new Order("bread", "multigrain", 3, "07/24/2020");
      Order order2 = new Order("bread", "white", 2, "07/24/2020");
      List<Order> newList = new List<Order> {order1, order2};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    
    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      Order order = new Order("bread", "multigrain", 3, "07/24/2020");
      int result = order.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order order1 = new Order("bread", "multigrain", 3, "07/24/2020");
      Order order2 = new Order("bread", "white", 2, "07/24/2020");
      Order result = Order.Find(2);
      Assert.AreEqual(order2, result);
    }
  }
}