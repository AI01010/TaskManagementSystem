using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public TaskPriority Priority { get; set; }

        [Required]
        public TaskStatus Status { get; set; }

        public string AssignedTo { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public enum TaskPriority
    {
        Low,
        Medium,
        High,
        Urgent
    }

    public enum TaskStatus
    {
        New,
        InProgress,
        Completed,
        Cancelled
    }
}
