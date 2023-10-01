using System;
using System.ComponentModel.DataAnnotations;

namespace EZBuy.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}
