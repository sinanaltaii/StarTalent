﻿using System.Collections.Generic;

namespace Star.Data.Models
{
	public class StarGeneralskill
	{
		public StarGeneralskill()
		{
			StarEmployeeskill = new HashSet<StarEmployeeskill>();
		}

		public int Id { get; set; }
		public string ContentfulId { get; set; }
		public string Name { get; set; }
		public string Percent20 { get; set; }
		public string Percent40 { get; set; }
		public string Percent60 { get; set; }
		public string Percent80 { get; set; }
		public string Percent100 { get; set; }
		public string Description { get; set; }
		public int? DefaultDescriptionId { get; set; }

		public StarDefaultskillleveldescription DefaultDescription { get; set; }
		public ICollection<StarEmployeeskill> StarEmployeeskill { get; set; }
	}
}