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
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(233, 568);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fields";
            // 
            // adminButton
            // 
            adminButton.Location = new Point(67, 503);
            adminButton.Margin = new Padding(3, 4, 3, 4);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(86, 31);
            adminButton.TabIndex = 10;
            adminButton.Text = "ADMIN";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += adminButton_Click;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(viewCartBtn);
            groupBox2.Controls.Add(addToCartBtn);
            groupBox2.Controls.Add(resultsListView);
            groupBox2.Location = new Point(254, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(647, 568);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // viewCartBtn
            // 
            viewCartBtn.Location = new Point(421, 503);
            viewCartBtn.Margin = new Padding(3, 4, 3, 4);
            viewCartBtn.Name = "viewCartBtn";
            viewCartBtn.Size = new Size(219, 35);
            viewCartBtn.TabIndex = 11;
            viewCartBtn.Text = "View Cart";
            viewCartBtn.UseVisualStyleBackColor = true;
            viewCartBtn.Click += viewCartBtn_Click;
            // 
            // addToCartBtn
            // 
            addToCartBtn.Location = new Point(7, 503);
            addToCartBtn.Margin = new Padding(3, 4, 3, 4);
            addToCartBtn.Name = "addToCartBtn";
            addToCartBtn.Size = new Size(219, 35);
            addToCartBtn.TabIndex = 10;
            addToCartBtn.Text = "Add To Cart";
            addToCartBtn.UseVisualStyleBackColor = true;
            addToCartBtn.Click += addToCartBtn_Click;
            // 
            // resultsListView
            // 
            resultsListView.Location = new Point(7, 29);
            resultsListView.Margin = new Padding(3, 4, 3, 4);
            resultsListView.Name = "resultsListView";
            resultsListView.Size = new Size(633, 441);
            resultsListView.TabIndex = 0;
            resultsListView.UseCompatibleStateImageBehavior = false;
            // 
            // FormUserBookCollectionManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormUserBookCollectionManagement";
            Text = "Book Collection Management";
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
    }
}
