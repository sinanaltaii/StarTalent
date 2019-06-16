using System;
using System.Collections.Generic;

namespace Star.Data.Models
{
	public class Office : BaseModel
	{
		public Office()
		{
			Employee = new HashSet<Employee>();
		}

		public Guid ContentfulId { get; set; }
		public string Name { get; set; }

		public ICollection<Employee> Employee { get; set; }
	}
}
