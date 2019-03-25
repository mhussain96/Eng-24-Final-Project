using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final_Project_02.Models;
using Final_project_02.Models;

namespace Final_project_02.Views.Titles
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
            return Page();
        }

        [BindProperty]
        public Title Title { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Title.Add(Title);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}