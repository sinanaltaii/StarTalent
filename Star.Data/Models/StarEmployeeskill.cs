namespace Star.Data.Models
{
	public partial class StarEmployeeskill
	{
		public int Id { get; set; }
		public int? Current { get; set; }
		public int? Future { get; set; }
		public int? EmployeeId { get; set; }
		public int? ExpertSkillId { get; set; }
		public int? GeneralSkillId { get; set; }

		public virtual StarEmployee Employee { get; set; }
		public virtual StarExpertskill ExpertSkill { get; set; }
		public virtual StarGeneralskill GeneralSkill { get; set; }
	}
}
