using System.Text;
using System.Text.RegularExpressions;


namespace lab3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void OpenFileButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog OpenDlg = new();
			if (OpenDlg.ShowDialog() == DialogResult.OK)
			{
				StreamReader Reader = new(OpenDlg.FileName, Encoding.Default);
				mainTextBox.Text = Reader.ReadToEnd();
				Reader.Close();
			}
			OpenDlg.Dispose();
		}
		private void startButton_Click(object sender, EventArgs e)
		{
			string text = mainTextBox.Text;
			string[] words = text.Split(new char[] { '\n', '\t', ' ' },
										StringSplitOptions.RemoveEmptyEntries);
			section1.Items.Clear();
			foreach (string word in words)
			{
				if (word == string.Empty || word[0] == 30 || word[0] == 29 || word[0] == 13 || word[0] == 31)
					continue;

				if (
					radio1.Checked ||
					radio2.Checked && Regex.IsMatch(word, @"\d") ||
					radio3.Checked && Regex.IsMatch(word, @"\w+@\w+\.\w+")
				   )
				{
					section1.Items.Add(word);
				}
			}
			if (!radio1.Checked && !radio2.Checked && !radio3.Checked)
				warningLabel.Text = "Пожалуйста, выберите режим ввода";
		}
		private void MoveSelectedItem(ListBox listBox1, ListBox listBox2)
		{
			object? selected = listBox1.SelectedItem;
			if (selected == null)
			{
				warningLabel.Text = "Пожалуста, выберите строку для перемещения";
				return;
			}
			string? item = selected.ToString();
			listBox2.Items.Add(item);
			listBox1.Items.Remove(item);
		}

		private void MoveAllItems(ListBox listBox1, ListBox listBox2)
		{
			listBox2.Items.AddRange(listBox1.Items);
			listBox1.Items.Clear();
		}

		private void moveToRightButton_Click(object sender, EventArgs e) => MoveSelectedItem(section1, section2);

		private void moveToLefyButton_Click(object sender, EventArgs e) => MoveSelectedItem(section2, section1);

		private void moveAllToRightButton_Click(object sender, EventArgs e) => MoveAllItems(section1, section2);

		private void moveAllToLeftButton_Click(object sender, EventArgs e) => MoveAllItems(section2, section1);

		private void clearButton1_Click(object sender, EventArgs e) => section1.Items.Clear();

		private void clearButton2_Click(object sender, EventArgs e) => section2.Items.Clear();

		private void resetButton_Click(object sender, EventArgs e)
		{
			section1.Items.Clear();
			section2.Items.Clear();
			searchResult.Items.Clear();
			mainTextBox.Text = warningLabel.Text = searchInput.Text = "";
			radio1.Checked = radio2.Checked = radio3.Checked = false;
			checkBox1.Checked = checkBox2.Checked = false;
		}

		private void exitButton_Click_1(object sender, EventArgs e) => Application.Exit();

		private void SortSection(ListBox section, ComboBox comboBox)
		{
			int sortIndex = comboBox.SelectedIndex;
			if (sortIndex == -1)
			{
				warningLabel.Text = "Пожалуйста, выберите способ сортировки";
				return;
			}

			List<string> toSort = section.Items.Cast<string>().ToList();

			if (sortIndex <= 1)
				toSort.Sort();
			else
				LengthSort(toSort);

			if (sortIndex == 1 || sortIndex == 3)
				toSort.Reverse();


			section.Items.Clear();
			section.Items.AddRange(toSort.ToArray());

			void LengthSort(List<string> list)
			{
				for (int i = 0; i < list.Count - 1; i++)
				{
					int pos = i;
					while (pos >= 0 && list[pos].Length > list[pos + 1].Length)
					{
						(list[pos], list[pos + 1]) = (list[pos + 1], list[pos]);
						pos--;
					}
				}
			}
		}

		private void sortButton1_Click(object sender, EventArgs e) => SortSection(section1, comboBox1);

		private void sortButton2_Click(object sender, EventArgs e) => SortSection(section2, comboBox2);

		private void searchInput_TextChanged(object sender, EventArgs e)
		{
			string toFind = searchInput.Text;
			if (toFind == "")
			{
				searchResult.Items.Clear();
				return;
			}

			Regex regex = new($@"\w*{toFind}\w*");
			bool found = false;

			searchResult.Items.Clear();

			List<ListBox> sections = new();
			if (checkBox1.Checked)
				sections.Add(section1);
			if (checkBox2.Checked)
				sections.Add(section2);

			foreach (ListBox section in sections)
			{
				foreach (var word in section.Items)
				{
					if (regex.IsMatch(word.ToString()))
					{
						found = true;
						searchResult.Items.Add(word);
					}
				}
			}

			if (sections.Count == 0)
				searchResult.Items.Add("Не выбраны секции для поиска");
			else if (!found)
				searchResult.Items.Add("Нет совпадений");
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			AddForm form = new()
			{
				Owner = this
			};
			form.ShowDialog();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog SaveDlg = new();
			if (SaveDlg.ShowDialog() == DialogResult.OK)
			{
				StreamWriter Writer = new(SaveDlg.FileName);
				foreach (var word in section2.Items)
					Writer.WriteLine(word);
				Writer.Close();
			}
			SaveDlg.Dispose();
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (section1.SelectedItem == null && section1.SelectedItem == null)
				warningLabel.Text = "Пожалуйста, выберите элементы для удаления";
			if (section1.SelectedItem != null)
				section1.Items.Remove(section1.SelectedItem);
			if (section2.SelectedItem != null)
				section2.Items.Remove(section2.SelectedItem);
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			string toFind = searchInput.Text;
			if (toFind == "")
			{
				searchResult.Items.Clear();
				return;
			}
			Regex regex = new($@"\w*{toFind}\w*");
			bool found = false;

			searchResult.Items.Clear();

			List<ListBox> sections = new();
			if (checkBox1.Checked)
				sections.Add(section1);
			if (checkBox2.Checked)
				sections.Add(section2);

			foreach (ListBox section in sections)
			{
				foreach (var word in section.Items)
				{
					if (regex.IsMatch(word.ToString()))
					{
						found = true;
						searchResult.Items.Add(word);
					}
				}
			}

			if (sections.Count == 0)
				searchResult.Items.Add("Не выбраны секции для поиска");
			else if (!found)
				searchResult.Items.Add("Нет совпадений");
		}
	}
}