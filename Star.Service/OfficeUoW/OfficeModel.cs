using System;
using System.Collections.Generic;
using Star.Service.EmployeeUoW;

namespace Star.Service.OfficeUoW
{
	public class OfficeModel
	{
		public OfficeModel()
		{
			Employees = new HashSet<EmployeeModel>();
		}

		public int Id { get; set; }
		public Guid ContentfulId { get; set; }
		public string Name { get; set; }

		public ICollection<EmployeeModel> Employees { get; set; }
	}
}
