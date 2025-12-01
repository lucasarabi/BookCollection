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
            employeeIdMaskedTextBox = new MaskedTextBox();
            payMaskedTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(212, 190);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 43);
            exitButton.TabIndex = 15;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(112, 190);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 43);
            clearButton.TabIndex = 14;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 190);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 43);
            saveButton.TabIndex = 13;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(88, 12);
            nameTextBox.MaxLength = 50;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(218, 27);
            nameTextBox.TabIndex = 16;
            // 
            // birthdayDatePicker
            // 
            birthdayDatePicker.Format = DateTimePickerFormat.Short;
            birthdayDatePicker.Location = new Point(88, 110);
            birthdayDatePicker.Name = "birthdayDatePicker";
            birthdayDatePicker.Size = new Size(218, 27);
            birthdayDatePicker.TabIndex = 20;
            birthdayDatePicker.Value = new DateTime(2025, 11, 24, 15, 52, 25, 0);
            // 
            // ageMaskedTextBox
            // 
            ageMaskedTextBox.Location = new Point(88, 143);
            ageMaskedTextBox.Mask = "000";
            ageMaskedTextBox.Name = "ageMaskedTextBox";
            ageMaskedTextBox.Size = new Size(218, 27);
            ageMaskedTextBox.TabIndex = 21;
            // 
            // employeeIdMaskedTextBox
            // 
            employeeIdMaskedTextBox.Location = new Point(88, 45);
            employeeIdMaskedTextBox.Mask = "000000000";
            employeeIdMaskedTextBox.Name = "employeeIdMaskedTextBox";
            employeeIdMaskedTextBox.Size = new Size(218, 27);
            employeeIdMaskedTextBox.TabIndex = 22;
            // 
            // payMaskedTextBox
            // 
            payMaskedTextBox.Location = new Point(88, 78);
            payMaskedTextBox.Mask = "000";
            payMaskedTextBox.Name = "payMaskedTextBox";
            payMaskedTextBox.Size = new Size(218, 27);
            payMaskedTextBox.TabIndex = 23;
            // 
            // FormAddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 244);
            Controls.Add(payMaskedTextBox);
            Controls.Add(employeeIdMaskedTextBox);
            Controls.Add(ageMaskedTextBox);
            Controls.Add(birthdayDatePicker);
            Controls.Add(nameTextBox);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(saveButton);
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
        private MaskedTextBox employeeIdMaskedTextBox;
        private MaskedTextBox payMaskedTextBox;
    }
}