using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Star.Data.Models
{
	public class Office : BaseModel
	{
		public Office()
		{
			Employee = new HashSet<Employee>();
		}

		//[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public string ContentfulId { get; set; }
		public string Name { get; set; }

		public ICollection<Employee> Employee { get; set; }
	}
}
