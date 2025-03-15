using Newtonsoft.Json;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CourseWork
{
	public partial class Form1 : Form
	{
		public bool Razavaya = true;
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
				var houseData = new
				{
					LastName = textBoxLastName.Text,
					FirstName = textBoxFirstName.Text,
					MiddleName = textBoxPatronymic.Text,
					//Gender = comboGender.SelectedItem?.ToString(),
					Phone = textBoxPhone.Text,
					BirthDate = dateTimePicker.Value,
					SpecialInfo = textBoxComment.Text,
					Regeon = comboBoxRegion.SelectedIndex,
					Strana = comboBoxStrana.SelectedIndex,
					checkedListBox1 = checkedListBox1.Text,
					checkedListBox2 = checkedListBox2.Text,
					checkedListBox3 = checkedListBox3.Text,
				};

				string jsonString = System.Text.Json.JsonSerializer.Serialize(houseData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
				File.WriteAllText(saveFileDialog.FileName, jsonString);
				
				statusLabel.Text = "Data saved successfully!";
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
				string jsonString = File.ReadAllText(openFileDialog.FileName);
				var houseData = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsonString);

				textBoxLastName.Text = houseData["LastName"];
				textBoxFirstName.Text = houseData["FirstName"];
				textBoxPatronymic.Text = houseData["MiddleName"];
				//comboGender.SelectedItem = houseData["Gender"];
				//txtPassport.Text = houseData["Passport"];
				textBoxPhone.Text = houseData["Phone"];
				dateTimePicker.Value = DateTime.Parse(houseData["BirthDate"].ToString());
				comboBoxRegion.SelectedIndex = houseData["Regeon"];
				textBoxComment.Text = houseData["SpecialInfo"];
				statusLabel.Text = "Data loaded successfully!";
				checkedListBox1.Text = houseData["checkedListBox1"];
				checkedListBox2.Text = houseData["checkedListBox2"];
				checkedListBox3.Text = houseData["checkedListBox3"];

			}
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			//
		}

		private void textBox4_Click(object sender, EventArgs e)
		{
			if (Razavaya)
			{
				textBoxPhone.Clear();
				Razavaya = false;
			}
		}

		private void textBoxPhone_TextChanged(object sender, EventArgs e)
		{
			if (textBoxPhone.Text.Length > 11)
			{
				textBoxPhone.Text = textBoxPhone.Text.Substring(0, 11); 
				textBoxPhone.SelectionStart = 11; 
			}
		}
		private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; 
			}

		}
		private void textBoxAllHuman_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; 
			}
		}

		private void textBoxAllHuman_TextChanged(object sender, EventArgs e)
		{
			if (textBoxAllHuman.Text.Length > 2)
			{
				textBoxAllHuman.Text = textBoxAllHuman.Text.Substring(0, 2);
				textBoxAllHuman.SelectionStart = 2;
			}
		}

		private void checkBoxM_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxM.Checked)
			{
				checkBoxJ.Checked = false; // Снимаем выделение с checkBox2
				checkBoxJ.Enabled = false; // Деактивируем checkBox2, если checkBox1 выбран
			}
			else
			{
				checkBoxJ.Enabled = true; // Активируем checkBox2, если checkBox1 снят
			}
		}

		private void checkBoxJ_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxJ.Checked)
			{
				checkBoxM.Checked = false; // Снимаем выделение с checkBox1
				checkBoxM.Enabled = false; // Деактивируем checkBox1, если checkBox2 выбран
			}
			else
			{
				checkBoxM.Enabled = true; // Активируем checkBox1, если checkBox2 снят
			}
		}

		private void helpMenu_Click(object sender, EventArgs e)
		{
			Form2 form = new Form2();
			form.ShowDialog();
		}
	}
}
