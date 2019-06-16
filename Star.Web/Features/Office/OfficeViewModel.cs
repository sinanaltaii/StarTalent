using System;
using Star.Web.Features.Employee;
using System.Collections.Generic;


namespace Star.Web.Features.Office
{
	public class OfficeViewModel
	{
		public OfficeViewModel()
		{
			Employees = new HashSet<EmployeeViewModel>();
		}

		public Guid ContentfulId { get; }
		public string Name { get; set; }

		public ICollection<EmployeeViewModel> Employees { get; set; }

	}
}
