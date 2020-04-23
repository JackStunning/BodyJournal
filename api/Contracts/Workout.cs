using BodyJournalAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BodyJournalAPI.Contracts
{
  public interface IWorkoutRepository : IRepositoryBase<Workout>
  {
    Task<Workout> GetWorkoutAsync(int id);
    Task<IEnumerable<Workout>> GetWorkoutsAsync(int id);
    void CreateWorkout(Workout model);
    void UpdateWorkout(int id, Workout model);
    void DeleteWorkout(int id);
  }
}