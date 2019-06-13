using System;
using System.Collections.Generic;
using System.Text;
using KonBase.Areas.Admin.Models;
using KonBase.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KonBase.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers, ApplicationRoles, Guid, ApplicationUserClaims, ApplicationUserRoles,
    ApplicationUserLogins, ApplicationRoleClaims, ApplicationUserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApplicationCondominium> Condominium { get; set; }
        public virtual DbSet<ApplicationBank> Bank { get; set; }
        public virtual DbSet<ApplicationCondominiumBank> CondominiumBank { get; set; }
        public virtual DbSet<ApplicationCondominiumEmail> CondominiumEmail { get; set; }
        public virtual DbSet<ApplicationCondominiumPhone> CondominiumPhone { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUsers>(entity =>
            {
                entity.ToTable(name: "User");
            });

            builder.Entity<ApplicationRoles>(entity =>
            {
                entity.ToTable(name: "Role");
            });

            builder.Entity<ApplicationRoleClaims>(entity =>
            {
                entity.ToTable(name: "RoleClaim");
            });

            builder.Entity<ApplicationUserRoles>(entity =>
            {
                entity.ToTable(name: "UserRole");
            });

            builder.Entity<ApplicationUserLogins>(entity =>
            {
                entity.ToTable(name: "UserLogin");
            });

            builder.Entity<ApplicationUserClaims>(entity =>
            {
                entity.ToTable(name: "UserClaim");
            });

            builder.Entity<ApplicationUserToken>(entity =>
            {
                entity.ToTable(name: "UserToken");
            });
        }    
    }
}
