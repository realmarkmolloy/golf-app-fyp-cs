﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GolfShotApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        public string Username { get; set; } 
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public float Handicap { get; set; }
        public string Role { get; set; } = "Customer";
    }
}
