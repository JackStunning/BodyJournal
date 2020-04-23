using BodyJournalAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BodyJournalAPI.Contracts
{
  public interface IBiometricRepository : IRepositoryBase<Biometric>
  {
    Task<Biometric> GetBiometricAsync(int id);
    Task<IEnumerable<Biometric>> GetBiometricsAsync(int id);
    void CreateBiometric(Biometric model);
    void UpdateBiometric(int id, Biometric model);
    void DeleteBiometric(int id);
  }
}