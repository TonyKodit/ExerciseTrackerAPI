namespace ExerciseTrackerAPI.Models.Data
{
    public class InMemoryRepository : IExerciseRepository
    {
        private static List<Exercise> exercises = new List<Exercise>()
        {
            new Exercise(){Id = 1, DateStart = new DateTime(2022,11,17, 08,00,00,DateTimeKind.Local) , DateEnd = new DateTime(2022,11,17, 17,00,00,DateTimeKind.Local) , Duration = new TimeSpan(8,00,00) , Comments = "Excellent" },
            new Exercise(){Id = 2, DateStart = new DateTime(2022,11,17, 08,05,00,DateTimeKind.Local) , DateEnd = new DateTime(2022,11,17, 17,05,00,DateTimeKind.Local) , Duration = new TimeSpan(8,05,00) , Comments = "Good"},
            new Exercise(){Id = 3, DateStart =new DateTime(2022,11,17, 08,10,00,DateTimeKind.Local) , DateEnd = new DateTime(2022,11,17, 17,10,00,DateTimeKind.Local) , Duration = new TimeSpan(8,10,00) , Comments = "Fair" }

        };

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exercise> GetAll()
        {
            return exercises;
        }

        public Exercise GetById(int id)
        {
            return exercises[id];
        }

        public void Create(Exercise exercise)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Exercise exercise)
        {
            throw new NotImplementedException();
        }
    }
}
