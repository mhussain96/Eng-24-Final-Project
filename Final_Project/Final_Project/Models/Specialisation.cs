using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class Specialisation
    {
        [Key]
        public int SpecID { get; set; }
        public string SpecName { get; set; }
        //Foreign keys
        public List<Cohort> Cohorts { get; set; }
    }
}
