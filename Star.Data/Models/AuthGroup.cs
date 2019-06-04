using System.Collections.Generic;

namespace Star.Data.Models
{
	public class AuthGroup : BaseModel
	{
		public AuthGroup()
		{
			AuthGroupPermissions = new HashSet<AuthGroupPermissions>();
			AuthUserGroups = new HashSet<AuthUserGroups>();
		}

		public string Name { get; set; }

		public ICollection<AuthGroupPermissions> AuthGroupPermissions { get; set; }
		public ICollection<AuthUserGroups> AuthUserGroups { get; set; }
	}
}
