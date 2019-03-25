using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Project.Data;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    public class SpecialisationController : Controller
    {
        private readonly SpartaIMSContext _context;

        public SpecialisationController(SpartaIMSContext context)
        {
            _context = context;
        }

        // GET: Specialisation
        public async Task<IActionResult> Index()
        {
            return View(await _context.Specialisations.ToListAsync());
        }

        // GET: Specialisation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialisation = await _context.Specialisations
                .FirstOrDefaultAsync(m => m.SpecID == id);
            if (specialisation == null)
            {
                return NotFound();
            }

            return View(specialisation);
        }

        // GET: Specialisation/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Specialisation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpecID,SpecName")] Specialisation specialisation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(specialisation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialisation);
        }

        // GET: Specialisation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialisation = await _context.Specialisations.FindAsync(id);
            if (specialisation == null)
            {
                return NotFound();
            }
            return View(specialisation);
        }

        // POST: Specialisation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpecID,SpecName")] Specialisation specialisation)
        {
            if (id != specialisation.SpecID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(specialisation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecialisationExists(specialisation.SpecID))
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
            return View(specialisation);
        }

        // GET: Specialisation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialisation = await _context.Specialisations
                .FirstOrDefaultAsync(m => m.SpecID == id);
            if (specialisation == null)
            {
                return NotFound();
            }

            return View(specialisation);
        }

        // POST: Specialisation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var specialisation = await _context.Specialisations.FindAsync(id);
            _context.Specialisations.Remove(specialisation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialisationExists(int id)
        {
            return _context.Specialisations.Any(e => e.SpecID == id);
        }
    }
}
