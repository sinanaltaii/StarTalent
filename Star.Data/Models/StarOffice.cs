using System.Collections.Generic;

namespace Star.Data.Models
{
	public class StarOffice
	{
		public StarOffice()
		{
			StarEmployee = new HashSet<StarEmployee>();
		}

		public int Id { get; set; }
		public string ContentfulId { get; set; }
		public string Name { get; set; }

		public ICollection<StarEmployee> StarEmployee { get; set; }
	}
}
