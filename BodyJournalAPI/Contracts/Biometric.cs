using BodyJournalAPI.Entities;
using System.Linq;

namespace BodyJournalAPI.Contracts
{
  public interface IBiometricRepository : IRepositoryBase<Biometric>
  {
    Biometric GetBiometric(int id);
    IQueryable<Biometric> GetBiometrics();
    void CreateBiometric(Biometric model);
    void UpdateBiometric(int id, Biometric model);
    void DeleteBiometric(int id);
  }
}