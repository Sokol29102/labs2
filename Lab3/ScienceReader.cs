using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Lab3
{
	public partial class FilusReader : Form
	{
		public const string scientistXmlPath = @"E:\labs\Lab3\scientists.xml";
		private const string _transformerPath = @"E:\labs\Lab3\transformer.xsl";
		private const string _htmlPath = @"E:\labs\Lab3\output.html";

		public FilusReader()
		{
			InitializeComponent();
		}

		private void PlaylistReader_Load(object sender, EventArgs e)
		{
			FillCriteriaLists();
		}

		private void FillCriteriaLists()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(scientistXmlPath);

			XmlElement root = doc.DocumentElement;
			XmlNodeList scientists = root.SelectNodes("//scientist");

			foreach (XmlNode scientistNode in scientists)
			{
				string department = scientistNode.SelectSingleNode("faculty/department")?.InnerText;
				string branch = scientistNode.SelectSingleNode("faculty/branch")?.InnerText;
				string scientificDegree = scientistNode.SelectSingleNode("scientificDegree")?.InnerText;
				string academicTitle = scientistNode.SelectSingleNode("academicTitle/title")?.InnerText;

				AddToDropDown(department, scienDropList); 
				AddToDropDown(branch, zdilDropList); 
				AddToDropDown(scientificDegree, degreeList); 
				AddToDropDown(academicTitle, profDropList); 
			}
		}

		private void AddToDropDown(string item, ComboBox comboBox)
		{
			if (!string.IsNullOrEmpty(item) && !comboBox.Items.Contains(item))
			{
				comboBox.Items.Add(item);
			}
		}

		private void searchBtn_Click(object sender, EventArgs e)
		{
			Search();
		}

		private void Search()
		{
			ISearch<SearchCriteria, Scientist> search = new DomSearch();
			if (saxBtn.Checked)
			{
				search = new SaxSearch();
			}
			if (linqToXmlBtn.Checked)
			{
				search = new LinqToXmlSearch();
			}

			List<Scientist> scientists = search.Search(GetSearchCriteria());
			OutputSearchResults(scientists);
		}

		private SearchCriteria GetSearchCriteria()
		{
			string department = scienCheckBox.Checked ? scienDropList.Text : "";
			string branch = zdilCheckBox.Checked ? zdilDropList.Text : "";
			string scientificDegree = degreeCheckBox.Checked ? degreeList.Text : "";
			string academicTitle = profCheckBox.Checked ? profDropList.Text : "";

			return new SearchCriteria(department, branch, scientificDegree, academicTitle);
		}

		private void OutputSearchResults(List<Scientist> scientists)
		{
			searchResultsViewer.Text = "";

			int resultCount = 0;
			foreach (var scientist in scientists)
			{
				searchResultsViewer.Text += "Result " + (resultCount + 1) + "\n";
				searchResultsViewer.Text += "Name: " + scientist.Name + "\n";
				searchResultsViewer.Text += "Department: " + scientist.Department + "\n";
				searchResultsViewer.Text += "Branch: " + scientist.Branch + "\n";
				searchResultsViewer.Text += "Scientific Degree: " + scientist.ScientificDegree + "\n";
				searchResultsViewer.Text += "Academic Title: " + scientist.AcademicTitle + "\n";
				searchResultsViewer.Text += "----------------------------------\n";
				resultCount++;
			}
		}

		// Checkbox changed events
		private void artistCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			scienDropList.Enabled = !scienDropList.Enabled;
			if (scienCheckBox.Checked)
			{
				scienDropList.Text = scienDropList.Items[0].ToString();
			}
		}

		private void genreCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			zdilDropList.Enabled = !zdilDropList.Enabled;
			if (zdilCheckBox.Checked)
			{
				zdilDropList.Text = zdilDropList.Items[0].ToString();
			}
		}

		private void yearCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			degreeList.Enabled = !degreeList.Enabled;
			if (degreeCheckBox.Checked)
			{
				degreeList.Text = degreeList.Items[0].ToString();
			}
		}

		private void labelCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			profDropList.Enabled = !profDropList.Enabled;
			if (profCheckBox.Checked)
			{
				profDropList.Text = profDropList.Items[0].ToString();
			}
		}

		private void forgeHtmlBtn_Click(object sender, EventArgs e)
		{
			ForgeHtml();
		}

		private void ForgeHtml()
		{
			try
			{
				XslCompiledTransform xct = new XslCompiledTransform();
				xct.Load(_transformerPath);
				xct.Transform(scientistXmlPath, _htmlPath);

				MessageBox.Show("HTML file successfully created at " + _htmlPath);
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}
		}
	}
}