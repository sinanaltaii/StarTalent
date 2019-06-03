using System.Collections.Generic;
using Star.Data.Models;

namespace Star.Web.Features.Office
{
	public class OfficeViewModel
	{
		public OfficeViewModel()
		{
			Employees = new HashSet<Employee>();
		}

		public int Id { get; set; }
		public string ContentfulId { get; set; }
		public string Name { get; set; }

		public ICollection<Employee> Employees { get; set; }

	}
}
