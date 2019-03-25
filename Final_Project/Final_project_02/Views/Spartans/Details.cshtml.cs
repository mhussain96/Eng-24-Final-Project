using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project_02.Models;
using Final_project_02.Models;

namespace Final_project_02.Views.Spartans
{
    public class DetailsModel : PageModel
    {
        private readonly Final_project_02.Models.Final_project_02Context _context;

        public DetailsModel(Final_project_02.Models.Final_project_02Context context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
