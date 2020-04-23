using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BodyJournalAPI.Repository
{
  public class BiometricRepository : RepositoryBase<Biometric>,
  IBiometricRepository
  {
    public BiometricRepository(BodyJournalContext bodyJournalContext) : base(bodyJournalContext)
    {
    }

    public async Task<Biometric> GetBiometricAsync(int id)
    {
      return await FindByCondition(entry => entry.Id == id).SingleOrDefaultAsync();
    }

    public async Task<IEnumerable<Biometric>> GetBiometricsAsync(int id)
    {
      return await FindByCondition(entry => entry.UserId == id).ToListAsync();
    }

    public void CreateBiometric(Biometric model)
    {
      Create(model);
    }

    public void UpdateBiometric(int id, Biometric update)
    {
      var model = GetBiometricAsync(id);
      if (model == null)
        throw new System.Exception($"No Biometric");
      Update(update);
    }

    public async void DeleteBiometric(int id)
    {
      Biometric model = await GetBiometricAsync(id);
      if (model != null)
        Delete(model);
    }
  }
}