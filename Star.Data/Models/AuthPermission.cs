using System.Collections.Generic;

namespace Star.Data.Models
{
	public class AuthPermission
	{
		public AuthPermission()
		{
			AuthGroupPermissions = new HashSet<AuthGroupPermissions>();
			AuthUserUserPermissions = new HashSet<AuthUserUserPermissions>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public int ContentTypeId { get; set; }
		public string Codename { get; set; }

		public ICollection<AuthGroupPermissions> AuthGroupPermissions { get; set; }
		public ICollection<AuthUserUserPermissions> AuthUserUserPermissions { get; set; }
	}
}
