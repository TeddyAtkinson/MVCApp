using System.Collections.Generic;

namespace MVCApp.Models
{
  public class Order
  {
    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
  }
}