using System.ComponentModel.DataAnnotations;

namespace ExerciseTrackerAPI.Dto
{
    public class ExerciseCreateDto
    {
        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }


        //public TimeSpan Duration { get; set; } 

        public string Comments { get; set; }
    }
}
