using Microsoft.EntityFrameworkCore;

namespace MiniProject.Models
{
    public class GoalContext : DbContext
    {
        public GoalContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Goal> Goals { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Story> Stories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedGoals(modelBuilder);
            SeedSteps(modelBuilder);
            SeedStories(modelBuilder);
        }

        private void SeedGoals(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Goal>().HasData(new Goal
            {
                GoalId = 1,
                GoalName = "Find Product"
            }, new Goal
            {
                GoalId = 2,
                GoalName = "Select Product"
            }, new Goal
            {
                GoalId = 3,
                GoalName = "Buy Product"
            });
        }

        private void SeedSteps(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Step>().HasData(new Step
            {
                StepId = 1,
                StepName = "visit website",
                GoalId = 1
            }, new Step
            {
                StepId = 2,
                StepName = "search product",
                GoalId = 1
            }, new Step
            {
                StepId = 3,
                StepName = "order search results",
                GoalId = 1
            }, new Step
            {
                StepId = 4,
                StepName = "open product detail",
                GoalId = 2
            }, new Step
            {
                StepId = 5,
                StepName = "compare product",
                GoalId = 2
            }, new Step
            {
                StepId = 6,
                StepName = "sign up",
                GoalId = 3
            }, new Step
            {
                StepId = 7,
                StepName = "add to basket",
                GoalId = 3
            }, new Step
            {
                StepId = 8,
                StepName = "place order",
                GoalId = 3
            }, new Step
            {
                StepId = 9,
                StepName = "make payment",
                GoalId = 3
            });
        }

        private void SeedStories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Story>().HasData(new Story
            {
                StoryId = 1,
                StoryName = "Static website from template",
                ReleaseId = 1,
                StepId = 1
            }, new Story
            {
                StoryId = 2,
                StoryName = "open standard search panel",
                ReleaseId = 1,
                StepId = 2
            }, new Story
            {
                StoryId = 3,
                StoryName = "search by name",
                ReleaseId = 1,
                StepId = 2
            }, new Story
            {
                StoryId = 4,
                StoryName = "open detailed search panel",
                ReleaseId = 2,
                StepId = 2
            }, new Story
            {
                StoryId = 5,
                StoryName = "search by category",
                ReleaseId = 2,
                StepId = 2
            }, new Story
            {
                StoryId = 6,
                StoryName = "search by brand",
                ReleaseId = 2,
                StepId = 2
            }, new Story
            {
                StoryId = 7,
                StoryName = "order by price",
                ReleaseId = 2,
                StepId = 3
            }, new Story
            {
                StoryId = 8,
                StoryName = "standard product data sheet",
                ReleaseId = 1,
                StepId = 4
            }, new Story
            {
                StoryId = 9,
                StoryName = "sign up with regular account",
                ReleaseId = 1,
                StepId = 6
            }, new Story
            {
                StoryId = 10,
                StoryName = "add to basket",
                ReleaseId = 1,
                StepId = 7
            }, new Story
            {
                StoryId = 11,
                StoryName = "add shipping address",
                ReleaseId = 1,
                StepId = 8
            }, new Story
            {
                StoryId = 12,
                StoryName = "choose shipping method",
                ReleaseId = 1,
                StepId = 8
            }, new Story
            {
                StoryId = 13,
                StoryName = "pay by bank transaction",
                ReleaseId = 1,
                StepId = 9
            }, new Story
            {
                StoryId = 14,
                StoryName = "pay by bank card",
                ReleaseId = 2,
                StepId = 9
            }, new Story
            {
                StoryId = 15,
                StoryName = "pay by PayPal",
                ReleaseId = 2,
                StepId = 9
            });
        }
    }
}