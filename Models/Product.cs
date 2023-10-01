using System;
using System.ComponentModel.DataAnnotations;

namespace EZBuy.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SKU { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }
        public int AvailableQty { get; set; }

    }
}
