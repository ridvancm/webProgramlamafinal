using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webProgramlamafinal.Models;

namespace webProgramlamafinal.Controllers
{
    public class RecipiesController : Controller
    {
        private readonly AppDbContext _context;

        public RecipiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Recipies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Recipies.ToListAsync());
        }

        // GET: Recipies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipie = await _context.Recipies
                .FirstOrDefaultAsync(m => m.RecipeId == id);
            if (recipie == null)
            {
                return NotFound();
            }

            return View(recipie);
        }

        // GET: Recipies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recipies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RecipeId,Title,Description,Ingredients,Instructions,CreatedAt")] Recipie recipie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recipie);
        }

        // GET: Recipies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipie = await _context.Recipies.FindAsync(id);
            if (recipie == null)
            {
                return NotFound();
            }
            return View(recipie);
        }

        // POST: Recipies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RecipeId,Title,Description,Ingredients,Instructions,CreatedAt")] Recipie recipie)
        {
            if (id != recipie.RecipeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipieExists(recipie.RecipeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(recipie);
        }

        // GET: Recipies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipie = await _context.Recipies
                .FirstOrDefaultAsync(m => m.RecipeId == id);
            if (recipie == null)
            {
                return NotFound();
            }

            return View(recipie);
        }

        // POST: Recipies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipie = await _context.Recipies.FindAsync(id);
            if (recipie != null)
            {
                _context.Recipies.Remove(recipie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipieExists(int id)
        {
            return _context.Recipies.Any(e => e.RecipeId == id);
        }
    }
}
