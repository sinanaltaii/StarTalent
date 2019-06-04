using System.Collections.Generic;

namespace Star.Data.Models
{
	public class Gender : BaseModel
	{
		public Gender() 
		{
			Employees = new HashSet<Employee>();
		}

		public string ContentfulId { get; set; }
		public string Name { get; set; }

		public ICollection<Employee> Employees { get; set; }
	}
}
