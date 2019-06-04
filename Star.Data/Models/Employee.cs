using System;
using System.Collections.Generic;

namespace Star.Data.Models
{
	public class Employee : BaseModel
	{
		public Employee()
		{
			Employeeskills = new HashSet<Employeeskill>();
		}

		public string ContentfulId { get; set; }
		public string Name { get; set; }
		public string Username { get; set; }
		public string Bio { get; set; }
		public DateTime? Birthday { get; set; }
		public DateTime? StartedWorking { get; set; }
		public DateTime? StartedCreuna { get; set; }
		public string GoalsJson { get; set; }
		public string GeneralSkillsJson { get; set; }
		public string ExpertSkillsJson { get; set; }
		public int? GenderId { get; set; }
		public int? OfficeId { get; set; }
		public int? RoleId { get; set; }
		public int? TeamId { get; set; }

		public Gender Gender { get; set; }
		public Office Office { get; set; }
		public StarRole Role { get; set; }
		public Team Team { get; set; }
		public ICollection<Employeeskill> Employeeskills { get; set; }
	}
}
