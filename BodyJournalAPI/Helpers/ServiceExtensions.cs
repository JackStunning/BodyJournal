using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BodyJournalAPI.Repository;
using BodyJournalAPI.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace BodyJournalAPI.Helpers
{
  public static class ServiceExtensions
  {
    public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
    {
      var connectionString = config["ConnectionStrings:DefaultConnection"];
      services.AddDbContext<BodyJournalContext>(o => o.UseMySql(connectionString));
    }
    public static void ConfigureRepositoryWrapper(this IServiceCollection services)
    {
      services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
    }
  }
}
