using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using BodyJournalClient.Models;
using BodyJournalClient.Helpers;
using System;

namespace BodyJournalClient
{
  public class Startup
  {
    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllersWithViews();

      services.AddEntityFrameworkMySql()
     .AddDbContext<BodyJournalClientContext>(options => options
       .UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));

      services.AddIdentity<ApplicationUser, IdentityRole>()
        .AddEntityFrameworkStores<BodyJournalClientContext>();

      // services.AddAuthorization(options =>
      // {
      //   options.AddPolicy("Admin", policy => policy.RequireRole("Admin"));
      // });

      services.Configure<IdentityOptions>(options =>
      {
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 0;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredUniqueChars = 0;
      });
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {

      app.UseAuthentication();

      app.UseDefaultFiles(); // Added for Javascript Functionality
      // app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      // app.UseAuthorization();
      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");
      });
    }
  }
}
