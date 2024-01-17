using System;
using System.Collections.Generic;
using System.Xml;

namespace Lab3
{
	public struct SearchCriteria
	{
		private readonly string _department;
		private readonly string _branch;
		private readonly string _scientificDegree;
		private readonly string _academicTitle;

		public string Department { get { return _department; } }
		public string Branch { get { return _branch; } }
		public string ScientificDegree { get { return _scientificDegree; } }
		public string AcademicTitle { get { return _academicTitle; } }

		public SearchCriteria(string department, string branch, string scientificDegree, string academicTitle)
		{
			_department = department;
			_branch = branch;
			_scientificDegree = scientificDegree;
			_academicTitle = academicTitle;
		}

		public bool AllCriteriaAreEmpty()
		{
			return _department.Equals("") && _branch.Equals("") && _scientificDegree.Equals("") && _academicTitle.Equals("");
		}

		public List<string> GetCriteriaList()
		{
			return new List<string> { _department, _branch, _scientificDegree, _academicTitle };
		}
	}
}