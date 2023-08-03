using System.ComponentModel.DataAnnotations;

namespace TasksWebApi.Model
{
    public class MyTask
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        public DateTime Date { get; set; }
        public bool Reminder { get; set; }
    }
}
