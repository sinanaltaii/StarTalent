using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Star.Data.Migrations
{
    public partial class Intitial : Migration
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
                name: "StarDefaultskillleveldescription",
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
                    table.PrimaryKey("PK_StarDefaultskillleveldescription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StarGender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentfulId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarGender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StarOffice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentfulId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarOffice", x => x.Id);
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
                name: "StarTeam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentfulId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarTeam", x => x.Id);
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
                name: "StarGeneralskill",
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
                    table.PrimaryKey("PK_StarGeneralskill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StarGeneralskill_StarDefaultskillleveldescription_DefaultDescriptionId",
                        column: x => x.DefaultDescriptionId,
                        principalTable: "StarDefaultskillleveldescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StarExpertskill",
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
                    table.PrimaryKey("PK_StarExpertskill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StarExpertskill_StarDefaultskillleveldescription_DefaultDescriptionId",
                        column: x => x.DefaultDescriptionId,
                        principalTable: "StarDefaultskillleveldescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarExpertskill_StarRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "StarRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StarEmployee",
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
                    table.PrimaryKey("PK_StarEmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StarEmployee_StarGender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "StarGender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarEmployee_StarOffice_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "StarOffice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarEmployee_StarRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "StarRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarEmployee_StarTeam_TeamId",
                        column: x => x.TeamId,
                        principalTable: "StarTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StarEmployeeskill",
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
                    table.PrimaryKey("PK_StarEmployeeskill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StarEmployeeskill_StarEmployee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "StarEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarEmployeeskill_StarExpertskill_ExpertSkillId",
                        column: x => x.ExpertSkillId,
                        principalTable: "StarExpertskill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarEmployeeskill_StarGeneralskill_GeneralSkillId",
                        column: x => x.GeneralSkillId,
                        principalTable: "StarGeneralskill",
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
                name: "IX_StarEmployee_GenderId",
                table: "StarEmployee",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_StarEmployee_OfficeId",
                table: "StarEmployee",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_StarEmployee_RoleId",
                table: "StarEmployee",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_StarEmployee_TeamId",
                table: "StarEmployee",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_StarEmployeeskill_EmployeeId",
                table: "StarEmployeeskill",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_StarEmployeeskill_ExpertSkillId",
                table: "StarEmployeeskill",
                column: "ExpertSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_StarEmployeeskill_GeneralSkillId",
                table: "StarEmployeeskill",
                column: "GeneralSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_StarExpertskill_DefaultDescriptionId",
                table: "StarExpertskill",
                column: "DefaultDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_StarExpertskill_RoleId",
                table: "StarExpertskill",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_StarGeneralskill_DefaultDescriptionId",
                table: "StarGeneralskill",
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
                name: "StarEmployeeskill");

            migrationBuilder.DropTable(
                name: "StarSitetext");

            migrationBuilder.DropTable(
                name: "AuthGroup");

            migrationBuilder.DropTable(
                name: "AuthPermission");

            migrationBuilder.DropTable(
                name: "AuthUser");

            migrationBuilder.DropTable(
                name: "StarEmployee");

            migrationBuilder.DropTable(
                name: "StarExpertskill");

            migrationBuilder.DropTable(
                name: "StarGeneralskill");

            migrationBuilder.DropTable(
                name: "StarGender");

            migrationBuilder.DropTable(
                name: "StarOffice");

            migrationBuilder.DropTable(
                name: "StarTeam");

            migrationBuilder.DropTable(
                name: "StarRole");

            migrationBuilder.DropTable(
                name: "StarDefaultskillleveldescription");
        }
    }
}
