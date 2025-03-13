using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ecommercestore.Models;
using Microsoft.EntityFrameworkCore;

namespace ecommercestore.Controllers
{
    public class CartController : Controller
    {
        private readonly EcommerceDbContext _context;

        public CartController(EcommerceDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Carts.ToList());
        }


        [HttpPost]
        public IActionResult AddToCart(Cart cart)
        {
            _context.Carts.Add(cart);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Remove")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Remove(int id)
        {
            var cartItem = await _context.Carts.FindAsync(id);
            if (cartItem != null)
            {
                _context.Carts.Remove(cartItem);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Checkout()
        {
            var cartItems = await _context.Carts.ToListAsync();
            var perfumes = await _context.Perfumes.ToListAsync();

            ViewBag.CartItems = cartItems;
            ViewBag.Perfumes = perfumes;

            return View();
        }




        [HttpPost]
        public async Task<IActionResult> EditCartItem(int cartId, int quantity)
        {
            var cartItem = await _context.Carts.FindAsync(cartId);
            if (cartItem != null && quantity > 0)
            {
                cartItem.quantity = quantity;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Checkout");
        }

    }
}
