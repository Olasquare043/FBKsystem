using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FBKsystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FBKsystem.Data
{
    public class FBKsystemContext : IdentityDbContext<ApplicationUser>
    {
        public FBKsystemContext(DbContextOptions<FBKsystemContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Biodata> Members { get; set; }
        public DbSet<OriginDetails> OriginDetails { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Executive> Executives { get; set; }
    }
}
