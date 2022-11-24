using AutoMapper;
using ExerciseTrackerAPI.Dto;
using ExerciseTrackerAPI.Models;

namespace ExerciseTrackerAPI.Profiles
{
    public class ExerciseCreateDtoProfile: Profile
    {
        public ExerciseCreateDtoProfile()
        {
            //Source => Destination

            CreateMap<ExerciseCreateDto, Exercise>();

        }
    }
}
