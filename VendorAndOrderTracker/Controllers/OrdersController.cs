using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult DeleteOrder(int vendorId, int orderId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      Order order = Order.Find(orderId);
      vendor.RemoveOrder(order);
      return View(vendor);
    }

    [HttpPost("/vendors/{vendorId}/orders/delete")]
    public ActionResult DeleteOrder(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      vendor.RemoveAllOrders();
      return View(vendor);
    }
  }
}