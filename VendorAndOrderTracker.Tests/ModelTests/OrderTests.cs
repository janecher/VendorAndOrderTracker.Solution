using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      DateTime date = new DateTime(2020, 7, 24);
      Order order = new Order("bread", "multigrain", 3, date);
      Assert.AreEqual(typeof(Order), order.GetType());
    }
  }
}