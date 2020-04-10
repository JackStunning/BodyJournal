using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using BodyJournalClient.Models;

namespace BodyJournalClient.Helpers
{
  public class BodyJournalClientContext : IdentityDbContext<ApplicationUser>
  {
    public BodyJournalClientContext(DbContextOptions options) : base(options)
    {
    }
  }
}