using System.Threading.Tasks;
using EZBuy.Models;
using EZBuy.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EZBuy.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _prodrepo;
        private readonly ApplicationDbContext _db;
        private readonly CartRepository _cartrepo;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
            _prodrepo = new ProductRepository(_db);
            _cartrepo = new CartRepository(_db);
        }

        // GET: /<controller>/
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var product = await _prodrepo.GetAllProducts();
            ViewBag.CartSize = Global.CartSize;
            return View(product);
        }

        public Task<Product> GetProductById(int id)
        {
            ViewBag.CartSize = Global.CartSize;
            return _prodrepo.GetProductById(id);
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(string descr)
        {
            //Sample code to demonstrate ViewBag and TempData
            Global.SearchMode = true;
            Global.SearchQuery = descr;
            ViewBag.Descr = descr;
            TempData["Descr"] = descr;
            var product = await _prodrepo.SearchProduct();
            ViewBag.CartSize = Global.CartSize;
            return View("Index", product);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCart(string sku, string itemDescr, int qty, double price)
        {
            if (!string.IsNullOrEmpty(sku))
            {
                await _cartrepo.UpsertCart(sku, itemDescr, qty, price);
                ViewBag.CartSize = Global.CartSize;
                if (Global.SearchMode == true)
                {
                    var product = await _prodrepo.SearchProduct();
                    return View("Index", product);
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
