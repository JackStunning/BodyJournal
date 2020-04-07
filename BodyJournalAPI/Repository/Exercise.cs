using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Helpers;
using System.Linq;
using System.Collections.Generic;

namespace BodyJournalAPI.Repository
{
  public class ExerciseRepository : RepositoryBase<Exercise>,
  IExerciseRepository
  {
    public ExerciseRepository(BodyJournalContext bodyJournalContext) : base(bodyJournalContext)
    {
    }

    public Exercise GetExercise(int id)
    {
      return FindByCondition(entry => entry.Id == id).SingleOrDefault();
    }

    public IQueryable<Exercise> GetExercises()
    {
      return FindAll();
    }

    public void CreateExercise(Exercise model)
    {
      Create(model);
    }

    public void UpdateExercise(int id, Exercise update)
    {
      var model = GetExercise(id);
      if (model == null)
        throw new System.Exception($"No Exercise");
      Update(update);
    }

    public void DeleteExercise(int id)
    {
      var model = GetExercise(id);
      if (model != null)
        Delete(model);
    }
  }
}