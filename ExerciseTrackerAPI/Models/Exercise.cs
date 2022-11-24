using System.ComponentModel.DataAnnotations;

namespace ExerciseTrackerAPI.Models
{
    public class Exercise
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }


        public TimeSpan Duration { get; set; }

        public string Comments { get; set; }

    }
}
