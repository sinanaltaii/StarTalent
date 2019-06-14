using System.Collections.Generic;
using Star.Service.EmployeeUoW;

namespace Star.Service.GenderUoW
{
	public class GenderModel
	{
		public GenderModel()
		{
			Employees = new HashSet<EmployeeModel>();
		}

		public string ContentfulId { get; set; }
		public string Name { get; set; }

		public ICollection<EmployeeModel> Employees { get; set; }
	}
}
