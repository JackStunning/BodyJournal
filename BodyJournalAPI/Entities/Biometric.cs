using System.ComponentModel.DataAnnotations.Schema;

namespace BodyJournalAPI.Entities
{
  [Table("biometrics")]
  public class Biometric
  {
    public int Id { get; set; }

    [ForeignKey(nameof(User))]
    public int UserId { get; set; }
  }
}