using System;
using System.Collections.Generic;
using Star.Data.Models;
using Star.Service.GenderUoW;
using Star.Service.OfficeUoW;

namespace Star.Service.EmployeeUoW
{
	public class EmployeeModel
	{
		public EmployeeModel()
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

		public GenderModel Gender { get; set; }
		public OfficeModel Office { get; set; }
		public StarRole Role { get; set; }

		public ICollection<Employeeskill> Employeeskills { get; set; }
	}
}
