using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using BodyJournalAPI.Repository;
using BodyJournalAPI.Helpers;
using BodyJournalAPI.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

namespace BodyJournalAPI
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
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {

      services.ConfigureMySqlContext(Configuration);
      services.ConfigureRepositoryWrapper();
      services.AddAutoMapper(typeof(Startup));

      services.AddControllers();
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      app.UseStaticFiles();

      app.UseCors("CorsPolicy");

      app.UseRouting();

      //   app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
