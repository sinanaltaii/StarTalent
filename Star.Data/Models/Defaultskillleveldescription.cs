using System.Collections.Generic;

namespace Star.Data.Models
{
	public class Defaultskillleveldescription
	{
		public Defaultskillleveldescription()
		{
			Expertskills = new HashSet<Expertskill>();
			Generalskills = new HashSet<Generalskill>();
		}

		public int Id { get; set; }
		public string ContentfulId { get; set; }
		public string Name { get; set; }
		public string Percent20 { get; set; }
		public string Percent40 { get; set; }
		public string Percent60 { get; set; }
		public string Percent80 { get; set; }
		public string Percent100 { get; set; }

		public ICollection<Expertskill> Expertskills { get; set; }
		public ICollection<Generalskill> Generalskills { get; set; }
	}
}
