namespace BookCollection
{
    partial class FormAddStore
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
            addressLabel = new Label();
            stateLabel = new Label();
            cityLabel = new Label();
            nameLabel = new Label();
            addressTextBox = new TextBox();
            stateTextBox = new TextBox();
            cityTextBox = new TextBox();
            nameTextBox = new TextBox();
            zipTextBox = new TextBox();
            zipLabel = new Label();
            saveButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(15, 18);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(52, 15);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(32, 68);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(36, 15);
            stateLabel.TabIndex = 1;
            stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(39, 43);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(31, 15);
            cityLabel.TabIndex = 2;
            cityLabel.Text = "City:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(26, 117);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(77, 16);
            addressTextBox.Margin = new Padding(3, 2, 3, 2);
            addressTextBox.MaxLength = 50;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(191, 23);
            addressTextBox.TabIndex = 4;
            // 
            // stateTextBox
            // 
            stateTextBox.Location = new Point(77, 65);
            stateTextBox.Margin = new Padding(3, 2, 3, 2);
            stateTextBox.MaxLength = 15;
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(191, 23);
            stateTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(77, 40);
            cityTextBox.Margin = new Padding(3, 2, 3, 2);
            cityTextBox.MaxLength = 25;
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(191, 23);
            cityTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(77, 115);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.MaxLength = 25;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(191, 23);
            nameTextBox.TabIndex = 7;
            // 
            // zipTextBox
            // 
            zipTextBox.Location = new Point(77, 90);
            zipTextBox.Margin = new Padding(3, 2, 3, 2);
            zipTextBox.MaxLength = 15;
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(191, 23);
            zipTextBox.TabIndex = 9;
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new Point(8, 92);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new Size(58, 15);
            zipLabel.TabIndex = 8;
            zipLabel.Text = "Zip Code:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(10, 146);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(82, 32);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(98, 146);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(82, 32);
            clearButton.TabIndex = 11;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(186, 146);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(82, 32);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // FormAddStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 188);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(saveButton);
            Controls.Add(zipTextBox);
            Controls.Add(zipLabel);
            Controls.Add(nameTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(stateTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(nameLabel);
            Controls.Add(cityLabel);
            Controls.Add(stateLabel);
            Controls.Add(addressLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddStore";
            Text = "Add Store";
            Load += FormAddStore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addressLabel;
        private Label stateLabel;
        private Label cityLabel;
        private Label nameLabel;
        private TextBox addressTextBox;
        private TextBox stateTextBox;
        private TextBox cityTextBox;
        private TextBox nameTextBox;
        private TextBox zipTextBox;
        private Label zipLabel;
        private Button saveButton;
        private Button clearButton;
        private Button exitButton;
    }
}