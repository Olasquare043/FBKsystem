using System;
using FBKsystem.Areas.Identity.Data;
using FBKsystem.Data;
using FBKsystem.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FBKsystem.Areas.Identity.IdentityHostingStartup))]
namespace FBKsystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup 
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FBKsystemContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FBKsystemContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<FBKsystemContext>();
                services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUserClaimsPrincipalFactory>();
            });
        }
    }
}