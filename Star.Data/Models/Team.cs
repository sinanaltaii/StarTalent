using System.Collections.Generic;

namespace Star.Data.Models
{
	public class Team : BaseModel
	{
		public Team()
		{
			Employees = new HashSet<Employee>();
		}

		public string ContentfulId { get; set; }
		public string Name { get; set; }

		public ICollection<Employee> Employees { get; set; }
	}
}
