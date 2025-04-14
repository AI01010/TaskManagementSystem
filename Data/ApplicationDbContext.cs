using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Seed some initial data
            modelBuilder.Entity<Task>().HasData(
                new Task
                {
                    Id = 1,
                    Title = "Complete Project Plan",
                    Description = "Draft the initial project plan document",
                    DueDate = DateTime.Now.AddDays(7),
                    Priority = TaskPriority.High,
                    Status = TaskStatus.New,
                    AssignedTo = "john.doe@example.com"
                },
                new Task
                {
                    Id = 2,
                    Title = "Review Requirements",
                    Description = "Review and validate project requirements",
                    DueDate = DateTime.Now.AddDays(3),
                    Priority = TaskPriority.Medium,
                    Status = TaskStatus.InProgress,
                    AssignedTo = "jane.smith@example.com"
                }
            );
        }
    }
}
