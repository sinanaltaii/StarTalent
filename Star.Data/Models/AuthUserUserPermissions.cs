namespace Star.Data.Models
{
	public class AuthUserUserPermissions : BaseModel
	{
		public int UserId { get; set; }
		public int PermissionId { get; set; }

		public AuthPermission Permission { get; set; }
		public AuthUser User { get; set; }
	}
}
