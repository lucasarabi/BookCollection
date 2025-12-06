namespace BookCollection
{
    partial class FormAddRecord
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
            addrecGroupBox = new GroupBox();
            DateAddedTimePicker = new DateTimePicker();
            PubDatePicker = new DateTimePicker();
            bookTypeTextBox = new TextBox();
            bookTypeLabel = new Label();
            genreTextBox = new TextBox();
            genreLabel = new Label();
            priceTextBox = new TextBox();
            priceLabel = new Label();
            quantTextBox = new TextBox();
            quantLabel = new Label();
            bookIDTextBox = new TextBox();
            bookIDLabel = new Label();
            numPagesTextBox = new TextBox();
            numPagesLabel = new Label();
            publisherTextBox = new TextBox();
            publisherLabel = new Label();
            dateaddedLabel = new Label();
            publishLabel = new Label();
            authorTextBox = new TextBox();
            authorLabel = new Label();
            isbnTextBox = new TextBox();
            isbnLabel = new Label();
            titleTextBox = new TextBox();
            titleLabel = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            addrecGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // addrecGroupBox
            // 
            addrecGroupBox.Controls.Add(DateAddedTimePicker);
            addrecGroupBox.Controls.Add(PubDatePicker);
            addrecGroupBox.Controls.Add(bookTypeTextBox);
            addrecGroupBox.Controls.Add(bookTypeLabel);
            addrecGroupBox.Controls.Add(genreTextBox);
            addrecGroupBox.Controls.Add(genreLabel);
            addrecGroupBox.Controls.Add(priceTextBox);
            addrecGroupBox.Controls.Add(priceLabel);
            addrecGroupBox.Controls.Add(quantTextBox);
            addrecGroupBox.Controls.Add(quantLabel);
            addrecGroupBox.Controls.Add(bookIDTextBox);
            addrecGroupBox.Controls.Add(bookIDLabel);
            addrecGroupBox.Controls.Add(numPagesTextBox);
            addrecGroupBox.Controls.Add(numPagesLabel);
            addrecGroupBox.Controls.Add(publisherTextBox);
            addrecGroupBox.Controls.Add(publisherLabel);
            addrecGroupBox.Controls.Add(dateaddedLabel);
            addrecGroupBox.Controls.Add(publishLabel);
            addrecGroupBox.Controls.Add(authorTextBox);
            addrecGroupBox.Controls.Add(authorLabel);
            addrecGroupBox.Controls.Add(isbnTextBox);
            addrecGroupBox.Controls.Add(isbnLabel);
            addrecGroupBox.Controls.Add(titleTextBox);
            addrecGroupBox.Controls.Add(titleLabel);
            addrecGroupBox.Location = new Point(12, 12);
            addrecGroupBox.Name = "addrecGroupBox";
            addrecGroupBox.Size = new Size(445, 519);
            addrecGroupBox.TabIndex = 1;
            addrecGroupBox.TabStop = false;
            addrecGroupBox.Text = "Add Record";
            addrecGroupBox.Enter += addrecGroupBox_Enter;
            // 
            // DateAddedTimePicker
            // 
            DateAddedTimePicker.Format = DateTimePickerFormat.Short;
            DateAddedTimePicker.Location = new Point(109, 197);
            DateAddedTimePicker.Margin = new Padding(3, 2, 3, 2);
            DateAddedTimePicker.Name = "DateAddedTimePicker";
            DateAddedTimePicker.Size = new Size(299, 23);
            DateAddedTimePicker.TabIndex = 27;
            DateAddedTimePicker.Value = new DateTime(2025, 12, 5, 0, 0, 0, 0);
            // 
            // PubDatePicker
            // 
            PubDatePicker.Format = DateTimePickerFormat.Short;
            PubDatePicker.Location = new Point(109, 158);
            PubDatePicker.Margin = new Padding(3, 2, 3, 2);
            PubDatePicker.Name = "PubDatePicker";
            PubDatePicker.Size = new Size(299, 23);
            PubDatePicker.TabIndex = 25;
            PubDatePicker.Value = new DateTime(2025, 12, 5, 0, 0, 0, 0);
            // 
            // bookTypeTextBox
            // 
            bookTypeTextBox.Location = new Point(109, 464);
            bookTypeTextBox.Name = "bookTypeTextBox";
            bookTypeTextBox.Size = new Size(299, 23);
            bookTypeTextBox.TabIndex = 24;
            // 
            // bookTypeLabel
            // 
            bookTypeLabel.AutoSize = true;
            bookTypeLabel.Location = new Point(12, 464);
            bookTypeLabel.Name = "bookTypeLabel";
            bookTypeLabel.Size = new Size(65, 15);
            bookTypeLabel.TabIndex = 23;
            bookTypeLabel.Text = "Book Type:";
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(109, 422);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(299, 23);
            genreTextBox.TabIndex = 22;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(12, 425);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(41, 15);
            genreLabel.TabIndex = 21;
            genreLabel.Text = "Genre:";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(109, 384);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(299, 23);
            priceTextBox.TabIndex = 20;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(12, 387);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(36, 15);
            priceLabel.TabIndex = 19;
            priceLabel.Text = "Price:";
            // 
            // quantTextBox
            // 
            quantTextBox.Location = new Point(109, 346);
            quantTextBox.Name = "quantTextBox";
            quantTextBox.Size = new Size(299, 23);
            quantTextBox.TabIndex = 18;
            // 
            // quantLabel
            // 
            quantLabel.AutoSize = true;
            quantLabel.Location = new Point(12, 349);
            quantLabel.Name = "quantLabel";
            quantLabel.Size = new Size(56, 15);
            quantLabel.TabIndex = 17;
            quantLabel.Text = "Quantity:";
            // 
            // bookIDTextBox
            // 
            bookIDTextBox.Location = new Point(109, 308);
            bookIDTextBox.Name = "bookIDTextBox";
            bookIDTextBox.Size = new Size(299, 23);
            bookIDTextBox.TabIndex = 16;
            // 
            // bookIDLabel
            // 
            bookIDLabel.AutoSize = true;
            bookIDLabel.Location = new Point(12, 311);
            bookIDLabel.Name = "bookIDLabel";
            bookIDLabel.Size = new Size(51, 15);
            bookIDLabel.TabIndex = 15;
            bookIDLabel.Text = "Book ID:";
            // 
            // numPagesTextBox
            // 
            numPagesTextBox.Location = new Point(109, 270);
            numPagesTextBox.Name = "numPagesTextBox";
            numPagesTextBox.Size = new Size(299, 23);
            numPagesTextBox.TabIndex = 14;
            // 
            // numPagesLabel
            // 
            numPagesLabel.AutoSize = true;
            numPagesLabel.Location = new Point(12, 273);
            numPagesLabel.Name = "numPagesLabel";
            numPagesLabel.Size = new Size(85, 15);
            numPagesLabel.TabIndex = 13;
            numPagesLabel.Text = "Num of Pages:";
            // 
            // publisherTextBox
            // 
            publisherTextBox.Location = new Point(109, 232);
            publisherTextBox.Name = "publisherTextBox";
            publisherTextBox.Size = new Size(299, 23);
            publisherTextBox.TabIndex = 12;
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new Point(12, 235);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(59, 15);
            publisherLabel.TabIndex = 11;
            publisherLabel.Text = "Publisher:";
            // 
            // dateaddedLabel
            // 
            dateaddedLabel.AutoSize = true;
            dateaddedLabel.Location = new Point(12, 197);
            dateaddedLabel.Name = "dateaddedLabel";
            dateaddedLabel.Size = new Size(72, 15);
            dateaddedLabel.TabIndex = 9;
            dateaddedLabel.Text = "Date Added:";
            // 
            // publishLabel
            // 
            publishLabel.AutoSize = true;
            publishLabel.Location = new Point(12, 158);
            publishLabel.Name = "publishLabel";
            publishLabel.Size = new Size(76, 15);
            publishLabel.TabIndex = 7;
            publishLabel.Text = "Publish Date:";
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(109, 117);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(299, 23);
            authorTextBox.TabIndex = 6;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(12, 120);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(47, 15);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "Author:";
            // 
            // isbnTextBox
            // 
            isbnTextBox.Location = new Point(109, 78);
            isbnTextBox.Name = "isbnTextBox";
            isbnTextBox.Size = new Size(299, 23);
            isbnTextBox.TabIndex = 4;
            // 
            // isbnLabel
            // 
            isbnLabel.AutoSize = true;
            isbnLabel.Location = new Point(12, 81);
            isbnLabel.Name = "isbnLabel";
            isbnLabel.Size = new Size(35, 15);
            isbnLabel.TabIndex = 3;
            isbnLabel.Text = "ISBN:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(109, 38);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(299, 23);
            titleTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(12, 41);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(33, 15);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(55, 543);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 47);
            saveButton.TabIndex = 2;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(273, 543);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(120, 47);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // FormAddRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 602);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(addrecGroupBox);
            Name = "FormAddRecord";
            Text = "Add Record";
            Load += AddRecord_Load;
            addrecGroupBox.ResumeLayout(false);
            addrecGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox addrecGroupBox;
        private Label titleLabel;
        private TextBox bookTypeTextBox;
        private Label bookTypeLabel;
        private TextBox genreTextBox;
        private Label genreLabel;
        private TextBox priceTextBox;
        private Label priceLabel;
        private TextBox quantTextBox;
        private Label quantLabel;
        private TextBox bookIDTextBox;
        private Label bookIDLabel;
        private TextBox numPagesTextBox;
        private Label numPagesLabel;
        private TextBox publisherTextBox;
        private Label publisherLabel;
        private Label dateaddedLabel;
        private Label publishLabel;
        private TextBox authorTextBox;
        private Label authorLabel;
        private TextBox isbnTextBox;
        private Label isbnLabel;
        private TextBox titleTextBox;
        private Button saveButton;
        private Button cancelButton;
        private DateTimePicker PubDatePicker;
        private DateTimePicker DateAddedTimePicker;
    }
}