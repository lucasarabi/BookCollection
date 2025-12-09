using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookCollection.DatabaseClasses.Repositories;
using BookCollection.ObjectClasses;

namespace BookCollection
{
    public partial class FormEditRecord : Form
    {
        Book book;
        public FormEditRecord(Book bookToEdit)
        {
            book = bookToEdit;
            this.StartPosition = FormStartPosition.Manual;

            int screenW = Screen.PrimaryScreen.WorkingArea.Width;
            int screenH = Screen.PrimaryScreen.WorkingArea.Height;

            int targetX = (int)(screenW * (2.0 / 3.0));
            int targetY = screenH / 2 - this.Height;

            this.Location = new Point(targetX, targetY);

            this.StartPosition = FormStartPosition.Manual;
            this.MaximizeBox = false;

            InitializeComponent();
        }

        private void EditRecord_Load(object sender, EventArgs e)
        {
            //Will be filled with BookObj Info. 
            titleTextBox.Text = book.Title;
            isbnTextBox.Text = book.ISBN;
            authorTextBox.Text = book.Author;
            PubDatePicker.Value = book.PublishDate;
            dateAddedTimePicker.Value = book.DateAdded;
            publisherTextBox.Text = book.Publisher;
            numPagesTextBox.Text = book.NumOfPages.ToString();
            bookIDTextBox.Text = book.BookID;
            quantTextBox.Text = book.quantity.ToString();
            priceTextBox.Text = book.Price.ToString();
            genreTextBox.Text = book.Genre;
            bookTypeTextBox.Text = book.BookType;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
                titleTextBox.Text = "N/A";

            if (string.IsNullOrWhiteSpace(isbnTextBox.Text))
                isbnTextBox.Text = "N/A";

            if (string.IsNullOrWhiteSpace(authorTextBox.Text))
                authorTextBox.Text = "N/A";

            if (string.IsNullOrWhiteSpace(publisherTextBox.Text))
                publisherTextBox.Text = "N/A";

            if (string.IsNullOrWhiteSpace(numPagesTextBox.Text))
                numPagesTextBox.Text = "0";

            if (string.IsNullOrWhiteSpace(bookIDTextBox.Text))
                bookIDTextBox.Text = "0";

            if (string.IsNullOrWhiteSpace(quantTextBox.Text))
                quantTextBox.Text = "0";

            if (string.IsNullOrWhiteSpace(priceTextBox.Text))
                priceTextBox.Text = "0.00";

            if (string.IsNullOrWhiteSpace(genreTextBox.Text))
                genreTextBox.Text = "N/A";

            if (string.IsNullOrWhiteSpace(bookTypeTextBox.Text))
                bookTypeTextBox.Text = "N/A";

            MessageBox.Show("SAVE clicked.\n\n" +
            $"Title: {titleTextBox.Text}\n" +
            $"ISBN: {isbnTextBox.Text}\n" +
            $"Author: {authorTextBox.Text}\n" +
            $"Publish Date: {PubDatePicker.Value}\n" +
            $"Date Added: {dateAddedTimePicker.Value}\n" +
            $"Publisher: {publisherTextBox.Text}\n" +
            $"Num Pages: {numPagesTextBox.Text}\n" +
            $"Book ID: {bookIDTextBox.Text}\n" +
            $"Quantity: {quantTextBox.Text}\n" +
            $"Price: {priceTextBox.Text}\n" +
            $"Genre: {genreTextBox.Text}\n" +
            $"Book Type: {bookTypeTextBox.Text}");

            book = new Book(
                titleTextBox.Text,                                  // title
                isbnTextBox.Text,                                   // ISBN
                authorTextBox.Text,                                 // author
                PubDatePicker.Value,                                // publishDate
                dateAddedTimePicker.Value,                          // dateAdded
                publisherTextBox.Text,                              // publisher
                int.Parse(numPagesTextBox.Text),                    // numOfPages
                bookIDTextBox.Text,                                 // bookID
                decimal.Parse(priceTextBox.Text),                   // price
                genreTextBox.Text,                                  // genre
                bookTypeTextBox.Text,                               // bookType
                int.Parse(quantTextBox.Text)                        // quantity
            );
            BookRepository.Update(book);

            this.Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel clicked.");
        }
    }
}
