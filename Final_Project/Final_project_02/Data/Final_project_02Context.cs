using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_Project_02.Models;

namespace Final_project_02.Models
{
    public class Final_project_02Context : DbContext
    {
        public Final_project_02Context (DbContextOptions<Final_project_02Context> options)
            : base(options)
        {
        }

        public DbSet<Spartan> Spartan { get; set; }

        public DbSet<Title> Title { get; set; }

        public DbSet<Cohort> Cohort { get; set; }

        public DbSet<Specialisation> Specialisation { get; set; }
    }
}
