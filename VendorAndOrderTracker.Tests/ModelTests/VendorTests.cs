using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstancesOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Some vendor", "Vendor description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor vendor1 = new Vendor("Vendor1", "Vendor1 description");
      Vendor vendor2 = new Vendor("Vendor2", "Vendor2 description");
      List<Vendor> newList = new List<Vendor> {vendor1, vendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor vendor1 = new Vendor("Vendor1", "Vendor1 description");
      Vendor vendor2 = new Vendor("Vendor2", "Vendor2 description");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(vendor2, result);
    }
    
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      DateTime date = new DateTime(2020, 7, 24);
      Order order = new Order("bread", "multigrain", 3, date);
      List<Order> ordersList = new List<Order> {order};
      Vendor newVendor = new Vendor("Some vendor", "Vendor description");
      newVendor.AddOrder(order);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(ordersList, result);
    }
  }
}