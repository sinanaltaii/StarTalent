using System.Collections.Generic;

namespace Star.Data.Models
{
	public class Expertskill : BaseModel
	{
		public Expertskill()
		{
			Employeeskills = new HashSet<Employeeskill>();
		}

		public string ContentfulId { get; set; }
		public string Name { get; set; }
		public string Percent20 { get; set; }
		public string Percent40 { get; set; }
		public string Percent60 { get; set; }
		public string Percent80 { get; set; }
		public string Percent100 { get; set; }
		public string Description { get; set; }
		public int? DefaultDescriptionId { get; set; }
		public int? RoleId { get; set; }

		public Defaultskillleveldescription DefaultDescription { get; set; }
		public StarRole Role { get; set; }
		public ICollection<Employeeskill> Employeeskills { get; set; }
	}
}
