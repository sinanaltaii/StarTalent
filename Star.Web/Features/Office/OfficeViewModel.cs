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

		// TODO: is the id needed for this view model?
		//public int Id { get; }
		//public string ContentfulId { get; }
		public string Name { get; set; }

		public ICollection<EmployeeViewModel> Employees { get; set; }

	}
}
