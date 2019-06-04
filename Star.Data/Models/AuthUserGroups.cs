namespace Star.Data.Models
{
	public class AuthUserGroups : BaseModel
	{
		public int UserId { get; set; }
		public int GroupId { get; set; }

		public AuthGroup Group { get; set; }
		public AuthUser User { get; set; }
	}
}
