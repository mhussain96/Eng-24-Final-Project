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

namespace Final_project_02.Views.Specialisations
{
    public class EditModel : PageModel
    {
        private readonly Final_project_02.Models.Final_project_02Context _context;

        public EditModel(Final_project_02.Models.Final_project_02Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Specialisation Specialisation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Specialisation = await _context.Specialisation.FirstOrDefaultAsync(m => m.SpecID == id);

            if (Specialisation == null)
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

            _context.Attach(Specialisation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecialisationExists(Specialisation.SpecID))
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

        private bool SpecialisationExists(int id)
        {
            return _context.Specialisation.Any(e => e.SpecID == id);
        }
    }
}
