namespace Star.Data.Models
{
	public class Employeeskill : BaseModel
	{
		public int? Current { get; set; }
		public int? Future { get; set; }
		public int? EmployeeId { get; set; }
		public int? ExpertSkillId { get; set; }
		public int? GeneralSkillId { get; set; }

		public Employee Employee { get; set; }
		public Expertskill ExpertSkill { get; set; }
		public Generalskill GeneralSkill { get; set; }
	}
}
