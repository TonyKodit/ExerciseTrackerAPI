namespace ExerciseTrackerAPI.Models.Data
{
    public interface IExerciseRepository
    {
        IEnumerable<Exercise> GetAll();

        Exercise GetById(int id);

        void Create(Exercise exercise);

        void Update(Exercise exercise);

        void DeleteById(int id);

        bool SaveChanges();
    }
}
