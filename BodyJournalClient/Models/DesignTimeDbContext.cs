using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BodyJournalClient.Helpers;

namespace BodyJournalClient.Models
{
  public class SweetAndSavoryContextFactory : IDesignTimeDbContextFactory<BodyJournalClientContext>
  {

    BodyJournalClientContext IDesignTimeDbContextFactory<BodyJournalClientContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<BodyJournalClientContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new BodyJournalClientContext(builder.Options);
    }
  }

}