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
            groupBox2.Controls.Add(deleteAllRecordsBtn);
            groupBox2.Controls.Add(deleteRecordBtn);
            groupBox2.Controls.Add(editRecordBtn);
            groupBox2.Controls.Add(addRecordBtn);
            groupBox2.Controls.Add(resultsListView);
            groupBox2.Location = new Point(254, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(647, 568);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Admin Panel";
            // 
            // deleteAllRecordsBtn
            // 
            deleteAllRecordsBtn.Location = new Point(498, 36);
            deleteAllRecordsBtn.Margin = new Padding(3, 4, 3, 4);
            deleteAllRecordsBtn.Name = "deleteAllRecordsBtn";
            deleteAllRecordsBtn.Size = new Size(142, 84);
            deleteAllRecordsBtn.TabIndex = 4;
            deleteAllRecordsBtn.Text = "Delete All Records";
            deleteAllRecordsBtn.UseVisualStyleBackColor = true;
            deleteAllRecordsBtn.Click += deleteAllRecordsBtn_Click;
            // 
            // deleteRecordBtn
            // 
            deleteRecordBtn.Location = new Point(338, 37);
            deleteRecordBtn.Margin = new Padding(3, 4, 3, 4);
            deleteRecordBtn.Name = "deleteRecordBtn";
            deleteRecordBtn.Size = new Size(142, 84);
            deleteRecordBtn.TabIndex = 3;
            deleteRecordBtn.Text = "Delete Record";
            deleteRecordBtn.UseVisualStyleBackColor = true;
            deleteRecordBtn.Click += deleteRecordBtn_Click;
            // 
            // editRecordBtn
            // 
            editRecordBtn.Location = new Point(173, 37);
            editRecordBtn.Margin = new Padding(3, 4, 3, 4);
            editRecordBtn.Name = "editRecordBtn";
            editRecordBtn.Size = new Size(142, 84);
            editRecordBtn.TabIndex = 2;
            editRecordBtn.Text = "Edit Record";
            editRecordBtn.UseVisualStyleBackColor = true;
            editRecordBtn.Click += editRecordBtn_Click;
            // 
            // addRecordBtn
            // 
            addRecordBtn.Location = new Point(7, 36);
            addRecordBtn.Margin = new Padding(3, 4, 3, 4);
            addRecordBtn.Name = "addRecordBtn";
            addRecordBtn.Size = new Size(142, 84);
            addRecordBtn.TabIndex = 1;
            addRecordBtn.Text = "Add Record";
            addRecordBtn.UseVisualStyleBackColor = true;
            addRecordBtn.Click += addRecordBtn_Click;
            // 
            // resultsListView
            // 
            resultsListView.Location = new Point(7, 140);
            resultsListView.Margin = new Padding(3, 4, 3, 4);
            resultsListView.Name = "resultsListView";
            resultsListView.Size = new Size(633, 419);
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
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(233, 568);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fields";
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(7, 395);
            clearBtn.Margin = new Padding(3, 4, 3, 4);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(219, 35);
            clearBtn.TabIndex = 9;
            clearBtn.Text = "Clear Fields";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(7, 297);
            searchBtn.Margin = new Padding(3, 4, 3, 4);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(219, 57);
            searchBtn.TabIndex = 8;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // bookIdTxtBox
            // 
            bookIdTxtBox.Location = new Point(7, 241);
            bookIdTxtBox.Margin = new Padding(3, 4, 3, 4);
            bookIdTxtBox.Name = "bookIdTxtBox";
            bookIdTxtBox.Size = new Size(219, 27);
            bookIdTxtBox.TabIndex = 7;
            // 
            // authorNameTxtBox
            // 
            authorNameTxtBox.Location = new Point(7, 183);
            authorNameTxtBox.Margin = new Padding(3, 4, 3, 4);
            authorNameTxtBox.Name = "authorNameTxtBox";
            authorNameTxtBox.Size = new Size(219, 27);
            authorNameTxtBox.TabIndex = 6;
            // 
            // isbnTxtBox
            // 
            isbnTxtBox.Location = new Point(7, 124);
            isbnTxtBox.Margin = new Padding(3, 4, 3, 4);
            isbnTxtBox.Name = "isbnTxtBox";
            isbnTxtBox.Size = new Size(219, 27);
            isbnTxtBox.TabIndex = 5;
            // 
            // bookNameTxtBox
            // 
            bookNameTxtBox.Location = new Point(7, 65);
            bookNameTxtBox.Margin = new Padding(3, 4, 3, 4);
            bookNameTxtBox.Name = "bookNameTxtBox";
            bookNameTxtBox.Size = new Size(219, 27);
            bookNameTxtBox.TabIndex = 1;
            // 
            // bookIDLabel
            // 
            bookIDLabel.AutoSize = true;
            bookIDLabel.Location = new Point(7, 217);
            bookIDLabel.Name = "bookIDLabel";
            bookIDLabel.Size = new Size(65, 20);
            bookIDLabel.TabIndex = 4;
            bookIDLabel.Text = "Book ID:";
            // 
            // authorNameLabel
            // 
            authorNameLabel.AutoSize = true;
            authorNameLabel.Location = new Point(7, 159);
            authorNameLabel.Name = "authorNameLabel";
            authorNameLabel.Size = new Size(101, 20);
            authorNameLabel.TabIndex = 3;
            authorNameLabel.Text = "Author Name:";
            // 
            // isbnLabel
            // 
            isbnLabel.AutoSize = true;
            isbnLabel.Location = new Point(7, 100);
            isbnLabel.Name = "isbnLabel";
            isbnLabel.Size = new Size(44, 20);
            isbnLabel.TabIndex = 2;
            isbnLabel.Text = "ISBN:";
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new Point(7, 41);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new Size(90, 20);
            bookNameLabel.TabIndex = 1;
            bookNameLabel.Text = "Book Name:";
            // 
            // FormAdminBookCollectionManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdminBookCollectionManagement";
            Text = "AdminBookCollectionManagement";
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
    }
}