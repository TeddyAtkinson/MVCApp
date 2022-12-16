using System.Collections.Generic;

namespace MvcApplication.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class Order
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}