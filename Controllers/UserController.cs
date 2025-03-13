using ecommercestore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ecommercestore.Controllers
{
    public class UserController : Controller
    {
        private readonly EcommerceDbContext _context;

        public UserController(EcommerceDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToAction("Login");
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.email == email && u.password == password);

            if (user == null)
            {
                ViewBag.Error = "Invalid email or password!";
                return View("Login");
            }

            return RedirectToAction("AllPerfumes", "Cart");
        }

       
    }
}

