using System;

namespace Star.Data.Models
{
	public partial class DjangoSession
	{
		public string SessionKey { get; set; }
		public string SessionData { get; set; }
		public DateTime ExpireDate { get; set; }
	}
}
