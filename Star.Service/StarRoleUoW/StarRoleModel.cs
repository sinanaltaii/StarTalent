using System.Collections.Generic;
using Star.Data.Models;
using Star.Service.EmployeeUoW;

namespace Star.Service.StarRoleUoW
{
	public class StarRoleModel
	{
		public StarRoleModel()
		{
			Employees = new HashSet<EmployeeModel>();
			Expertskills = new HashSet<Expertskill>();
		}

		public string ContentfulId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public ICollection<EmployeeModel> Employees { get; set; }
		public ICollection<Expertskill> Expertskills { get; set; }

	}
}
