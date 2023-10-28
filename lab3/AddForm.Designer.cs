namespace lab3
{
	partial class AddForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			sectionBox1 = new CheckBox();
			sectionBox2 = new CheckBox();
			addButton = new Button();
			inputBox = new TextBox();
			label1 = new Label();
			cancelButton = new Button();
			warningLabel = new Label();
			SuspendLayout();
			// 
			// sectionBox1
			// 
			sectionBox1.AutoSize = true;
			sectionBox1.Location = new Point(61, 38);
			sectionBox1.Name = "sectionBox1";
			sectionBox1.Size = new Size(72, 19);
			sectionBox1.TabIndex = 0;
			sectionBox1.Text = "Раздел 1";
			sectionBox1.UseVisualStyleBackColor = true;
			// 
			// sectionBox2
			// 
			sectionBox2.AutoSize = true;
			sectionBox2.Location = new Point(61, 74);
			sectionBox2.Name = "sectionBox2";
			sectionBox2.Size = new Size(72, 19);
			sectionBox2.TabIndex = 1;
			sectionBox2.Text = "Раздел 2";
			sectionBox2.UseVisualStyleBackColor = true;
			// 
			// addButton
			// 
			addButton.AutoSize = true;
			addButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			addButton.Location = new Point(79, 192);
			addButton.Name = "addButton";
			addButton.Size = new Size(106, 35);
			addButton.TabIndex = 2;
			addButton.Text = "Добавить";
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += addButton_Click;
			// 
			// inputBox
			// 
			inputBox.Location = new Point(61, 151);
			inputBox.Name = "inputBox";
			inputBox.Size = new Size(302, 23);
			inputBox.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(61, 122);
			label1.Name = "label1";
			label1.Size = new Size(95, 15);
			label1.TabIndex = 4;
			label1.Text = "Введеите слово:";
			// 
			// cancelButton
			// 
			cancelButton.AutoSize = true;
			cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			cancelButton.Location = new Point(232, 192);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(106, 35);
			cancelButton.TabIndex = 5;
			cancelButton.Text = "Отмена";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// warningLabel
			// 
			warningLabel.AutoSize = true;
			warningLabel.ForeColor = Color.Red;
			warningLabel.Location = new Point(202, 38);
			warningLabel.Name = "warningLabel";
			warningLabel.Size = new Size(0, 15);
			warningLabel.TabIndex = 6;
			// 
			// AddForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(437, 258);
			Controls.Add(warningLabel);
			Controls.Add(cancelButton);
			Controls.Add(label1);
			Controls.Add(inputBox);
			Controls.Add(addButton);
			Controls.Add(sectionBox2);
			Controls.Add(sectionBox1);
			Name = "AddForm";
			Text = "AddForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckBox sectionBox1;
		private CheckBox sectionBox2;
		private Button addButton;
		private TextBox inputBox;
		private Label label1;
		private Button cancelButton;
		private Label warningLabel;
	}
}