namespace Star.Data.Models
{
	public class StarEmployeeskill
	{
		public int Id { get; set; }
		public int? Current { get; set; }
		public int? Future { get; set; }
		public int? EmployeeId { get; set; }
		public int? ExpertSkillId { get; set; }
		public int? GeneralSkillId { get; set; }

		public StarEmployee Employee { get; set; }
		public StarExpertskill ExpertSkill { get; set; }
		public StarGeneralskill GeneralSkill { get; set; }
	}
}
