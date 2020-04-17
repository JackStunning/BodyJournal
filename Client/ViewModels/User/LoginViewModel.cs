using System.ComponentModel.DataAnnotations;

namespace BodyJournalClient.ViewModels.User
{
  public class LoginViewModel
  {
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
  }
}