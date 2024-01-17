using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Lab3
{
	public interface ISearch<TCriteria, TResult>
	{
		List<TResult> Search(TCriteria criteria);
	}

	public class DomSearch : ISearch<SearchCriteria, Scientist>
	{
		public List<Scientist> Search(SearchCriteria criteria)
		{
			List<Scientist> scientists = new List<Scientist>();
			XmlDocument doc = new XmlDocument();
			doc.Load(FilusReader.scientistXmlPath);

			XmlNodeList scientistNodes = doc.SelectNodes("//scientist");
			foreach (XmlNode scientistNode in scientistNodes)
			{
				Scientist scientist = new Scientist();
				FillAttributes(scientist, scientistNode);

				if (!scientist.HasEmptyAttribute() && MatchesCriteria(scientist, criteria))
				{
					scientists.Add(scientist);
				}
			}

			return scientists;
		}

		private void FillAttributes(Scientist scientist, XmlNode scientistNode)
		{
			scientist.PIP = scientistNode.SelectSingleNode("pip")?.InnerText;
			scientist.Name = scientistNode.SelectSingleNode("name")?.InnerText;
			scientist.Department = scientistNode.SelectSingleNode("faculty/department")?.InnerText;
			scientist.Branch = scientistNode.SelectSingleNode("faculty/branch")?.InnerText;
			scientist.ScientificDegree = scientistNode.SelectSingleNode("scientificDegree")?.InnerText;
			scientist.AcademicTitle = scientistNode.SelectSingleNode("academicTitle/title")?.InnerText;
			scientist.TitleFromDate = DateTime.TryParse(scientistNode.SelectSingleNode("academicTitle/fromDate")?.InnerText, out DateTime fromDate) ? fromDate : DateTime.MinValue;
		}

		private bool MatchesCriteria(Scientist scientist, SearchCriteria criteria)
		{
			return (string.IsNullOrEmpty(criteria.Department) || scientist.Department == criteria.Department) &&
				   (string.IsNullOrEmpty(criteria.Branch) || scientist.Branch == criteria.Branch) &&
				   (string.IsNullOrEmpty(criteria.ScientificDegree) || scientist.ScientificDegree == criteria.ScientificDegree) &&
				   (string.IsNullOrEmpty(criteria.AcademicTitle) || scientist.AcademicTitle == criteria.AcademicTitle);
		}
	}

	public class SaxSearch : ISearch<SearchCriteria, Scientist>
	{
		public List<Scientist> Search(SearchCriteria criteria)
		{
			List<Scientist> scientists = new List<Scientist>();
			using (var xmlReader = new XmlTextReader(FilusReader.scientistXmlPath))
			{
				Scientist scientist = null;

				while (xmlReader.Read())
				{
					if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "scientist")
					{
						scientist = new Scientist();
					}
					else if (xmlReader.NodeType == XmlNodeType.EndElement && xmlReader.Name == "scientist")
					{
						if (!scientist.HasEmptyAttribute() && MatchesCriteria(scientist, criteria))
						{
							scientists.Add(scientist);
						}
					}
					else if (xmlReader.NodeType == XmlNodeType.Text)
					{
						if (xmlReader.LocalName == "pip") scientist.PIP = xmlReader.Value;
						else if (xmlReader.LocalName == "name") scientist.Name = xmlReader.Value;
						else if (xmlReader.LocalName == "department") scientist.Department = xmlReader.Value;
						else if (xmlReader.LocalName == "branch") scientist.Branch = xmlReader.Value;
						else if (xmlReader.LocalName == "scientificDegree") scientist.ScientificDegree = xmlReader.Value;
						else if (xmlReader.LocalName == "academicTitle") scientist.AcademicTitle = xmlReader.Value;
						else if (xmlReader.LocalName == "fromDate") scientist.TitleFromDate = DateTime.Parse(xmlReader.Value);
					}
				}
			}

			return scientists;
		}

		private bool MatchesCriteria(Scientist scientist, SearchCriteria criteria)
		{
			return (string.IsNullOrEmpty(criteria.Department) || scientist.Department == criteria.Department) &&
				   (string.IsNullOrEmpty(criteria.Branch) || scientist.Branch == criteria.Branch) &&
				   (string.IsNullOrEmpty(criteria.ScientificDegree) || scientist.ScientificDegree == criteria.ScientificDegree) &&
				   (string.IsNullOrEmpty(criteria.AcademicTitle) || scientist.AcademicTitle == criteria.AcademicTitle);
		}
	}

	public class LinqToXmlSearch : ISearch<SearchCriteria, Scientist>
	{
		public List<Scientist> Search(SearchCriteria criteria)
		{
			var doc = XDocument.Load(FilusReader.scientistXmlPath);
			var query = doc.Descendants("scientist")
						   .Select(node => new Scientist
						   {
							   PIP = node.Element("pip")?.Value,
							   Name = node.Element("name")?.Value,
							   Department = node.Element("faculty")?.Element("department")?.Value,
							   Branch = node.Element("faculty")?.Element("branch")?.Value,
							   ScientificDegree = node.Element("scientificDegree")?.Value,
							   AcademicTitle = node.Element("academicTitle")?.Element("title")?.Value,
							   TitleFromDate = DateTime.TryParse(node.Element("academicTitle")?.Element("fromDate")?.Value, out DateTime fromDate) ? fromDate : DateTime.MinValue
						   })
						   .Where(scientist => !scientist.HasEmptyAttribute() && MatchesCriteria(scientist, criteria))
						   .ToList();

			return query;
		}

		private bool MatchesCriteria(Scientist scientist, SearchCriteria criteria)
		{
			return (string.IsNullOrEmpty(criteria.Department) || scientist.Department == criteria.Department) &&
				   (string.IsNullOrEmpty(criteria.Branch) || scientist.Branch == criteria.Branch) &&
				   (string.IsNullOrEmpty(criteria.ScientificDegree) || scientist.ScientificDegree == criteria.ScientificDegree) &&
				   (string.IsNullOrEmpty(criteria.AcademicTitle) || scientist.AcademicTitle == criteria.AcademicTitle);
		}
	}
}