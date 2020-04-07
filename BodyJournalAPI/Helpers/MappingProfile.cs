using AutoMapper;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Models;
using System.Linq;

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

      #region MuscleGroupFatigue
      CreateMap<CreateMuscleGroupFatigue, MuscleGroupFatigue>();

      CreateMap<UpdateMuscleGroupFatigue, MuscleGroupFatigue>();

      CreateMap<MuscleGroupFatigue, ViewMuscleGroupFatigue>();
      #endregion

      #region MuscleGroupFatigue
      CreateMap<CreateMuscleGroupFatigue, MuscleGroupFatigue>();

      CreateMap<UpdateMuscleGroupFatigue, MuscleGroupFatigue>();

      CreateMap<MuscleGroupFatigue, ViewMuscleGroupFatigue>();
      #endregion
    }
  }
}