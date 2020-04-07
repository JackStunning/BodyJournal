using BodyJournalAPI.Entities;
using System.Linq;

namespace BodyJournalAPI.Contracts
{
  public interface IMuscleGroupFatigueRepository : IRepositoryBase<MuscleGroupFatigue>
  {
    MuscleGroupFatigue GetMuscleGroupFatigue(int id);
    IQueryable<MuscleGroupFatigue> GetMuscleGroupFatigues();
    void CreateMuscleGroupFatigue(MuscleGroupFatigue model);
    void UpdateMuscleGroupFatigue(int id, MuscleGroupFatigue model);
    void DeleteMuscleGroupFatigue(int id);
  }
}