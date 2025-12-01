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
            addressLabel.Location = new Point(17, 24);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(65, 20);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(36, 90);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(46, 20);
            stateLabel.TabIndex = 1;
            stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(45, 57);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(37, 20);
            cityLabel.TabIndex = 2;
            cityLabel.Text = "City:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(30, 156);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(88, 21);
            addressTextBox.MaxLength = 50;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(218, 27);
            addressTextBox.TabIndex = 4;
            // 
            // stateTextBox
            // 
            stateTextBox.Location = new Point(88, 87);
            stateTextBox.MaxLength = 15;
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(218, 27);
            stateTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(88, 54);
            cityTextBox.MaxLength = 25;
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(218, 27);
            cityTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(88, 153);
            nameTextBox.MaxLength = 25;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(218, 27);
            nameTextBox.TabIndex = 7;
            // 
            // zipTextBox
            // 
            zipTextBox.Location = new Point(88, 120);
            zipTextBox.MaxLength = 15;
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(218, 27);
            zipTextBox.TabIndex = 9;
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new Point(9, 123);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new Size(73, 20);
            zipLabel.TabIndex = 8;
            zipLabel.Text = "Zip Code:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 195);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 43);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(112, 195);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 43);
            clearButton.TabIndex = 11;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(212, 195);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 43);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // FormAddStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 250);
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
            Name = "FormAddStore";
            Text = "Add Store";
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