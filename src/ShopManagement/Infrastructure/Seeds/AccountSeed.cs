using Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Seeds
{
    internal class AccountSeed
    {
        PasswordHasher<ApplicationUser> password = new PasswordHasher<ApplicationUser>();

        internal ApplicationUser[] SuperUser
        {
            get
            {
                return new ApplicationUser[]
                {
                    new ApplicationUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "Admin",
                        Email = "super@admin.com",
                        LockoutEnabled = false,
                        PhoneNumber = "01521111111",
                        PasswordHash = password.HashPassword(SuperUser[0], "admin123")
                    }
                };
            }
        }
    }
}
