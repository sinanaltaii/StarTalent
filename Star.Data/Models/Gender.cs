using System.Collections.Generic;

namespace Star.Data.Models
{
	public class Gender
	{
		public Gender()
		{
			Employees = new HashSet<Employee>();
		}

		public int Id { get; set; }
		public string ContentfulId { get; set; }
		public string Name { get; set; }

		public ICollection<Employee> Employees { get; set; }
	}
}
