using System.Collections.Generic;

namespace MVCApp.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public int Price {get; set; }
    public string Date { get; set; }
    private static List<Order> _instance = new List<Order> { };


    public Order(string title, string date, string description, int price)
    {
      Title = title;
      Date = date;
      Description = description;
      Price = price;
      _instance.Add(this);
      Id = _instance.Count;
    }

    public static void ClearAll()
    {
      _instance.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instance;
    }

    public static Order Find(int searchId)
    {
      return _instance[searchId - 1];
    }
  }
}