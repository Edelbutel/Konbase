using System;
using System.Collections.Generic;
using System.Text;
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


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUsers>(entity =>
            {
                entity.ToTable(name: "Users");
            });

            builder.Entity<ApplicationRoles>(entity =>
            {
                entity.ToTable(name: "Roles");
            });

            builder.Entity<ApplicationRoleClaims>(entity =>
            {
                entity.ToTable(name: "RoleClaims");
            });

            builder.Entity<ApplicationUserRoles>(entity =>
            {
                entity.ToTable(name: "UserRoles");
            });

            builder.Entity<ApplicationUserLogins>(entity =>
            {
                entity.ToTable(name: "UserLogins");
            });

            builder.Entity<ApplicationUserClaims>(entity =>
            {
                entity.ToTable(name: "UserClaims");
            });

            builder.Entity<ApplicationUserToken>(entity =>
            {
                entity.ToTable(name: "UserToken");
            });
        }    
    }
}
