﻿namespace Star.Data.Models
{
	public class Sitetext : BaseModel
	{
		public string ContentfulId { get; set; }
		public string Name { get; set; }
		public string LandingPageHeading { get; set; }
		public string LandingPagePreamble { get; set; }
		public string LandingPageBody { get; set; }
	}
}
