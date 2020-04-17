using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Helpers;
using System.Linq;

namespace BodyJournalAPI.Repository
{
  public class BiometricRepository : RepositoryBase<Biometric>,
  IBiometricRepository
  {
    public BiometricRepository(BodyJournalContext bodyJournalContext) : base(bodyJournalContext)
    {
    }

    public Biometric GetBiometric(int id)
    {
      return FindByCondition(entry => entry.Id == id).SingleOrDefault();
    }

    public IQueryable<Biometric> GetBiometrics()
    {
      return FindAll();
    }

    public void CreateBiometric(Biometric model)
    {
      Create(model);
    }

    public void UpdateBiometric(int id, Biometric update)
    {
      var model = GetBiometric(id);
      if (model == null)
        throw new System.Exception($"No Biometric");
      Update(update);
    }

    public void DeleteBiometric(int id)
    {
      var model = GetBiometric(id);
      if (model != null)
        Delete(model);
    }
  }
}