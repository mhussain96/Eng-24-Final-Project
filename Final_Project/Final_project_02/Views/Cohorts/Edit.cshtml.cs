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

namespace Final_project_02.Views.Cohorts
{
    public class EditModel : PageModel
    {
        private readonly Final_project_02.Models.Final_project_02Context _context;

        public EditModel(Final_project_02.Models.Final_project_02Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Cohort Cohort { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cohort = await _context.Cohort.FirstOrDefaultAsync(m => m.CohortID == id);

            if (Cohort == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cohort).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CohortExists(Cohort.CohortID))
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

        private bool CohortExists(int id)
        {
            return _context.Cohort.Any(e => e.CohortID == id);
        }
    }
}
