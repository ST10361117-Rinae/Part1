﻿using System.ComponentModel.DataAnnotations;

namespace Part1.Models
{
    public class Users
    {
        [Key]
        public int userID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public string Role { get; set; }
    }
}
