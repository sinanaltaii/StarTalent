﻿using System.Collections.Generic;

namespace Star.Data.Models
{
	public class StarRole : BaseModel
	{
		public StarRole()
		{
			Employees = new HashSet<Employee>();
			Expertskills = new HashSet<Expertskill>();
		}

		public string ContentfulId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public ICollection<Employee> Employees { get; set; }
		public ICollection<Expertskill> Expertskills { get; set; }
	}
}
