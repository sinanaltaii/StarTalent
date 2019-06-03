using System.Collections.Generic;

namespace Star.Data.Models
{
	public class Generalskill
	{
		public Generalskill()
		{
			Employeeskills = new HashSet<Employeeskill>();
		}

		public int Id { get; set; }
		public string ContentfulId { get; set; }
		public string Name { get; set; }
		public string Percent20 { get; set; }
		public string Percent40 { get; set; }
		public string Percent60 { get; set; }
		public string Percent80 { get; set; }
		public string Percent100 { get; set; }
		public string Description { get; set; }
		public int? DefaultDescriptionId { get; set; }

		public Defaultskillleveldescription DefaultDescription { get; set; }
		public ICollection<Employeeskill> Employeeskills { get; set; }
	}
}
