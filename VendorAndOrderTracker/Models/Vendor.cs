using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public string Description {get; set;}
    public int Id {get;}
    public List<Order> Orders {get; set;}
    private static List<Vendor> _vendors = new List<Vendor>();
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>();
      _vendors.Add(this);
      Id = _vendors.Count;
    }
    public static void ClearAll()
    {
      _vendors.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _vendors;
    }
    public static Vendor Find(int searchId)
    {
      return _vendors[searchId-1];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
    public static void DeleteVendor(int vendorId)
    {
      _vendors.RemoveAt(vendorId-1);
    }
  }
}