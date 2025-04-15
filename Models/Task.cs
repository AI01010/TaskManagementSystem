using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Models
{
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

    public class Task
    {
        public int Id { get; set; }

        public required string Title { get; set; } // Use 'required' modifier
        public required string Description { get; set; } // Use 'required' modifier
        public DateTime DueDate { get; set; }

        public TaskPriority Priority { get; set; }
        public TaskStatus Status { get; set; }

        public required string AssignedTo { get; set; } // Use 'required' modifier

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
