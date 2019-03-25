using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class Cohort
    {
        [Key]
        public int CohortID { get; set; }
        public string CohortName { get; set; }
        public int CohortNumber { get; set; }
        public List<User> Users { get; set; }


    }
}
