namespace Star.Data.Models
{
	public class AuthGroupPermissions : BaseModel
	{
		public int GroupId { get; set; }
		public int PermissionId { get; set; }

		public AuthGroup Group { get; set; }
		public AuthPermission Permission { get; set; }
	}
}
