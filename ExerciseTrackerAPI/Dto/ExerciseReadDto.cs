﻿namespace ExerciseTrackerAPI.Dto
{
    public class ExerciseReadDto
    {
        
            public int Id { get; set; }

            public DateTime DateStart { get; set; }

            public DateTime DateEnd { get; set; }

            // public TimeSpan Duration { get; set; }

            public string Comments { get; set; }
        
    }
}
