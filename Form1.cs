using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace CourseWork
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "JSON Files (*.json)|*.json",
				Title = "Save Data"
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				//var houseData = new
				//{
				//	LastName = txtLastName.Text,
				//	FirstName = txtFirstName.Text,
				//	MiddleName = txtMiddleName.Text,
				//	Gender = comboGender.SelectedItem?.ToString(),
				//	Passport = txtPassport.Text,
				//	Citizenship = txtCitizenship.Text,
				//	BirthDate = dateTimeBirth.Value,
				//	PlaceOfBirth = txtPlaceOfBirth.Text,
				//	IssueDate = dateTimeIssue.Value,
				//	SpecialInfo = txtSpecialInfo.Text
				//};

				//string jsonString = System.Text.Json.JsonSerializer.Serialize(houseData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
				//File.WriteAllText(saveFileDialog.FileName, jsonString);

				//statusLabel.Text = "Data saved successfully!";
			}
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "JSON Files (*.json)|*.json",
				Title = "Load Data"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				//string jsonString = File.ReadAllText(openFileDialog.FileName);
				//var houseData = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsonString);

				//txtLastName.Text = houseData["LastName"];
				//txtFirstName.Text = houseData["FirstName"];
				//txtMiddleName.Text = houseData["MiddleName"];
				//comboGender.SelectedItem = houseData["Gender"];
				//txtPassport.Text = houseData["Passport"];
				//txtCitizenship.Text = houseData["Citizenship"];
				//dateTimeBirth.Value = DateTime.Parse(houseData["BirthDate"].ToString());
				//txtPlaceOfBirth.Text = houseData["PlaceOfBirth"];
				//dateTimeIssue.Value = DateTime.Parse(houseData["IssueDate"].ToString());
				//txtSpecialInfo.Text = houseData["SpecialInfo"];

				//statusLabel.Text = "Data loaded successfully!";
			}
		}
	}
}
