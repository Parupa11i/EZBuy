using System;
using System.ComponentModel.DataAnnotations;

namespace EZBuy.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SKU { get; set; }
        public string SKUDescr { get; set; }

        public double LineCost { get; set; }
        public double OrderCost { get; set; }
        public int Qty { get; set; }
        public string OrderDesc { get; set; }
        public string Status { get; set; }
    }
}
