﻿using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class UserModel
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
