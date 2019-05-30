using System;
using System.Collections.Generic;

namespace Star.Data.Models
{
	public class AuthUser
	{
		public AuthUser()
		{
			AuthUserGroups = new HashSet<AuthUserGroups>();
			AuthUserUserPermissions = new HashSet<AuthUserUserPermissions>();
		}

		public int Id { get; set; }
		public string Password { get; set; }
		public DateTime? LastLogin { get; set; }
		public bool IsSuperuser { get; set; }
		public string Username { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public bool IsStaff { get; set; }
		public bool IsActive { get; set; }
		public DateTime DateJoined { get; set; }

		public ICollection<AuthUserGroups> AuthUserGroups { get; set; }
		public ICollection<AuthUserUserPermissions> AuthUserUserPermissions { get; set; }
	}
}
