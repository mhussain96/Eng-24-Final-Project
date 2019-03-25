using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class Title
    {
        [Key]
        public int TitleID { get; set; } 
        public string TitleName { get; set; }
        public List<Spartan> Spartans { get; set; }

    }
}
