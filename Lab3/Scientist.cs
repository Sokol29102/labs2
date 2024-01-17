using System;

namespace Lab3
{
	public class Scientist
	{
		public string PIP { get; set; }
		public string Department { get; set; }
		public string Branch { get; set; }
		public string ScientificDegree { get; set; }
		public string AcademicTitle { get; set; }
		public DateTime TitleFromDate { get; set; }
		public string Name { get; set; }

		public bool HasEmptyAttribute()
		{
			return String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(Department) || String.IsNullOrEmpty(Branch)
				|| String.IsNullOrEmpty(ScientificDegree) || String.IsNullOrEmpty(AcademicTitle);
		}
	}
}