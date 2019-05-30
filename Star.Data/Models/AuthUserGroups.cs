namespace Star.Data.Models
{
	public class AuthUserGroups
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int GroupId { get; set; }

		public AuthGroup Group { get; set; }
		public AuthUser User { get; set; }
	}
}
