﻿using System;
using System.Collections.Generic;

namespace Star.Data.Models
{
	public class StarEmployee
	{
		public StarEmployee()
		{
			StarEmployeeskill = new HashSet<StarEmployeeskill>();
		}

		public int Id { get; set; }
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

		public StarGender Gender { get; set; }
		public StarOffice Office { get; set; }
		public StarRole Role { get; set; }
		public StarTeam Team { get; set; }
		public ICollection<StarEmployeeskill> StarEmployeeskill { get; set; }
	}
}