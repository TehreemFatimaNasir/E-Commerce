using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ecommercestore.Models;

namespace ecommercestore.Controllers
{
    public class PerfumeController : Controller
    {
        private readonly EcommerceDbContext _context;

        public PerfumeController(EcommerceDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Perfumes.ToList());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfume = await _context.Perfumes.FindAsync(id);
            if (perfume == null)
            {
                return NotFound();
            }

            return View(perfume);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Perfume perfume)
        {
            if (!ModelState.IsValid)
            {
                return View(perfume);
            }

            _context.Perfumes.Add(perfume);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfume = await _context.Perfumes.FindAsync(id);
            if (perfume == null)
            {
                return NotFound();
            }

            return View(perfume);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Perfume perfume)
        {
            if (!ModelState.IsValid)
            {
                return View(perfume);
            }

            _context.Perfumes.Update(perfume);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfume = await _context.Perfumes.FindAsync(id);
            if (perfume == null)
            {
                return NotFound();
            }

            _context.Perfumes.Remove(perfume);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
