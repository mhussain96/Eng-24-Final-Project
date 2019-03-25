using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

namespace Final_Project.Data
{
    public class SpartaIMSContext:IdentityDbContext
    {
        public SpartaIMSContext(DbContextOptions<SpartaIMSContext> options)
            : base(options)
        {    
        }
        public DbSet<Specialisation> Specialisations { get; set; }
        public DbSet<Cohort> Cohorts { get; set; }
        public DbSet<Spartan> Spartans { get; set; }
        public DbSet<Title> Titles { get; set; }

    }
    
}
