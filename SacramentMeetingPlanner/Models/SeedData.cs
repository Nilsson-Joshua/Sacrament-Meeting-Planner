using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SacramentMeetingPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingPlannerContext(
                serviceProvider.GetRequiredService<DbContextOptions<SacramentMeetingPlannerContext>>()))
            {
                if (context.Planner.Any())
                {
                    return;   // DB has been seeded
                }

                context.Planner.AddRange(
                     new Planner
                     {
                         Date = DateTime.Parse("2018-4-1"),
                         Presiding = "Bishop Placeholder",
                         Conducting = "John Doe",
                         OpeningHymn = "The Spirit Of God",
                         Invocation = "Jane Doe",
                         SacramentHymn = "As Now We Take The Sacrament",
                         SacramentPrayer = "Aaronic Priesthood",
                         SpeakerOne = "John Doe",
                         TopicOne = "Building A Strong Foundation",
                         SpeakerTwo = "Jane Doe",
                         TopicTwo = "Building An Even Stronger Foundation",
                         SpeakerThree = "John Doe",
                         TopicThree = "Building The Strongest Foundation",
                         ClosingHymn = "How Firm A Foundation",
                         Benediction = "Jane Doe"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}