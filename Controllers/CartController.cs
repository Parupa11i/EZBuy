using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EZBuy.Models;
using EZBuy.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EZBuy.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly CartRepository _cartrepo;

        public CartController(ApplicationDbContext db)
        {
            _db = db;
            _cartrepo = new CartRepository(_db);
        }
        // GET: /<controller>/
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var cart = await _cartrepo.GetCart(0);
            ViewBag.CartSize = Global.CartSize;
            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteItemFromCart(int id)
        {
            await _cartrepo.DeleteItemFromCart(id);

            var cart = await _cartrepo.GetCart(0);
            ViewBag.CartSize = Global.CartSize;
            return RedirectToAction("Index",cart);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditQty(int? id, int? newQty, string? sku, double? unitprice)
        {
            ViewBag.ItemId = id;
            if (sku != null)
            {
                await _cartrepo.UpsertCart(sku, null, newQty, unitprice);
                ViewBag.CartSize = Global.CartSize;
                return RedirectToAction("Index");
            }
            var cart = await _cartrepo.GetCart(0);
            ViewBag.CartSize = Global.CartSize;
            return View(cart);
        }
    }
}