﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Star.Data.Migrations
{
	public partial class Initial : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "AuthGroup",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Name = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AuthGroup", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "AuthPermission",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Name = table.Column<string>(nullable: true),
					ContentTypeId = table.Column<int>(nullable: false),
					Codename = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AuthPermission", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "AuthUser",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Password = table.Column<string>(nullable: true),
					LastLogin = table.Column<DateTime>(nullable: true),
					IsSuperuser = table.Column<bool>(nullable: false),
					Username = table.Column<string>(nullable: true),
					FirstName = table.Column<string>(nullable: true),
					LastName = table.Column<string>(nullable: true),
					Email = table.Column<string>(nullable: true),
					IsStaff = table.Column<bool>(nullable: false),
					IsActive = table.Column<bool>(nullable: false),
					DateJoined = table.Column<DateTime>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AuthUser", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Defaultskillleveldescription",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					ContentfulId = table.Column<string>(nullable: true),
					Name = table.Column<string>(nullable: true),
					Percent20 = table.Column<string>(nullable: true),
					Percent40 = table.Column<string>(nullable: true),
					Percent60 = table.Column<string>(nullable: true),
					Percent80 = table.Column<string>(nullable: true),
					Percent100 = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Defaultskillleveldescription", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Gender",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					ContentfulId = table.Column<string>(nullable: true),
					Name = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Gender", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Office",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					ContentfulId = table.Column<string>(nullable: true),
					Name = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Office", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "StarRole",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					ContentfulId = table.Column<string>(nullable: true),
					Name = table.Column<string>(nullable: true),
					Description = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_StarRole", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "StarSitetext",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					ContentfulId = table.Column<string>(nullable: true),
					Name = table.Column<string>(nullable: true),
					LandingPageHeading = table.Column<string>(nullable: true),
					LandingPagePreamble = table.Column<string>(nullable: true),
					LandingPageBody = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_StarSitetext", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Team",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					ContentfulId = table.Column<string>(nullable: true),
					Name = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Team", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "AuthGroupPermissions",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					GroupId = table.Column<int>(nullable: false),
					PermissionId = table.Column<int>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AuthGroupPermissions", x => x.Id);
					table.ForeignKey(
						name: "FK_AuthGroupPermissions_AuthGroup_GroupId",
						column: x => x.GroupId,
						principalTable: "AuthGroup",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_AuthGroupPermissions_AuthPermission_PermissionId",
						column: x => x.PermissionId,
						principalTable: "AuthPermission",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AuthUserGroups",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					UserId = table.Column<int>(nullable: false),
					GroupId = table.Column<int>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AuthUserGroups", x => x.Id);
					table.ForeignKey(
						name: "FK_AuthUserGroups_AuthGroup_GroupId",
						column: x => x.GroupId,
						principalTable: "AuthGroup",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_AuthUserGroups_AuthUser_UserId",
						column: x => x.UserId,
						principalTable: "AuthUser",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AuthUserUserPermissions",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					UserId = table.Column<int>(nullable: false),
					PermissionId = table.Column<int>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AuthUserUserPermissions", x => x.Id);
					table.ForeignKey(
						name: "FK_AuthUserUserPermissions_AuthPermission_PermissionId",
						column: x => x.PermissionId,
						principalTable: "AuthPermission",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_AuthUserUserPermissions_AuthUser_UserId",
						column: x => x.UserId,
						principalTable: "AuthUser",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Generalskill",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					ContentfulId = table.Column<string>(nullable: true),
					Name = table.Column<string>(nullable: true),
					Percent20 = table.Column<string>(nullable: true),
					Percent40 = table.Column<string>(nullable: true),
					Percent60 = table.Column<string>(nullable: true),
					Percent80 = table.Column<string>(nullable: true),
					Percent100 = table.Column<string>(nullable: true),
					Description = table.Column<string>(nullable: true),
					DefaultDescriptionId = table.Column<int>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Generalskill", x => x.Id);
					table.ForeignKey(
						name: "FK_Generalskill_Defaultskillleveldescription_DefaultDescriptionId",
						column: x => x.DefaultDescriptionId,
						principalTable: "Defaultskillleveldescription",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateTable(
				name: "Expertskill",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					ContentfulId = table.Column<string>(nullable: true),
					Name = table.Column<string>(nullable: true),
					Percent20 = table.Column<string>(nullable: true),
					Percent40 = table.Column<string>(nullable: true),
					Percent60 = table.Column<string>(nullable: true),
					Percent80 = table.Column<string>(nullable: true),
					Percent100 = table.Column<string>(nullable: true),
					Description = table.Column<string>(nullable: true),
					DefaultDescriptionId = table.Column<int>(nullable: true),
					RoleId = table.Column<int>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Expertskill", x => x.Id);
					table.ForeignKey(
						name: "FK_Expertskill_Defaultskillleveldescription_DefaultDescriptionId",
						column: x => x.DefaultDescriptionId,
						principalTable: "Defaultskillleveldescription",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
					table.ForeignKey(
						name: "FK_Expertskill_StarRole_RoleId",
						column: x => x.RoleId,
						principalTable: "StarRole",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateTable(
				name: "Employee",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					ContentfulId = table.Column<string>(nullable: true),
					Name = table.Column<string>(nullable: true),
					Username = table.Column<string>(nullable: true),
					Bio = table.Column<string>(nullable: true),
					Birthday = table.Column<DateTime>(nullable: true),
					StartedWorking = table.Column<DateTime>(nullable: true),
					StartedCreuna = table.Column<DateTime>(nullable: true),
					GoalsJson = table.Column<string>(nullable: true),
					GeneralSkillsJson = table.Column<string>(nullable: true),
					ExpertSkillsJson = table.Column<string>(nullable: true),
					GenderId = table.Column<int>(nullable: true),
					OfficeId = table.Column<int>(nullable: true),
					RoleId = table.Column<int>(nullable: true),
					TeamId = table.Column<int>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Employee", x => x.Id);
					table.ForeignKey(
						name: "FK_Employee_Gender_GenderId",
						column: x => x.GenderId,
						principalTable: "Gender",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
					table.ForeignKey(
						name: "FK_Employee_Office_OfficeId",
						column: x => x.OfficeId,
						principalTable: "Office",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
					table.ForeignKey(
						name: "FK_Employee_StarRole_RoleId",
						column: x => x.RoleId,
						principalTable: "StarRole",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
					table.ForeignKey(
						name: "FK_Employee_Team_TeamId",
						column: x => x.TeamId,
						principalTable: "Team",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateTable(
				name: "Employeeskill",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Current = table.Column<int>(nullable: true),
					Future = table.Column<int>(nullable: true),
					EmployeeId = table.Column<int>(nullable: true),
					ExpertSkillId = table.Column<int>(nullable: true),
					GeneralSkillId = table.Column<int>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Employeeskill", x => x.Id);
					table.ForeignKey(
						name: "FK_Employeeskill_Employee_EmployeeId",
						column: x => x.EmployeeId,
						principalTable: "Employee",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
					table.ForeignKey(
						name: "FK_Employeeskill_Expertskill_ExpertSkillId",
						column: x => x.ExpertSkillId,
						principalTable: "Expertskill",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
					table.ForeignKey(
						name: "FK_Employeeskill_Generalskill_GeneralSkillId",
						column: x => x.GeneralSkillId,
						principalTable: "Generalskill",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateIndex(
				name: "IX_AuthGroupPermissions_GroupId",
				table: "AuthGroupPermissions",
				column: "GroupId");

			migrationBuilder.CreateIndex(
				name: "IX_AuthGroupPermissions_PermissionId",
				table: "AuthGroupPermissions",
				column: "PermissionId");

			migrationBuilder.CreateIndex(
				name: "IX_AuthUserGroups_GroupId",
				table: "AuthUserGroups",
				column: "GroupId");

			migrationBuilder.CreateIndex(
				name: "IX_AuthUserGroups_UserId",
				table: "AuthUserGroups",
				column: "UserId");

			migrationBuilder.CreateIndex(
				name: "IX_AuthUserUserPermissions_PermissionId",
				table: "AuthUserUserPermissions",
				column: "PermissionId");

			migrationBuilder.CreateIndex(
				name: "IX_AuthUserUserPermissions_UserId",
				table: "AuthUserUserPermissions",
				column: "UserId");

			migrationBuilder.CreateIndex(
				name: "IX_Employee_GenderId",
				table: "Employee",
				column: "GenderId");

			migrationBuilder.CreateIndex(
				name: "IX_Employee_OfficeId",
				table: "Employee",
				column: "OfficeId");

			migrationBuilder.CreateIndex(
				name: "IX_Employee_RoleId",
				table: "Employee",
				column: "RoleId");

			migrationBuilder.CreateIndex(
				name: "IX_Employee_TeamId",
				table: "Employee",
				column: "TeamId");

			migrationBuilder.CreateIndex(
				name: "IX_Employeeskill_EmployeeId",
				table: "Employeeskill",
				column: "EmployeeId");

			migrationBuilder.CreateIndex(
				name: "IX_Employeeskill_ExpertSkillId",
				table: "Employeeskill",
				column: "ExpertSkillId");

			migrationBuilder.CreateIndex(
				name: "IX_Employeeskill_GeneralSkillId",
				table: "Employeeskill",
				column: "GeneralSkillId");

			migrationBuilder.CreateIndex(
				name: "IX_Expertskill_DefaultDescriptionId",
				table: "Expertskill",
				column: "DefaultDescriptionId");

			migrationBuilder.CreateIndex(
				name: "IX_Expertskill_RoleId",
				table: "Expertskill",
				column: "RoleId");

			migrationBuilder.CreateIndex(
				name: "IX_Generalskill_DefaultDescriptionId",
				table: "Generalskill",
				column: "DefaultDescriptionId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "AuthGroupPermissions");

			migrationBuilder.DropTable(
				name: "AuthUserGroups");

			migrationBuilder.DropTable(
				name: "AuthUserUserPermissions");

			migrationBuilder.DropTable(
				name: "Employeeskill");

			migrationBuilder.DropTable(
				name: "StarSitetext");

			migrationBuilder.DropTable(
				name: "AuthGroup");

			migrationBuilder.DropTable(
				name: "AuthPermission");

			migrationBuilder.DropTable(
				name: "AuthUser");

			migrationBuilder.DropTable(
				name: "Employee");

			migrationBuilder.DropTable(
				name: "Expertskill");

			migrationBuilder.DropTable(
				name: "Generalskill");

			migrationBuilder.DropTable(
				name: "Gender");

			migrationBuilder.DropTable(
				name: "Office");

			migrationBuilder.DropTable(
				name: "Team");

			migrationBuilder.DropTable(
				name: "StarRole");

			migrationBuilder.DropTable(
				name: "Defaultskillleveldescription");
		}
	}
}
