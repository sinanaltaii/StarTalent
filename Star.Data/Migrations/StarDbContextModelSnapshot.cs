﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Star.Data.DataContext;

namespace Star.Data.Migrations
{
    [DbContext(typeof(StarDbContext))]
    partial class StarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Star.Data.Models.AuthGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("AuthGroup");
                });

            modelBuilder.Entity("Star.Data.Models.AuthGroupPermissions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId");

                    b.Property<int>("PermissionId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("PermissionId");

                    b.ToTable("AuthGroupPermissions");
                });

            modelBuilder.Entity("Star.Data.Models.AuthPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codename");

                    b.Property<int>("ContentTypeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("AuthPermission");
                });

            modelBuilder.Entity("Star.Data.Models.AuthUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateJoined");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsStaff");

                    b.Property<bool>("IsSuperuser");

                    b.Property<DateTime?>("LastLogin");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("AuthUser");
                });

            modelBuilder.Entity("Star.Data.Models.AuthUserGroups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("AuthUserGroups");
                });

            modelBuilder.Entity("Star.Data.Models.AuthUserUserPermissions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermissionId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UserId");

                    b.ToTable("AuthUserUserPermissions");
                });

            modelBuilder.Entity("Star.Data.Models.Defaultskillleveldescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentfulId");

                    b.Property<string>("Name");

                    b.Property<string>("Percent100");

                    b.Property<string>("Percent20");

                    b.Property<string>("Percent40");

                    b.Property<string>("Percent60");

                    b.Property<string>("Percent80");

                    b.HasKey("Id");

                    b.ToTable("Defaultskillleveldescription");
                });

            modelBuilder.Entity("Star.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio");

                    b.Property<DateTime?>("Birthday");

                    b.Property<string>("ContentfulId");

                    b.Property<string>("ExpertSkillsJson");

                    b.Property<int?>("GenderId");

                    b.Property<string>("GeneralSkillsJson");

                    b.Property<string>("GoalsJson");

                    b.Property<string>("Name");

                    b.Property<int?>("OfficeId");

                    b.Property<int?>("RoleId");

                    b.Property<DateTime?>("StartedCreuna");

                    b.Property<DateTime?>("StartedWorking");

                    b.Property<int?>("TeamId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("RoleId");

                    b.HasIndex("TeamId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Star.Data.Models.Employeeskill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Current");

                    b.Property<int?>("EmployeeId");

                    b.Property<int?>("ExpertSkillId");

                    b.Property<int?>("Future");

                    b.Property<int?>("GeneralSkillId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ExpertSkillId");

                    b.HasIndex("GeneralSkillId");

                    b.ToTable("Employeeskill");
                });

            modelBuilder.Entity("Star.Data.Models.Expertskill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentfulId");

                    b.Property<int?>("DefaultDescriptionId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Percent100");

                    b.Property<string>("Percent20");

                    b.Property<string>("Percent40");

                    b.Property<string>("Percent60");

                    b.Property<string>("Percent80");

                    b.Property<int?>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("DefaultDescriptionId");

                    b.HasIndex("RoleId");

                    b.ToTable("Expertskill");
                });

            modelBuilder.Entity("Star.Data.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentfulId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("Star.Data.Models.Generalskill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentfulId");

                    b.Property<int?>("DefaultDescriptionId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Percent100");

                    b.Property<string>("Percent20");

                    b.Property<string>("Percent40");

                    b.Property<string>("Percent60");

                    b.Property<string>("Percent80");

                    b.HasKey("Id");

                    b.HasIndex("DefaultDescriptionId");

                    b.ToTable("Generalskill");
                });

            modelBuilder.Entity("Star.Data.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentfulId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Office");
                });

            modelBuilder.Entity("Star.Data.Models.Sitetext", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentfulId");

                    b.Property<string>("LandingPageBody");

                    b.Property<string>("LandingPageHeading");

                    b.Property<string>("LandingPagePreamble");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("StarSitetext");
                });

            modelBuilder.Entity("Star.Data.Models.StarRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentfulId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("StarRole");
                });

            modelBuilder.Entity("Star.Data.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentfulId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("Star.Data.Models.AuthGroupPermissions", b =>
                {
                    b.HasOne("Star.Data.Models.AuthGroup", "Group")
                        .WithMany("AuthGroupPermissions")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Star.Data.Models.AuthPermission", "Permission")
                        .WithMany("AuthGroupPermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Star.Data.Models.AuthUserGroups", b =>
                {
                    b.HasOne("Star.Data.Models.AuthGroup", "Group")
                        .WithMany("AuthUserGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Star.Data.Models.AuthUser", "User")
                        .WithMany("AuthUserGroups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Star.Data.Models.AuthUserUserPermissions", b =>
                {
                    b.HasOne("Star.Data.Models.AuthPermission", "Permission")
                        .WithMany("AuthUserUserPermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Star.Data.Models.AuthUser", "User")
                        .WithMany("AuthUserUserPermissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Star.Data.Models.Employee", b =>
                {
                    b.HasOne("Star.Data.Models.Gender", "Gender")
                        .WithMany("Employees")
                        .HasForeignKey("GenderId");

                    b.HasOne("Star.Data.Models.Office", "Office")
                        .WithMany("Employee")
                        .HasForeignKey("OfficeId");

                    b.HasOne("Star.Data.Models.StarRole", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleId");

                    b.HasOne("Star.Data.Models.Team", "Team")
                        .WithMany("Employees")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Star.Data.Models.Employeeskill", b =>
                {
                    b.HasOne("Star.Data.Models.Employee", "Employee")
                        .WithMany("Employeeskills")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Star.Data.Models.Expertskill", "ExpertSkill")
                        .WithMany("Employeeskills")
                        .HasForeignKey("ExpertSkillId");

                    b.HasOne("Star.Data.Models.Generalskill", "GeneralSkill")
                        .WithMany("Employeeskills")
                        .HasForeignKey("GeneralSkillId");
                });

            modelBuilder.Entity("Star.Data.Models.Expertskill", b =>
                {
                    b.HasOne("Star.Data.Models.Defaultskillleveldescription", "DefaultDescription")
                        .WithMany("Expertskills")
                        .HasForeignKey("DefaultDescriptionId");

                    b.HasOne("Star.Data.Models.StarRole", "Role")
                        .WithMany("Expertskills")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Star.Data.Models.Generalskill", b =>
                {
                    b.HasOne("Star.Data.Models.Defaultskillleveldescription", "DefaultDescription")
                        .WithMany("Generalskills")
                        .HasForeignKey("DefaultDescriptionId");
                });
#pragma warning restore 612, 618
        }
    }
}
