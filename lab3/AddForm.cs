namespace lab3
{
	public partial class AddForm : Form
	{
		public AddForm()
		{
			InitializeComponent();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			string text = inputBox.Text;
			warningLabel.Text = "";
			if (text.Contains(' ') || text.Contains('\t') || text.Contains('\n') || text == "")
			{
				warningLabel.Text = "Пожалуйста, введите ровно одно слово";
				return;
			}
			Form1? owner = Owner as Form1;
			if (sectionBox1.Checked)
				owner.section1.Items.Add(text);
			if (sectionBox2.Checked)
				owner.section2.Items.Add(text);
			if (!sectionBox1.Checked && !sectionBox2.Checked)
				warningLabel.Text = "Пожалуйста, выберите раздел";
		}

		private void cancelButton_Click(object sender, EventArgs e) => Close();

	}
}
