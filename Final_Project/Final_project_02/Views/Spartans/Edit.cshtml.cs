using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Project_02.Models;
using Final_project_02.Models;

namespace Final_project_02.Views.Spartans
{
    public class EditModel : PageModel
    {
        private readonly Final_project_02.Models.Final_project_02Context _context;

        public EditModel(Final_project_02.Models.Final_project_02Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Spartan Spartan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Spartan = await _context.Spartan
                .Include(s => s.Cohort)
                .Include(s => s.Title).FirstOrDefaultAsync(m => m.SpartanID == id);

            if (Spartan == null)
            {
                return NotFound();
            }
           ViewData["CohortID"] = new SelectList(_context.Set<Cohort>(), "CohortID", "CohortID");
           ViewData["TitleID"] = new SelectList(_context.Set<Title>(), "TitleID", "TitleID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Spartan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpartanExists(Spartan.SpartanID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SpartanExists(int id)
        {
            return _context.Spartan.Any(e => e.SpartanID == id);
        }
    }
}
