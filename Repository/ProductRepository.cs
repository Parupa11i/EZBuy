using System;
using System.Collections.Generic;
using System.Linq;
using EZBuy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace EZBuy.Repository
{
    public class ProductRepository
    {

        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Product productModel { get; set; }


        public async Task<List<Product>> GetAllProducts()
        {
            var myProducts = await _db.Products.ToListAsync();
            return myProducts;
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _db.Products.FirstOrDefaultAsync(u => u.Id == id);

        }

        public async Task<List<Product>> SearchProduct()
        {
            //            return await _db.Products.FirstOrDefaultAsync(u => u.SKU.Contains(sku));
            var prodList = await _db.Products.Where(u => u.Description.Contains(Global.SearchQuery)).ToListAsync();
            return prodList;
        }
    }
}