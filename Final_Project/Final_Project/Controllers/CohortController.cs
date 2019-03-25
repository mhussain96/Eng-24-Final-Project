﻿using System;
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
    public class CohortController : Controller
    {
        private readonly SpartaIMSContext _context;

        public CohortController(SpartaIMSContext context)
        {
            _context = context;
        }

        // GET: Cohort
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cohorts.ToListAsync());
        }

        // GET: Cohort/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cohort = await _context.Cohorts
                .FirstOrDefaultAsync(m => m.CohortID == id);
            if (cohort == null)
            {
                return NotFound();
            }

            return View(cohort);
        }

        // GET: Cohort/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cohort/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CohortID,CohortName,CohortNumber")] Cohort cohort)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cohort);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cohort);
        }

        // GET: Cohort/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cohort = await _context.Cohorts.FindAsync(id);
            if (cohort == null)
            {
                return NotFound();
            }
            return View(cohort);
        }

        // POST: Cohort/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CohortID,CohortName,CohortNumber")] Cohort cohort)
        {
            if (id != cohort.CohortID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cohort);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CohortExists(cohort.CohortID))
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
            return View(cohort);
        }

        // GET: Cohort/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cohort = await _context.Cohorts
                .FirstOrDefaultAsync(m => m.CohortID == id);
            if (cohort == null)
            {
                return NotFound();
            }

            return View(cohort);
        }

        // POST: Cohort/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cohort = await _context.Cohorts.FindAsync(id);
            _context.Cohorts.Remove(cohort);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CohortExists(int id)
        {
            return _context.Cohorts.Any(e => e.CohortID == id);
        }
    }
}
