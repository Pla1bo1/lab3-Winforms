namespace lab3
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			открытьToolStripMenuItem = new ToolStripMenuItem();
			OpenFileButton = new ToolStripMenuItem();
			saveButton = new ToolStripMenuItem();
			resetButton = new ToolStripMenuItem();
			exitButton = new ToolStripMenuItem();
			mainTextBox = new TextBox();
			label1 = new Label();
			label2 = new Label();
			radio1 = new RadioButton();
			radio2 = new RadioButton();
			radio3 = new RadioButton();
			startButton = new Button();
			section1 = new ListBox();
			section2 = new ListBox();
			moveToRightButton = new Button();
			moveToLefyButton = new Button();
			moveAllToLeftButton = new Button();
			moveAllToRightButton = new Button();
			warningLabel = new Label();
			clearButton1 = new Button();
			clearButton2 = new Button();
			sortButton1 = new Button();
			sortButton2 = new Button();
			comboBox1 = new ComboBox();
			comboBox2 = new ComboBox();
			searchInput = new TextBox();
			label4 = new Label();
			label5 = new Label();
			checkBox1 = new CheckBox();
			checkBox2 = new CheckBox();
			searchResult = new ListBox();
			addButton = new Button();
			deleteButton = new Button();
			searchButton = new Button();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = SystemColors.ControlLight;
			menuStrip1.Items.AddRange(new ToolStripItem[] { открытьToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1131, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// открытьToolStripMenuItem
			// 
			открытьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenFileButton, saveButton, resetButton, exitButton });
			открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			открытьToolStripMenuItem.Size = new Size(48, 20);
			открытьToolStripMenuItem.Text = "Файл";
			// 
			// OpenFileButton
			// 
			OpenFileButton.Name = "OpenFileButton";
			OpenFileButton.ShortcutKeys = Keys.Control | Keys.O;
			OpenFileButton.Size = new Size(173, 22);
			OpenFileButton.Text = "Открыть";
			OpenFileButton.Click += OpenFileButton_Click;
			// 
			// saveButton
			// 
			saveButton.Name = "saveButton";
			saveButton.ShortcutKeys = Keys.Control | Keys.S;
			saveButton.Size = new Size(173, 22);
			saveButton.Text = "Сохранить";
			saveButton.Click += saveButton_Click;
			// 
			// resetButton
			// 
			resetButton.Name = "resetButton";
			resetButton.ShortcutKeys = Keys.Control | Keys.R;
			resetButton.Size = new Size(173, 22);
			resetButton.Text = "Сброс";
			resetButton.Click += resetButton_Click;
			// 
			// exitButton
			// 
			exitButton.Name = "exitButton";
			exitButton.ShortcutKeys = Keys.Control | Keys.E;
			exitButton.Size = new Size(173, 22);
			exitButton.Text = "Выход";
			exitButton.Click += exitButton_Click_1;
			// 
			// mainTextBox
			// 
			mainTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			mainTextBox.ForeColor = SystemColors.ActiveCaptionText;
			mainTextBox.Location = new Point(645, 27);
			mainTextBox.Multiline = true;
			mainTextBox.Name = "mainTextBox";
			mainTextBox.ScrollBars = ScrollBars.Both;
			mainTextBox.Size = new Size(474, 494);
			mainTextBox.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(39, 41);
			label1.Name = "label1";
			label1.Size = new Size(68, 20);
			label1.TabIndex = 4;
			label1.Text = "Раздел 1";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(315, 41);
			label2.Name = "label2";
			label2.Size = new Size(68, 20);
			label2.TabIndex = 5;
			label2.Text = "Раздел 2";
			// 
			// radio1
			// 
			radio1.AutoSize = true;
			radio1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			radio1.Location = new Point(738, 546);
			radio1.Name = "radio1";
			radio1.Size = new Size(52, 25);
			radio1.TabIndex = 6;
			radio1.TabStop = true;
			radio1.Text = "Все";
			radio1.UseVisualStyleBackColor = true;
			// 
			// radio2
			// 
			radio2.AutoSize = true;
			radio2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			radio2.Location = new Point(738, 571);
			radio2.Name = "radio2";
			radio2.Size = new Size(177, 25);
			radio2.TabIndex = 7;
			radio2.TabStop = true;
			radio2.Text = "Содержащие цифры";
			radio2.UseVisualStyleBackColor = true;
			// 
			// radio3
			// 
			radio3.AutoSize = true;
			radio3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			radio3.Location = new Point(738, 596);
			radio3.Name = "radio3";
			radio3.Size = new Size(165, 25);
			radio3.TabIndex = 8;
			radio3.TabStop = true;
			radio3.Text = "Содержащие email";
			radio3.UseVisualStyleBackColor = true;
			// 
			// startButton
			// 
			startButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			startButton.Location = new Point(979, 551);
			startButton.Name = "startButton";
			startButton.Size = new Size(106, 52);
			startButton.TabIndex = 9;
			startButton.Text = "Начать";
			startButton.UseVisualStyleBackColor = true;
			startButton.Click += startButton_Click;
			// 
			// section1
			// 
			section1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			section1.FormattingEnabled = true;
			section1.ItemHeight = 20;
			section1.Location = new Point(39, 109);
			section1.Name = "section1";
			section1.Size = new Size(179, 284);
			section1.TabIndex = 10;
			// 
			// section2
			// 
			section2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			section2.FormattingEnabled = true;
			section2.ItemHeight = 20;
			section2.Location = new Point(315, 109);
			section2.Name = "section2";
			section2.Size = new Size(179, 284);
			section2.TabIndex = 11;
			// 
			// moveToRightButton
			// 
			moveToRightButton.AutoSize = true;
			moveToRightButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			moveToRightButton.Location = new Point(241, 151);
			moveToRightButton.Name = "moveToRightButton";
			moveToRightButton.Size = new Size(51, 31);
			moveToRightButton.TabIndex = 12;
			moveToRightButton.Text = ">";
			moveToRightButton.UseVisualStyleBackColor = true;
			moveToRightButton.Click += moveToRightButton_Click;
			// 
			// moveToLefyButton
			// 
			moveToLefyButton.AutoSize = true;
			moveToLefyButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			moveToLefyButton.Location = new Point(241, 201);
			moveToLefyButton.Name = "moveToLefyButton";
			moveToLefyButton.Size = new Size(51, 31);
			moveToLefyButton.TabIndex = 13;
			moveToLefyButton.Text = "<";
			moveToLefyButton.UseVisualStyleBackColor = true;
			moveToLefyButton.Click += moveToLefyButton_Click;
			// 
			// moveAllToLeftButton
			// 
			moveAllToLeftButton.AutoSize = true;
			moveAllToLeftButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			moveAllToLeftButton.Location = new Point(241, 301);
			moveAllToLeftButton.Name = "moveAllToLeftButton";
			moveAllToLeftButton.Size = new Size(51, 31);
			moveAllToLeftButton.TabIndex = 15;
			moveAllToLeftButton.Text = "<<";
			moveAllToLeftButton.UseVisualStyleBackColor = true;
			moveAllToLeftButton.Click += moveAllToLeftButton_Click;
			// 
			// moveAllToRightButton
			// 
			moveAllToRightButton.AutoSize = true;
			moveAllToRightButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			moveAllToRightButton.Location = new Point(241, 251);
			moveAllToRightButton.Name = "moveAllToRightButton";
			moveAllToRightButton.Size = new Size(51, 31);
			moveAllToRightButton.TabIndex = 14;
			moveAllToRightButton.Text = ">>";
			moveAllToRightButton.UseVisualStyleBackColor = true;
			moveAllToRightButton.Click += moveAllToRightButton_Click;
			// 
			// warningLabel
			// 
			warningLabel.BackColor = SystemColors.ButtonFace;
			warningLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			warningLabel.ForeColor = Color.Red;
			warningLabel.Location = new Point(513, 50);
			warningLabel.Name = "warningLabel";
			warningLabel.Size = new Size(117, 132);
			warningLabel.TabIndex = 16;
			// 
			// clearButton1
			// 
			clearButton1.AutoSize = true;
			clearButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			clearButton1.Location = new Point(39, 455);
			clearButton1.Name = "clearButton1";
			clearButton1.Size = new Size(113, 31);
			clearButton1.TabIndex = 17;
			clearButton1.Text = "Очистить";
			clearButton1.UseVisualStyleBackColor = true;
			clearButton1.Click += clearButton1_Click;
			// 
			// clearButton2
			// 
			clearButton2.AutoSize = true;
			clearButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			clearButton2.Location = new Point(315, 455);
			clearButton2.Name = "clearButton2";
			clearButton2.Size = new Size(113, 31);
			clearButton2.TabIndex = 18;
			clearButton2.Text = "Очистить";
			clearButton2.UseVisualStyleBackColor = true;
			clearButton2.Click += clearButton2_Click;
			// 
			// sortButton1
			// 
			sortButton1.AutoSize = true;
			sortButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			sortButton1.Location = new Point(39, 417);
			sortButton1.Name = "sortButton1";
			sortButton1.Size = new Size(113, 31);
			sortButton1.TabIndex = 21;
			sortButton1.Text = "Сортировать";
			sortButton1.UseVisualStyleBackColor = true;
			sortButton1.Click += sortButton1_Click;
			// 
			// sortButton2
			// 
			sortButton2.AutoSize = true;
			sortButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			sortButton2.Location = new Point(315, 417);
			sortButton2.Name = "sortButton2";
			sortButton2.Size = new Size(113, 31);
			sortButton2.TabIndex = 22;
			sortButton2.Text = "Сортировать";
			sortButton2.UseVisualStyleBackColor = true;
			sortButton2.Click += sortButton2_Click;
			// 
			// comboBox1
			// 
			comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "От А до Я", "От Я до А", "По длинне (возрастание)", "По длинне (убывание)" });
			comboBox1.Location = new Point(39, 76);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(126, 25);
			comboBox1.TabIndex = 23;
			comboBox1.Text = "Сортировка...";
			// 
			// comboBox2
			// 
			comboBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			comboBox2.FormattingEnabled = true;
			comboBox2.Items.AddRange(new object[] { "От А до Я", "От Я до А", "По длинне (возрастание)", "По длинне (убывание)" });
			comboBox2.Location = new Point(315, 76);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(128, 25);
			comboBox2.TabIndex = 24;
			comboBox2.Text = "Сортировка...";
			// 
			// searchInput
			// 
			searchInput.Location = new Point(39, 548);
			searchInput.Multiline = true;
			searchInput.Name = "searchInput";
			searchInput.Size = new Size(170, 23);
			searchInput.TabIndex = 25;
			searchInput.TextChanged += searchInput_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(39, 516);
			label4.Name = "label4";
			label4.Size = new Size(174, 20);
			label4.TabIndex = 27;
			label4.Text = "Введите искомое слово";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(39, 574);
			label5.Name = "label5";
			label5.Size = new Size(75, 20);
			label5.TabIndex = 29;
			label5.Text = "Результат";
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			checkBox1.Location = new Point(224, 628);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(87, 24);
			checkBox1.TabIndex = 31;
			checkBox1.Text = "Раздел 1";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			checkBox2.Location = new Point(224, 658);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(87, 24);
			checkBox2.TabIndex = 32;
			checkBox2.Text = "Раздел 2";
			checkBox2.UseVisualStyleBackColor = true;
			// 
			// searchResult
			// 
			searchResult.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			searchResult.FormattingEnabled = true;
			searchResult.ItemHeight = 20;
			searchResult.Location = new Point(39, 597);
			searchResult.Name = "searchResult";
			searchResult.Size = new Size(179, 124);
			searchResult.TabIndex = 33;
			// 
			// addButton
			// 
			addButton.AutoSize = true;
			addButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			addButton.Location = new Point(530, 224);
			addButton.Name = "addButton";
			addButton.Size = new Size(86, 30);
			addButton.TabIndex = 34;
			addButton.Text = "Добавить";
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += addButton_Click;
			// 
			// deleteButton
			// 
			deleteButton.AutoSize = true;
			deleteButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			deleteButton.Location = new Point(530, 270);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(86, 30);
			deleteButton.TabIndex = 35;
			deleteButton.Text = "Удалить";
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Click += deleteButton_Click;
			// 
			// searchButton
			// 
			searchButton.Location = new Point(355, 643);
			searchButton.Name = "searchButton";
			searchButton.Size = new Size(75, 23);
			searchButton.TabIndex = 36;
			searchButton.Text = "Поиск";
			searchButton.UseVisualStyleBackColor = true;
			searchButton.Click += searchButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1131, 735);
			Controls.Add(searchButton);
			Controls.Add(deleteButton);
			Controls.Add(addButton);
			Controls.Add(searchResult);
			Controls.Add(checkBox2);
			Controls.Add(checkBox1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(searchInput);
			Controls.Add(comboBox2);
			Controls.Add(comboBox1);
			Controls.Add(sortButton2);
			Controls.Add(sortButton1);
			Controls.Add(clearButton2);
			Controls.Add(clearButton1);
			Controls.Add(warningLabel);
			Controls.Add(moveAllToLeftButton);
			Controls.Add(moveAllToRightButton);
			Controls.Add(moveToLefyButton);
			Controls.Add(moveToRightButton);
			Controls.Add(section2);
			Controls.Add(section1);
			Controls.Add(startButton);
			Controls.Add(radio3);
			Controls.Add(radio2);
			Controls.Add(radio1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(mainTextBox);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem открытьToolStripMenuItem;
		private ToolStripMenuItem OpenFileButton;
		private TextBox mainTextBox;
		private Label label1;
		private Label label2;
		private RadioButton radio1;
		private RadioButton radio2;
		private RadioButton radio3;
		private Button startButton;
		public ListBox section1;
		public ListBox section2;
		private Button moveToRightButton;
		private Button moveToLefyButton;
		private Button moveAllToLeftButton;
		private Button moveAllToRightButton;
		private Label warningLabel;
		private Button clearButton1;
		private Button clearButton2;
		private Button sortButton1;
		private Button sortButton2;
		private ToolStripMenuItem saveButton;
		private ToolStripMenuItem exitButton;
		private ToolStripMenuItem resetButton;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private TextBox searchInput;
		private Label label4;
		private Label label5;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private ListBox searchResult;
		private Button addButton;
		private Button deleteButton;
		private Button searchButton;
	}
}