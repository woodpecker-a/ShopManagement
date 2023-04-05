using Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Infrastructure.Seeds
{
    public static class MasterDataSeeding
    {
        public static void SeedUser(UserManager<ApplicationUser> manager)
        {
            var user = new ApplicationUser
            {
                UserName = "super@admin.com",
                Email = "super@admin.com"
            };

            var result = manager.CreateAsync(user, "123456789").Result;

            if(result.Succeeded)
            {
                manager.AddToRoleAsync(user, "Admin").Wait();
                manager.AddClaimAsync(user, new Claim("CRUDProduct", "true")).Wait();
            }
        }
    }
}
