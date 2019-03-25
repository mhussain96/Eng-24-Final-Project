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
    public class SpartanController : Controller
    {
        private readonly SpartaIMSContext _context;

        public SpartanController(SpartaIMSContext context)
        {
            _context = context;
        }

        // GET: Spartan
        public async Task<IActionResult> Index()
        {
            var spartaIMSContext = _context.Spartans.Include(s => s.Cohort).Include(s => s.Title);
            return View(await spartaIMSContext.ToListAsync());
        }

        // GET: Spartan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spartan = await _context.Spartans
                .Include(s => s.Cohort)
                .Include(s => s.Title)
                .FirstOrDefaultAsync(m => m.SpartanID == id);
            if (spartan == null)
            {
                return NotFound();
            }

            return View(spartan);
        }

        // GET: Spartan/Create
        public IActionResult Create()
        {
            ViewData["CohortID"] = new SelectList(_context.Cohorts, "CohortID", "CohortID");
            ViewData["TitleID"] = new SelectList(_context.Titles, "TitleID", "TitleID");
            return View();
        }

        // POST: Spartan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpartanID,FirstName,LastName,Email,Password,FullName,CohortID,TitleID")] Spartan spartan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spartan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CohortID"] = new SelectList(_context.Cohorts, "CohortID", "CohortID", spartan.CohortID);
            ViewData["TitleID"] = new SelectList(_context.Titles, "TitleID", "TitleID", spartan.TitleID);
            return View(spartan);
        }

        // GET: Spartan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spartan = await _context.Spartans.FindAsync(id);
            if (spartan == null)
            {
                return NotFound();
            }
            ViewData["CohortID"] = new SelectList(_context.Cohorts, "CohortID", "CohortID", spartan.CohortID);
            ViewData["TitleID"] = new SelectList(_context.Titles, "TitleID", "TitleID", spartan.TitleID);
            return View(spartan);
        }

        // POST: Spartan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpartanID,FirstName,LastName,Email,Password,FullName,CohortID,TitleID")] Spartan spartan)
        {
            if (id != spartan.SpartanID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spartan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpartanExists(spartan.SpartanID))
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
            ViewData["CohortID"] = new SelectList(_context.Cohorts, "CohortID", "CohortID", spartan.CohortID);
            ViewData["TitleID"] = new SelectList(_context.Titles, "TitleID", "TitleID", spartan.TitleID);
            return View(spartan);
        }

        // GET: Spartan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spartan = await _context.Spartans
                .Include(s => s.Cohort)
                .Include(s => s.Title)
                .FirstOrDefaultAsync(m => m.SpartanID == id);
            if (spartan == null)
            {
                return NotFound();
            }

            return View(spartan);
        }

        // POST: Spartan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spartan = await _context.Spartans.FindAsync(id);
            _context.Spartans.Remove(spartan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpartanExists(int id)
        {
            return _context.Spartans.Any(e => e.SpartanID == id);
        }
    }
}
