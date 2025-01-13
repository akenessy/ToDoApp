using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class Task
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Название обязательно для заполнения")]
        [StringLength(100, ErrorMessage = "Название не должно превышать 100 символов")]
        public required string Title { get; set; }

        [StringLength(500, ErrorMessage = "Описание не должно превышать 500 символов")]
        public required string Description { get; set; }

        public bool IsCompleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
