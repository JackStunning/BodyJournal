using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Helpers;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BodyJournalAPI.Repository
{
  public class MuscleGroupFatigueRepository : RepositoryBase<MuscleGroupFatigue>,
  IMuscleGroupFatigueRepository
  {
    public MuscleGroupFatigueRepository(BodyJournalContext bodyJournalContext) : base(bodyJournalContext)
    {
    }

    public async Task<MuscleGroupFatigue> GetMuscleGroupFatigueAsync(int id)
    {
      return await FindByCondition(x => x.Id == id).SingleOrDefaultAsync();
    }

    public async Task<IEnumerable<MuscleGroupFatigue>> GetMuscleGroupFatiguesAsync(int id)
    {
      return await FindByCondition(x => x.UserId == id).ToListAsync();
    }

    public void CreateMuscleGroupFatigue(MuscleGroupFatigue model)
    {
      Create(model);
    }

    public void UpdateMuscleGroupFatigue(int id, MuscleGroupFatigue update)
    {
      var model = GetMuscleGroupFatigueAsync(id);
      if (model == null)
        throw new System.Exception($"No MuscleGroupFatigue");
      Update(update);
    }

    public async void DeleteMuscleGroupFatigue(int id)
    {
      MuscleGroupFatigue model = await GetMuscleGroupFatigueAsync(id);
      if (model != null)
        Delete(model);
    }
  }
}