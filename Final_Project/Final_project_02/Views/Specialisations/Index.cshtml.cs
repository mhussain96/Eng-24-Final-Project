using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project_02.Models;
using Final_project_02.Models;

namespace Final_project_02.Views.Specialisations
{
    public class IndexModel : PageModel
    {
        private readonly Final_project_02.Models.Final_project_02Context _context;

        public IndexModel(Final_project_02.Models.Final_project_02Context context)
        {
            _context = context;
        }

        public IList<Specialisation> Specialisation { get;set; }

        public async Task OnGetAsync()
        {
            Specialisation = await _context.Specialisation.ToListAsync();
        }
    }
}
