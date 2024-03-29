﻿// <auto-generated />
using System;
using KonBase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KonBase.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190504182712_3stMigration")]
    partial class _3stMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KonBase.Areas.Admin.Models.ApplicationBank", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("KonBase.Areas.Admin.Models.ApplicationCondominium", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Cep");

                    b.Property<string>("City");

                    b.Property<string>("Cnpj")
                        .IsRequired();

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("Complement");

                    b.Property<string>("CondominiumType");

                    b.Property<DateTime?>("ConstructionDate");

                    b.Property<string>("District");

                    b.Property<string>("FantasyName")
                        .IsRequired();

                    b.Property<string>("Note");

                    b.Property<int>("Number");

                    b.Property<string>("Uf");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Condominium");
                });

            modelBuilder.Entity("KonBase.Areas.Admin.Models.ApplicationCondominiumBank", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountCurrent");

                    b.Property<int>("Agency");

                    b.Property<long?>("BankId");

                    b.Property<long?>("CondominiumId");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("CondominiumId");

                    b.ToTable("CondominiumBank");
                });

            modelBuilder.Entity("KonBase.Areas.Admin.Models.ApplicationCondominiumEmail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CondominiumId");

                    b.Property<string>("Email");

                    b.HasKey("Id");

                    b.HasIndex("CondominiumId");

                    b.ToTable("CondominiumEmail");
                });

            modelBuilder.Entity("KonBase.Areas.Admin.Models.ApplicationCondominiumPhone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CondominiumId");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.HasIndex("CondominiumId");

                    b.ToTable("CondominiumPhone");
                });

            modelBuilder.Entity("KonBase.Models.ApplicationRoleClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("KonBase.Models.ApplicationRoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("KonBase.Models.ApplicationUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("KonBase.Models.ApplicationUserLogins", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("KonBase.Models.ApplicationUserRoles", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("KonBase.Models.ApplicationUsers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("KonBase.Models.ApplicationUserToken", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("KonBase.Areas.Admin.Models.ApplicationCondominium", b =>
                {
                    b.HasOne("KonBase.Models.ApplicationUsers", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("KonBase.Areas.Admin.Models.ApplicationCondominiumBank", b =>
                {
                    b.HasOne("KonBase.Areas.Admin.Models.ApplicationBank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId");

                    b.HasOne("KonBase.Areas.Admin.Models.ApplicationCondominium", "Condominium")
                        .WithMany("Bank")
                        .HasForeignKey("CondominiumId");
                });

            modelBuilder.Entity("KonBase.Areas.Admin.Models.ApplicationCondominiumEmail", b =>
                {
                    b.HasOne("KonBase.Areas.Admin.Models.ApplicationCondominium", "Condominium")
                        .WithMany("Email")
                        .HasForeignKey("CondominiumId");
                });

            modelBuilder.Entity("KonBase.Areas.Admin.Models.ApplicationCondominiumPhone", b =>
                {
                    b.HasOne("KonBase.Areas.Admin.Models.ApplicationCondominium", "Condominium")
                        .WithMany("Phone")
                        .HasForeignKey("CondominiumId");
                });

            modelBuilder.Entity("KonBase.Models.ApplicationRoleClaims", b =>
                {
                    b.HasOne("KonBase.Models.ApplicationRoles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KonBase.Models.ApplicationUserClaims", b =>
                {
                    b.HasOne("KonBase.Models.ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KonBase.Models.ApplicationUserLogins", b =>
                {
                    b.HasOne("KonBase.Models.ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KonBase.Models.ApplicationUserRoles", b =>
                {
                    b.HasOne("KonBase.Models.ApplicationRoles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KonBase.Models.ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KonBase.Models.ApplicationUserToken", b =>
                {
                    b.HasOne("KonBase.Models.ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
