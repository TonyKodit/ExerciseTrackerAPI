using AutoMapper;
using ExerciseTrackerAPI.Dto;
using ExerciseTrackerAPI.Models;
using ExerciseTrackerAPI.Models.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IMapper _mapper;

        public ExerciseController(IExerciseRepository exerciseRepository, IMapper mapper)
        {
            _exerciseRepository = exerciseRepository;
            _mapper = mapper;
        }


        //GET: api/<ExerciseController>
        [HttpGet]
        public ActionResult<IEnumerable<ExerciseReadDto>> Get()
        {
            var excercises = _exerciseRepository.GetAll();

            var exerciseDto = _mapper.Map<IEnumerable<ExerciseReadDto>>(excercises);
            if (excercises == null)
            {
                return NotFound();

            }

            return Ok(exerciseDto);

        }

        //GET: api/<ExerciseController>/5
        [HttpGet("{id}", Name = "GetExerciseById")]
        public ActionResult<ExerciseReadDto> GetExerciseById(int id)
        {
            var exercises = _exerciseRepository.GetById(id);
            if (exercises == null)
            {
                return NotFound();
            }

            return Ok(exercises);

        }


        //POST api/<ExerciseController>/5
        //[HttpPost]
        //public IActionResult Post([FromBody] Exercise exercise)
        //{
        //    if (exercise == null)
        //    {
        //        return BadRequest();
        //    }

        //    _exerciseRepository.Post(exercise);

        //    return Ok(exercise);
        //} 


        [HttpPost]
        public ActionResult<ExerciseReadDto> CreateExercise(
            ExerciseCreateDto exerciseCreateDto)
        {
            //Mapping to persist to Data
            var exerciseModel = _mapper.Map<Exercise>(exerciseCreateDto);

            _exerciseRepository.Create(exerciseModel);
            _exerciseRepository.SaveChanges();

            //Mapp from Exercise to Its Dto
            var exerciseReadDto = _mapper.Map<ExerciseReadDto>(exerciseModel);

            return CreatedAtRoute(nameof(GetExerciseById),
                new { Id = exerciseReadDto.Id }, exerciseReadDto);
        }
    }
}
