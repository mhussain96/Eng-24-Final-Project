using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class Spartan
    {
        [Key]
        public int SpartanID {get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set { }
        }
        //Foreign Keys
        public int CohortID { get; set; }
        public Cohort Cohort { get; set; }
        public int TitleID { get; set; }
        public Title Title { get; set; }
    }
}
