using System;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;



namespace BodyJournalClient
{
  public class Startup
  {
    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMemoryCache();
      services.AddSession();

      services.AddSession(options =>
      {
        options.IdleTimeout = TimeSpan.FromMinutes(60);
      });

      services.AddControllersWithViews();

      var key = Encoding.ASCII.GetBytes("YourKey-2374-OFFKDI940NG7:56753253-tyuw-5769-0921-kfirox29zoxv");

      services.AddAuthentication(x =>
      {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
      }).AddJwtBearer(token =>
      {
        token.RequireHttpsMetadata = false;
        token.SaveToken = true;
        token.TokenValidationParameters = new TokenValidationParameters
        {
          ValidateIssuerSigningKey = true,
          IssuerSigningKey = new SymmetricSecurityKey(key),
          ValidateIssuer = false,
          ValidateAudience = false
        };
      });
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      app.UseStaticFiles();
      // app.UseCookiePolicy();

      //Addd User session - JRozario
      app.UseSession();

      //Add JWToken to all incoming HTTP Request Header - JRozario
      app.Use(async (context, next) =>
      {
        var JWToken = context.Session.GetString("JWToken");
        if (!string.IsNullOrEmpty(JWToken))
        {
          context.Request.Headers.Add("Authorization", "Bearer " + JWToken);
        }
        await next();
      });
      //Add JWToken Authentication service - JRozario
      app.UseAuthentication();

      // app.UseAuthentication();

      // app.UseDefaultFiles(); // Added for Javascript Functionality
      // app.UseHttpsRedirection();
      // app.UseStaticFiles();

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
