using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final_Project_02.Models;
using Final_project_02.Models;

namespace Final_project_02.Views.Spartans
{
    public class CreateModel : PageModel
    {
        private readonly Final_project_02.Models.Final_project_02Context _context;

        public CreateModel(Final_project_02.Models.Final_project_02Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CohortID"] = new SelectList(_context.Set<Cohort>(), "CohortID", "CohortID");
        ViewData["TitleID"] = new SelectList(_context.Set<Title>(), "TitleID", "TitleID");
            return Page();
        }

        [BindProperty]
        public Spartan Spartan { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Spartan.Add(Spartan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}