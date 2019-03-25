using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace Final_Project.Models
{
    public class User
    {
        [Key]
        public int UserID {get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
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
        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}
