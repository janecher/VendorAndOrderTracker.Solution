using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendors = Vendor.GetAll();
      return View(vendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrder = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrder);
      return View(model);
    }

    [HttpGet("/vendors/{id}/edit")]
    public ActionResult Edit(int id)
    {
      Vendor vendor = Vendor.Find(id);
      return View(vendor);
    }

    [HttpPost("/vendors/{id}/update")]
    public ActionResult Update(int id, string vendorName, string vendorDescription)
    {
      Vendor vendor = Vendor.Find(id);
      vendor.Name = vendorName;
      vendor.Description = vendorDescription;
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/{id}")]
    public ActionResult Destroy(int id)
    {
      Vendor.DeleteVendor(id);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, string price, string date)
    {
      int priceInput = int.Parse(price);
      string dateInput = date.Substring(5,2)+"/"+date.Substring(8,2)+"/"+date.Substring(0,4);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(title, description, priceInput, dateInput);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}