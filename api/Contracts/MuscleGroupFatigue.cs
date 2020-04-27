using BodyJournalAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BodyJournalAPI.Contracts
{
  public interface IMuscleGroupFatigueRepository : IRepositoryBase<MuscleGroupFatigue>
  {
    Task<MuscleGroupFatigue> GetMuscleGroupFatigueAsync(int id);
    Task<IEnumerable<MuscleGroupFatigue>> GetMuscleGroupFatiguesAsync(int id);
    void CreateMuscleGroupFatigue(MuscleGroupFatigue model);
    void UpdateMuscleGroupFatigue(int id, MuscleGroupFatigue model);
    void DeleteMuscleGroupFatigue(int id);
  }
}