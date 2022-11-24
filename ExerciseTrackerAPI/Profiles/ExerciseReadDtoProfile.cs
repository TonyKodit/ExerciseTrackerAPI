using AutoMapper;
using ExerciseTrackerAPI.Dto;
using ExerciseTrackerAPI.Models;

namespace ExerciseTrackerAPI.Profiles
{
    public class ExerciseReadDtoProfile : Profile
    {
        public ExerciseReadDtoProfile()
        {
            //Source -> Destination
            CreateMap<Exercise, ExerciseReadDto>();
        }
    }
}
