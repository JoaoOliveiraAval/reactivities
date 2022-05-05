using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence.Seed
{
    public static class UserSeedingService
    {
        public static async Task SeedUsers(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser { DisplayName = "Bob", UserName ="bob", Email = "bob@test.com"},
                    new AppUser { DisplayName = "James", UserName ="james", Email = "james@test.com"},
                    new AppUser { DisplayName = "Tom", UserName ="tom", Email = "tom@test.com"}
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }
        }
    }
}
