using System.Collections.Generic;

namespace MVCApp.Models
{
    public class Vendor
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        private static List<Vendor> _vendors = new List<Vendor> { };

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            _vendors.Add(this);
            Id = _vendors.Count;
        }


        // public static List<Vendor> GetAll()
        // {
        //     return _orders;
        // }
    }

    public class Order
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        // public DateTime Date { get; set; }
    }
}