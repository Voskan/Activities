using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 moths age",
                    Category = "drinks",
                    City = "Yerevan",
                    Venue = "Pub"
                },
                new Activity
                {
                    Title = "Past activity 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Activity 1 moth age",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre"
                },
                new Activity
                {
                    Title = "Future activity 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Activity 1 moth in future",
                    Category = "culture",
                    City = "Yerevan",
                    Venue = "History Museum"
                },
                new Activity
                {
                    Title = "Future activity 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Activity 2 moth in future",
                    Category = "music",
                    City = "Yerevan",
                    Venue = "02 Arena"
                },
                new Activity
                {
                    Title = "Future activity 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Activity 3 moth in future",
                    Category = "drink",
                    City = "Yerevan",
                    Venue = "Another pub"
                },
                new Activity
                {
                    Title = "Future activity 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Activity 4 moth in future",
                    Category = "music",
                    City = "Yerevan",
                    Venue = "Roundhouse Camden"
                },
                new Activity
                {
                    Title = "Future activity 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Activity 5 moth in future",
                    Category = "travel",
                    City = "Yerevan",
                    Venue = "Central square"
                },
                new Activity
                {
                    Title = "Future activity 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Activity 6 moth in future",
                    Category = "travel",
                    City = "Gyumri",
                    Venue = "Old Gyumri"
                },
                new Activity
                {
                    Title = "Future activity 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Activity 7 moth in future",
                    Category = "film",
                    City = "Yerevan",
                    Venue = "Cinema"
                },
                new Activity
                {
                    Title = "Future activity 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Activity 8 moth in future",
                    Category = "shopping",
                    City = "Paris",
                    Venue = "Shopping center"
                },
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}