using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessTracker.Models;

namespace BusinessTracker.Controllers
{
    public class FoodController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FoodController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Food
        public async Task<IActionResult> Index()
        {
            return _context.Categories != null ?
                        View(await _context.Categories.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Categories'  is null.");
        }


        // GET: Food/AddOrEdit
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Food());
            else
                return View(_context.Categories.Find(id));

        }

        // POST: Food/AddOrEdit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("FoodId,Title,Icon,Type")] Food food)
        {
            if (ModelState.IsValid)
            {
                if (food.FoodId == 0)
                    _context.Add(food);
                else
                    _context.Update(food);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(food);
        }


        // POST: Food/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Categories == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Categories'  is null.");
            }
            var food = await _context.Categories.FindAsync(id);
            if (food != null)
            {
                _context.Categories.Remove(food);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
