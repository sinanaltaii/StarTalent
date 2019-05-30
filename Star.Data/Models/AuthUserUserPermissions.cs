﻿namespace Star.Data.Models
{
	public partial class AuthUserUserPermissions
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int PermissionId { get; set; }

		public virtual AuthPermission Permission { get; set; }
		public virtual AuthUser User { get; set; }
	}
}
