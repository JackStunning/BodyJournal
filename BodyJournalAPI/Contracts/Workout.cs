using BodyJournalAPI.Entities;
using System.Linq;
using System.Collections.Generic;

namespace BodyJournalAPI.Contracts
{
  public interface IWorkoutRepository : IRepositoryBase<Workout>
  {
    Workout GetWorkout(int id);
    IQueryable<Workout> GetWorkouts();
    void CreateWorkout(Workout model);
    void UpdateWorkout(int id, Workout model);
    void DeleteWorkout(int id);
  }
}