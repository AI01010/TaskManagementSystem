using Microsoft.EntityFrameworkCore;
using TaskModel = TaskManagementSystem.Models.Task; // Alias for TaskManagementSystem.Models.Task
using TaskManagementSystem.Models; // Add this to reference enums

namespace TaskManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; } // Use the alias here

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Seed some initial data
            modelBuilder.Entity<TaskModel>().HasData( // Use the alias here
                new TaskModel
                {
                    Id = 1,
                    Title = "Complete Project Plan",
                    Description = "Draft the initial project plan document",
                    DueDate = DateTime.Now.AddDays(7),
                    Priority = TaskPriority.High, // Reference TaskPriority enum
                    Status = TaskManagementSystem.Models.TaskStatus.New, // Reference TaskStatus enum
                    AssignedTo = "john.doe@example.com"
                },
                new TaskModel
                {
                    Id = 2,
                    Title = "Review Requirements",
                    Description = "Review and validate project requirements",
                    DueDate = DateTime.Now.AddDays(3),
                    Priority = TaskPriority.Medium, // Reference TaskPriority enum
                    Status = TaskManagementSystem.Models.TaskStatus.InProgress, // Reference TaskStatus enum
                    AssignedTo = "jane.smith@example.com"
                }
            );
        }
    }
}
