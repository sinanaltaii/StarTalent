namespace Star.Data.Models
{
	public class AuthGroupPermissions
	{
		public int Id { get; set; }
		public int GroupId { get; set; }
		public int PermissionId { get; set; }

		public AuthGroup Group { get; set; }
		public AuthPermission Permission { get; set; }
	}
}
