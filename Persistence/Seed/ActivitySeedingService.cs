using Domain;
using Microsoft.EntityFrameworkCore;
using ValueObjects;

namespace Persistence.Seed
{
    public static class ActivitySeedingService
    {
        public static void SeedActivities(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>().HasData(
                new Activity((Title)"Past Activity 1", DateTime.Now.AddMonths(-2), "Activity 2 months ago", "drinks",
                             "London", "Pub", false, new Guid("259c3963-6c21-4967-8199-155e999389af")),
                new Activity((Title)"Past Activity 2", DateTime.Now.AddMonths(-1), "Activity 1 month ago", "culture",
                             "Paris", "Louvre", false, new Guid("b21a21e5-ef21-43e6-a14e-e1f43f7499c2")),
                new Activity((Title)"Future Activity 1", DateTime.Now.AddMonths(1), "Activity 1 month in future", "culture",
                             "London", "Natural History Museum", false, new Guid("8425c307-a467-4f6e-bcc7-e475320a3a68")),
                new Activity((Title)"Future Activity 2", DateTime.Now.AddMonths(2), "Activity 2 months in future", "music",
                             "London", "O2 Arena", false, new Guid("aa5cd732-3894-4a8b-be9b-ad1cbc39aaa0")),
                new Activity((Title)"Future Activity 3", DateTime.Now.AddMonths(3), "Activity 3 months in future", "drinks",
                             "London", "Another pub", false, new Guid("922713bb-c55f-460c-b0cc-c1d90f8ba97c")),
                new Activity((Title)"Future Activity 4", DateTime.Now.AddMonths(4), "Activity 4 months in future", "drinks",
                             "London", "Yet another pub", false, new Guid("3f8f766e-07d1-4d85-8c8b-5165eea19ce6")),
                new Activity((Title)"Future Activity 5", DateTime.Now.AddMonths(5), "Activity 5 months in future", "drinks"
                             , "London", "Just another pub", false, new Guid("6143b941-e70e-44ea-8b32-baa4ff78a6fe")),
                new Activity((Title)"Future Activity 6", DateTime.Now.AddMonths(6), "Activity 6 months in future", "music",
                             "London", "Roundhouse Camden", false, new Guid("2d55a151-a094-41b0-8bf1-92dcc3a729c3")),
                new Activity((Title)"Future Activity 7", DateTime.Now.AddMonths(7), "Activity 2 months ago", "travel"
                             , "London", "Somewhere on the Thames", false, new Guid("1fa1f37e-4807-4a5e-948b-4fd1aac235ac")),
                new Activity((Title)"Future Activity 8", DateTime.Now.AddMonths(8), "Activity 8 months in future", "film",
                             "London", "Cinema", false, new Guid("a5c4885c-4116-4583-87db-7a5c641510af"))
                );
        }
    }
}
