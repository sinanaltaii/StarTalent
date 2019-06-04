using System.Collections.Generic;

namespace Star.Data.Models
{
	public class AuthPermission : BaseModel
	{
		public AuthPermission()
		{
			AuthGroupPermissions = new HashSet<AuthGroupPermissions>();
			AuthUserUserPermissions = new HashSet<AuthUserUserPermissions>();
		}

		public string Name { get; set; }
		public int ContentTypeId { get; set; }
		public string Codename { get; set; }

		public ICollection<AuthGroupPermissions> AuthGroupPermissions { get; set; }
		public ICollection<AuthUserUserPermissions> AuthUserUserPermissions { get; set; }
	}
}
