using Microsoft.EntityFrameworkCore;

namespace ExerciseTrackerAPI.Models.Data
{
    public class ExerciseDbContext: DbContext
    {
        public ExerciseDbContext(DbContextOptions<ExerciseDbContext> options)
           : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }
    }
}
