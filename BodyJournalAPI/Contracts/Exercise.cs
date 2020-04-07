using BodyJournalAPI.Entities;
using System.Linq;

namespace BodyJournalAPI.Contracts
{
  public interface IExerciseRepository : IRepositoryBase<Exercise>
  {
    Exercise GetExercise(int id);
    IQueryable<Exercise> GetExercises();
    void CreateExercise(Exercise model);
    void UpdateExercise(int id, Exercise model);
    void DeleteExercise(int id);
  }
}