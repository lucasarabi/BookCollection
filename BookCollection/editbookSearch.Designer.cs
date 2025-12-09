namespace BookCollection
{
    partial class editbookSearch
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
            searchTextBox = new TextBox();
            searchLabel = new Label();
            searchButton = new Button();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(107, 51);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(217, 23);
            searchTextBox.TabIndex = 0;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(23, 54);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(78, 15);
            searchLabel.TabIndex = 1;
            searchLabel.Text = "Enter BookID:";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(129, 89);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // editbookSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 124);
            Controls.Add(searchButton);
            Controls.Add(searchLabel);
            Controls.Add(searchTextBox);
            Name = "editbookSearch";
            Text = "editbookSearch";
            Load += editbookSearch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private Label searchLabel;
        private Button searchButton;
    }
}