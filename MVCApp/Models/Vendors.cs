using System.Collections.Generic;

namespace MVCApp.Models
{
  public class Vendor
  {
    public int Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _vendors = new List<Vendor> { };
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendors.Add(this);
      Id = _vendors.Count;
      
    }

    public static List<Vendor> GetAll()
    {
      return _vendors;
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _vendors[searchId - 1];
    }
  }
}