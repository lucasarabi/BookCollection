namespace BookCollection
{
    partial class FormAdminBookCollectionManagement
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
            groupBox2 = new GroupBox();
            OpenAdminDirectoryButton = new Button();
            deleteAllRecordsBtn = new Button();
            deleteRecordBtn = new Button();
            editRecordBtn = new Button();
            addRecordBtn = new Button();
            resultsListView = new ListView();
            groupBox1 = new GroupBox();
            clearBtn = new Button();
            searchBtn = new Button();
            bookIdTxtBox = new TextBox();
            authorNameTxtBox = new TextBox();
            isbnTxtBox = new TextBox();
            bookNameTxtBox = new TextBox();
            bookIDLabel = new Label();
            authorNameLabel = new Label();
            isbnLabel = new Label();
            bookNameLabel = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(OpenAdminDirectoryButton);
            groupBox2.Controls.Add(deleteAllRecordsBtn);
            groupBox2.Controls.Add(deleteRecordBtn);
            groupBox2.Controls.Add(editRecordBtn);
            groupBox2.Controls.Add(addRecordBtn);
            groupBox2.Controls.Add(resultsListView);
            groupBox2.Location = new Point(222, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(566, 426);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Admin Panel";
            // 
            // OpenAdminDirectoryButton
            // 
            OpenAdminDirectoryButton.Location = new Point(436, 27);
            OpenAdminDirectoryButton.Name = "OpenAdminDirectoryButton";
            OpenAdminDirectoryButton.Size = new Size(124, 63);
            OpenAdminDirectoryButton.TabIndex = 5;
            OpenAdminDirectoryButton.Text = "Admin Directory";
            OpenAdminDirectoryButton.UseVisualStyleBackColor = true;
            OpenAdminDirectoryButton.Click += OpenAdminDirectoryButton_Click;
            // 
            // deleteAllRecordsBtn
            // 
            deleteAllRecordsBtn.Location = new Point(296, 62);
            deleteAllRecordsBtn.Name = "deleteAllRecordsBtn";
            deleteAllRecordsBtn.Size = new Size(124, 28);
            deleteAllRecordsBtn.TabIndex = 4;
            deleteAllRecordsBtn.Text = "Delete All Records";
            deleteAllRecordsBtn.UseVisualStyleBackColor = true;
            deleteAllRecordsBtn.Click += deleteAllRecordsBtn_Click;
            // 
            // deleteRecordBtn
            // 
            deleteRecordBtn.Location = new Point(296, 28);
            deleteRecordBtn.Name = "deleteRecordBtn";
            deleteRecordBtn.Size = new Size(124, 29);
            deleteRecordBtn.TabIndex = 3;
            deleteRecordBtn.Text = "Delete Record";
            deleteRecordBtn.UseVisualStyleBackColor = true;
            deleteRecordBtn.Click += deleteRecordBtn_Click;
            // 
            // editRecordBtn
            // 
            editRecordBtn.Location = new Point(151, 28);
            editRecordBtn.Name = "editRecordBtn";
            editRecordBtn.Size = new Size(124, 63);
            editRecordBtn.TabIndex = 2;
            editRecordBtn.Text = "Edit Record";
            editRecordBtn.UseVisualStyleBackColor = true;
            editRecordBtn.Click += editRecordBtn_Click;
            // 
            // addRecordBtn
            // 
            addRecordBtn.Location = new Point(6, 27);
            addRecordBtn.Name = "addRecordBtn";
            addRecordBtn.Size = new Size(124, 63);
            addRecordBtn.TabIndex = 1;
            addRecordBtn.Text = "Add Record";
            addRecordBtn.UseVisualStyleBackColor = true;
            addRecordBtn.Click += addRecordBtn_Click;
            // 
            // resultsListView
            // 
            resultsListView.Location = new Point(6, 105);
            resultsListView.Name = "resultsListView";
            resultsListView.Size = new Size(554, 315);
            resultsListView.TabIndex = 0;
            resultsListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clearBtn);
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Controls.Add(bookIdTxtBox);
            groupBox1.Controls.Add(authorNameTxtBox);
            groupBox1.Controls.Add(isbnTxtBox);
            groupBox1.Controls.Add(bookNameTxtBox);
            groupBox1.Controls.Add(bookIDLabel);
            groupBox1.Controls.Add(authorNameLabel);
            groupBox1.Controls.Add(isbnLabel);
            groupBox1.Controls.Add(bookNameLabel);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 426);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fields";
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(6, 296);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(192, 26);
            clearBtn.TabIndex = 9;
            clearBtn.Text = "Clear Fields";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(6, 223);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(192, 43);
            searchBtn.TabIndex = 8;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // bookIdTxtBox
            // 
            bookIdTxtBox.Location = new Point(6, 181);
            bookIdTxtBox.Name = "bookIdTxtBox";
            bookIdTxtBox.Size = new Size(192, 23);
            bookIdTxtBox.TabIndex = 7;
            // 
            // authorNameTxtBox
            // 
            authorNameTxtBox.Location = new Point(6, 137);
            authorNameTxtBox.Name = "authorNameTxtBox";
            authorNameTxtBox.Size = new Size(192, 23);
            authorNameTxtBox.TabIndex = 6;
            // 
            // isbnTxtBox
            // 
            isbnTxtBox.Location = new Point(6, 93);
            isbnTxtBox.Name = "isbnTxtBox";
            isbnTxtBox.Size = new Size(192, 23);
            isbnTxtBox.TabIndex = 5;
            // 
            // bookNameTxtBox
            // 
            bookNameTxtBox.Location = new Point(6, 49);
            bookNameTxtBox.Name = "bookNameTxtBox";
            bookNameTxtBox.Size = new Size(192, 23);
            bookNameTxtBox.TabIndex = 1;
            // 
            // bookIDLabel
            // 
            bookIDLabel.AutoSize = true;
            bookIDLabel.Location = new Point(6, 163);
            bookIDLabel.Name = "bookIDLabel";
            bookIDLabel.Size = new Size(51, 15);
            bookIDLabel.TabIndex = 4;
            bookIDLabel.Text = "Book ID:";
            // 
            // authorNameLabel
            // 
            authorNameLabel.AutoSize = true;
            authorNameLabel.Location = new Point(6, 119);
            authorNameLabel.Name = "authorNameLabel";
            authorNameLabel.Size = new Size(82, 15);
            authorNameLabel.TabIndex = 3;
            authorNameLabel.Text = "Author Name:";
            // 
            // isbnLabel
            // 
            isbnLabel.AutoSize = true;
            isbnLabel.Location = new Point(6, 75);
            isbnLabel.Name = "isbnLabel";
            isbnLabel.Size = new Size(35, 15);
            isbnLabel.TabIndex = 2;
            isbnLabel.Text = "ISBN:";
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new Point(6, 31);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new Size(72, 15);
            bookNameLabel.TabIndex = 1;
            bookNameLabel.Text = "Book Name:";
            // 
            // FormAdminBookCollectionManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormAdminBookCollectionManagement";
            Text = "AdminBookCollectionManagement";
            Load += FormAdminBookCollectionManagement_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button deleteAllRecordsBtn;
        private Button deleteRecordBtn;
        private Button editRecordBtn;
        private Button addRecordBtn;
        private ListView resultsListView;
        private GroupBox groupBox1;
        private Button clearBtn;
        private Button searchBtn;
        private TextBox bookIdTxtBox;
        private TextBox authorNameTxtBox;
        private TextBox isbnTxtBox;
        private TextBox bookNameTxtBox;
        private Label bookIDLabel;
        private Label authorNameLabel;
        private Label isbnLabel;
        private Label bookNameLabel;
        private Button OpenAdminDirectoryButton;
    }
}