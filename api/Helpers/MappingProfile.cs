using AutoMapper;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Models;

namespace BodyJournalAPI.Helpers
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      #region Biometric
      CreateMap<Biometric, ViewBiometric>();

      CreateMap<CreateBiometric, Biometric>();

      CreateMap<UpdateBiometric, Biometric>();
      #endregion

      #region Exercise
      CreateMap<Exercise, ViewExercise>();

      CreateMap<CreateExercise, Exercise>();

      CreateMap<UpdateExercise, Exercise>();
      #endregion

      #region Workout
      CreateMap<Workout, ViewWorkout>();

      CreateMap<CreateWorkout, Workout>();

      CreateMap<UpdateWorkout, Workout>();
      #endregion

      #region MuscleGroupFatigue
      CreateMap<CreateMuscleGroupFatigue, MuscleGroupFatigue>();

      CreateMap<UpdateMuscleGroupFatigue, MuscleGroupFatigue>();

      CreateMap<MuscleGroupFatigue, ViewMuscleGroupFatigue>();
      #endregion

      #region User
      CreateMap<User, ViewUser>();

      CreateMap<RegisterUser, User>();

      CreateMap<UpdateUser, User>();
      #endregion
    }
  }
}