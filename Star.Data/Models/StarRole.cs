using System.Collections.Generic;

namespace Star.Data.Models
{
	public class StarRole
	{
		public StarRole()
		{
			StarEmployee = new HashSet<StarEmployee>();
			StarExpertskill = new HashSet<StarExpertskill>();
		}

		public int Id { get; set; }
		public string ContentfulId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public ICollection<StarEmployee> StarEmployee { get; set; }
		public ICollection<StarExpertskill> StarExpertskill { get; set; }
	}
}
