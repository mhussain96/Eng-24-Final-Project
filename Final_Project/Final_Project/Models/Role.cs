using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; } 
        public string RoleName { get; set; }
        public List<User> Users { get; set; }

    }
}
