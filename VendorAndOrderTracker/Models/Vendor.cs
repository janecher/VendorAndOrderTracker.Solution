using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public string Description {get; set;}
    public int Id {get;}
    private static int NextUniqueId = 1;
    public List<Order> Orders {get; set;}
    private static List<Vendor> _vendors = new List<Vendor>();
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>();
      _vendors.Add(this);
      Id = NextUniqueId++;
    }
    public static void ClearAll()
    {
      _vendors.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _vendors;
    }
    private static int FindIndexById(int id)
    {
      for(int i = 0; i < _vendors.Count; i++)
      {
        if(_vendors[i].Id == id)
        {
          return i;
        }
      }
      throw new Exception("Vendor not found for ID: " + id.ToString());
    }
    public static Vendor Find(int id)
    {
      return _vendors[FindIndexById(id)];
    }    
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
    public void RemoveOrder(Order order)
    {
      Orders.Remove(order);
    }
    public void RemoveAllOrders(Order order)
    {
      Orders.Clear();
    }
    public static void DeleteVendor(int vendorId)
    {
      _vendors.RemoveAt(FindIndexById(vendorId));
    }
  }
}