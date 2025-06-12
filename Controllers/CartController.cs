using Microsoft.AspNetCore.Mvc;
using Store.Models;
using System.Collections.Generic;
using System.Linq;

namespace Store.Controllers
{
    public class CartController : Controller
    {
        private static List<CartItem> _cart = new List<CartItem>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddToCart(int productId)
        {
            // Тук добави логика с базата
            var product = new Product
            {
                Id = productId,
                Name = "Примерен продукт",
                Price = 10.00M
            };

            var existingItem = _cart.FirstOrDefault(c => c.Product.Id == productId);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                _cart.Add(new CartItem { Product = product, Quantity = 1 });
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            var item = _cart.FirstOrDefault(c => c.Product.Id == productId);
            if (item != null) _cart.Remove(item);
            return RedirectToAction("Index");
        }

        public IActionResult ClearCart()
        {
            _cart.Clear();
            return RedirectToAction("Index");
        }
    }
}
