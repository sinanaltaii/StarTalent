using Microsoft.EntityFrameworkCore;
using Star.Data.Models;

namespace Star.Data.DataContext
{
	public class StarDbContext : DbContext
	{
		public StarDbContext()
		{
		}

		public StarDbContext(DbContextOptions<StarDbContext> options) : base(options)
		{
		}

		public DbSet<AuthGroup> AuthGroup { get; set; }
		public DbSet<AuthGroupPermissions> AuthGroupPermissions { get; set; }
		public DbSet<AuthPermission> AuthPermission { get; set; }
		public DbSet<AuthUser> AuthUser { get; set; }
		public DbSet<AuthUserGroups> AuthUserGroups { get; set; }
		public DbSet<AuthUserUserPermissions> AuthUserUserPermissions { get; set; }
		public DbSet<StarDefaultskillleveldescription> StarDefaultskillleveldescription { get; set; }
		public DbSet<StarEmployee> StarEmployee { get; set; }
		public DbSet<StarEmployeeskill> StarEmployeeskill { get; set; }
		public DbSet<StarExpertskill> StarExpertskill { get; set; }
		public DbSet<StarGender> StarGender { get; set; }
		public DbSet<StarGeneralskill> StarGeneralskill { get; set; }
		public DbSet<StarOffice> StarOffice { get; set; }
		public DbSet<StarRole> StarRole { get; set; }
		public DbSet<StarSitetext> StarSitetext { get; set; }
		public DbSet<StarTeam> StarTeam { get; set; }
	}
}
