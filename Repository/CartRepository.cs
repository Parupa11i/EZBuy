using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZBuy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EZBuy.Repository
{
    public class CartRepository
    {
        private readonly ApplicationDbContext _db;

        public CartRepository(ApplicationDbContext db)
        {
            _db = db;
            RefreshCartCount();
        }

        [BindProperty]
        public Cart Cart { get; set; }

        public void RefreshCartCount()
        {
            IQueryable<Cart> cartCount = _db.Cart;
            Global.CartSize = cartCount.Count();
        }

        public async Task<List<Cart>> GetCart(int? id)
        {
            List<Cart> carts;
            if((id is null) || (id == 0))
            {
                carts = await _db.Cart.ToListAsync();
                return carts;
            }
            else
            {
                var cart = await _db.Cart.FindAsync(id);
                carts = new List<Cart>();
                carts.Add(cart);
                return carts;
            }
        }

        public async Task UpsertCart(string? sku, string? itemDescr, int? qty, double? price)
        {
            var cart = await _db.Cart.FirstOrDefaultAsync(u => u.SKU == sku);
            if (cart != null)
            {
                cart.Quantity = (int)qty;
                cart.TotalPrice = (int)qty * (double)price;

                _db.Cart.Update(cart);
            }
            else
            {
                Cart newCart = new Cart
                {
                    SKU = sku,
                    Description = itemDescr,
                    Quantity = (int)qty,
                    UnitPrice = (double)price,
                    TotalPrice = (double)(qty * price)
                };

                await _db.Cart.AddAsync(newCart);
            }
            _db.SaveChanges();
            RefreshCartCount();
        }

        public async Task<bool> DeleteItemFromCart(int id)
        {
            if (id != 0)
            {
                var item = await _db.Cart.FindAsync(id);
                _db.Cart.Remove(item);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}