using System.Windows.Forms;

namespace BookCollection
{
    partial class FormAddEmployee
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
            exitButton = new Button();
            clearButton = new Button();
            saveButton = new Button();
            nameTextBox = new TextBox();
            birthdayDatePicker = new DateTimePicker();
            ageMaskedTextBox = new MaskedTextBox();
            payMaskedTextBox = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            employeeIdMaskedTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(186, 142);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(82, 32);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(98, 142);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(82, 32);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(10, 142);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(82, 32);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(77, 34);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.MaxLength = 50;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(191, 23);
            nameTextBox.TabIndex = 2;
            // 
            // birthdayDatePicker
            // 
            birthdayDatePicker.Format = DateTimePickerFormat.Short;
            birthdayDatePicker.Location = new Point(77, 82);
            birthdayDatePicker.Margin = new Padding(3, 2, 3, 2);
            birthdayDatePicker.Name = "birthdayDatePicker";
            birthdayDatePicker.Size = new Size(191, 23);
            birthdayDatePicker.TabIndex = 4;
            birthdayDatePicker.Value = new DateTime(2025, 11, 24, 15, 52, 25, 0);
            // 
            // ageMaskedTextBox
            // 
            ageMaskedTextBox.Location = new Point(77, 107);
            ageMaskedTextBox.Margin = new Padding(3, 2, 3, 2);
            ageMaskedTextBox.Mask = "000";
            ageMaskedTextBox.Name = "ageMaskedTextBox";
            ageMaskedTextBox.Size = new Size(191, 23);
            ageMaskedTextBox.TabIndex = 5;
            // 
            // payMaskedTextBox
            // 
            payMaskedTextBox.Location = new Point(77, 58);
            payMaskedTextBox.Margin = new Padding(3, 2, 3, 2);
            payMaskedTextBox.Mask = "000";
            payMaskedTextBox.Name = "payMaskedTextBox";
            payMaskedTextBox.Size = new Size(191, 23);
            payMaskedTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 24;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 11);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 25;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 61);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 26;
            label3.Text = "Pay:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 86);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 27;
            label4.Text = "Birthday:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 110);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 28;
            label5.Text = "Age:";
            // 
            // employeeIdMaskedTextBox
            // 
            employeeIdMaskedTextBox.Location = new Point(78, 9);
            employeeIdMaskedTextBox.Margin = new Padding(3, 2, 3, 2);
            employeeIdMaskedTextBox.Name = "employeeIdMaskedTextBox";
            employeeIdMaskedTextBox.ReadOnly = true;
            employeeIdMaskedTextBox.Size = new Size(191, 23);
            employeeIdMaskedTextBox.TabIndex = 1;
            // 
            // FormAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 183);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(payMaskedTextBox);
            Controls.Add(employeeIdMaskedTextBox);
            Controls.Add(ageMaskedTextBox);
            Controls.Add(birthdayDatePicker);
            Controls.Add(nameTextBox);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(saveButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddEmployee";
            Text = "Add Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button clearButton;
        private Button saveButton;
        private TextBox nameTextBox;
        private TextBox ageTextBox;
        private DateTimePicker birthdayDatePicker;
        private MaskedTextBox ageMaskedTextBox;
        private MaskedTextBox payMaskedTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox employeeIdMaskedTextBox;
    }
}