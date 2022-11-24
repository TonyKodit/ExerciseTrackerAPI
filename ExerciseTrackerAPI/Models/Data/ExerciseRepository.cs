using Microsoft.AspNetCore.Mvc;

namespace ExerciseTrackerAPI.Models.Data
{
    public class ExerciseRepository: IExerciseRepository
    {

        private readonly ExerciseDbContext _context;
        public ExerciseRepository(ExerciseDbContext context)
        {
            _context = context;
        }

        public void Create(Exercise exercise)
        {
            _context.Add(exercise);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var exercise = _context.Exercises.FirstOrDefault(x => x.Id == id);
            if (exercise != null)
            {
                _context.Exercises.Remove(exercise);
                _context.SaveChanges();
            }
        }

        //GET: api/<ExerciseController>
        [HttpGet]
        public IEnumerable<Exercise> GetAll()
        {
            return _context.Exercises.ToList();
        }

        //GET: api/<ExerciseController>/5
        [HttpGet("{id}")]
        public Exercise GetById(int id)
        {
            return _context.Exercises.FirstOrDefault(e => e.Id == id);
        }


        //PUT api/<ExerciseController>/5
        [HttpPut("{id}")]
        public void Update(Exercise exercise)
        {

        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
