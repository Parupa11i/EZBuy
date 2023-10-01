using System;
using Microsoft.EntityFrameworkCore;

namespace EZBuy.Models
{
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }

            public DbSet<Order> Orders { get; set; }

            public DbSet<Product> Products { get; set; }

            public DbSet<Cart> Cart { get; set; }
    }
}
