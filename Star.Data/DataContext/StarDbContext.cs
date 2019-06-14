using Microsoft.EntityFrameworkCore;
using Star.Data.Models;

namespace Star.Data.DataContext
{
	public class
		StarDbContext : DbContext
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
		public DbSet<Defaultskillleveldescription> Defaultskillleveldescription { get; set; }
		public DbSet<Employee> Employee { get; set; }
		public DbSet<Employeeskill> Employeeskill { get; set; }
		public DbSet<Expertskill> Expertskill { get; set; }
		public DbSet<Gender> Gender { get; set; }
		public DbSet<Generalskill> Generalskill { get; set; }
		public DbSet<Office> Office { get; set; }
		public DbSet<StarRole> StarRole { get; set; }
		public DbSet<Sitetext> StarSitetext { get; set; }
	}
}
