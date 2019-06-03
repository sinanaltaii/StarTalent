using System.Collections.Generic;

namespace Star.Data.Models
{
	public class Office
	{
		public Office()
		{
			Employee = new HashSet<Employee>();
		}

		public int Id { get; set; }
		public string ContentfulId { get; set; }
		public string Name { get; set; }

		public ICollection<Employee> Employee { get; set; }
	}
}
