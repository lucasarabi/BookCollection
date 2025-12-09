namespace BookCollection
{
    partial class FormUserBookCollectionManagement
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
            groupBox1 = new GroupBox();
            adminButton = new Button();
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
            groupBox2 = new GroupBox();
            RefreshListButton = new Button();
            viewCartBtn = new Button();
            addToCartBtn = new Button();
            resultsListView = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(adminButton);
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
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fields";
            // 
            // adminButton
            // 
            adminButton.Location = new Point(59, 377);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(75, 23);
            adminButton.TabIndex = 10;
            adminButton.Text = "ADMIN";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += adminButton_Click;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(RefreshListButton);
            groupBox2.Controls.Add(viewCartBtn);
            groupBox2.Controls.Add(addToCartBtn);
            groupBox2.Controls.Add(resultsListView);
            groupBox2.Location = new Point(222, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(655, 413);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // RefreshListButton
            // 
            RefreshListButton.Font = new Font("Segoe UI", 15F);
            RefreshListButton.Location = new Point(604, 368);
            RefreshListButton.Name = "RefreshListButton";
            RefreshListButton.Size = new Size(35, 34);
            RefreshListButton.TabIndex = 12;
            RefreshListButton.Text = "🔄️";
            RefreshListButton.TextAlign = ContentAlignment.BottomCenter;
            RefreshListButton.UseVisualStyleBackColor = true;
            RefreshListButton.Click += RefreshListButton_Click;
            // 
            // viewCartBtn
            // 
            viewCartBtn.Location = new Point(336, 375);
            viewCartBtn.Name = "viewCartBtn";
            viewCartBtn.Size = new Size(192, 26);
            viewCartBtn.TabIndex = 11;
            viewCartBtn.Text = "View Cart";
            viewCartBtn.UseVisualStyleBackColor = true;
            viewCartBtn.Click += viewCartBtn_Click;
            // 
            // addToCartBtn
            // 
            addToCartBtn.Location = new Point(90, 373);
            addToCartBtn.Name = "addToCartBtn";
            addToCartBtn.Size = new Size(192, 26);
            addToCartBtn.TabIndex = 10;
            addToCartBtn.Text = "Add To Cart";
            addToCartBtn.UseVisualStyleBackColor = true;
            addToCartBtn.Click += addToCartBtn_Click;
            // 
            // resultsListView
            // 
            resultsListView.Location = new Point(6, 22);
            resultsListView.Name = "resultsListView";
            resultsListView.Size = new Size(633, 332);
            resultsListView.TabIndex = 0;
            resultsListView.UseCompatibleStateImageBehavior = false;
            resultsListView.SelectedIndexChanged += resultsListView_SelectedIndexChanged;
            // 
            // FormUserBookCollectionManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 445);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormUserBookCollectionManagement";
            Text = "Book Collection Management";
            Load += FormUserBookCollectionManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView resultsListView;
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
        private Button viewCartBtn;
        private Button addToCartBtn;
        private Button adminButton;
        private Button RefreshListButton;
    }
}
