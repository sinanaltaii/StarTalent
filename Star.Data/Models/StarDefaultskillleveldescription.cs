using System.Collections.Generic;

namespace Star.Data.Models
{
	public class StarDefaultskillleveldescription
	{
		public StarDefaultskillleveldescription()
		{
			StarExpertskill = new HashSet<StarExpertskill>();
			StarGeneralskill = new HashSet<StarGeneralskill>();
		}

		public int Id { get; set; }
		public string ContentfulId { get; set; }
		public string Name { get; set; }
		public string Percent20 { get; set; }
		public string Percent40 { get; set; }
		public string Percent60 { get; set; }
		public string Percent80 { get; set; }
		public string Percent100 { get; set; }

		public virtual ICollection<StarExpertskill> StarExpertskill { get; set; }
		public virtual ICollection<StarGeneralskill> StarGeneralskill { get; set; }
	}
}
