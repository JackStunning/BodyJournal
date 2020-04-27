using BodyJournalAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BodyJournalAPI.Contracts
{
  public interface IExerciseRepository : IRepositoryBase<Exercise>
  {
    Task<Exercise> GetExerciseAsync(int id);
    Task<IEnumerable<Exercise>> GetExercisesAsync(int id);
    void CreateExercise(Exercise model);
    void UpdateExercise(int id, Exercise model);
    void DeleteExercise(int id);
  }
}