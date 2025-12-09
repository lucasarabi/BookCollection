using BookCollection.DatabaseClasses.Repositories;
using BookCollection.ObjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCollection
{
    public partial class FormEditRecord : Form
    {
        private Book? currBook;

        public FormEditRecord()
        {
            this.StartPosition = FormStartPosition.Manual;

            int screenW = Screen.PrimaryScreen.WorkingArea.Width;
            int screenH = Screen.PrimaryScreen.WorkingArea.Height;

            int targetX = (int)(screenW * (2.0 / 3.0));
            int targetY = screenH / 2 - this.Height;

            this.Location = new Point(targetX, targetY);

            this.StartPosition = FormStartPosition.Manual;
            this.MaximizeBox = false;

            InitializeComponent();

            string id = bookIDTextBox.Text;

            currBook = BookRepository.GetById(id);

        }

        private void EditRecord_Load(object sender, EventArgs e)
        {
            titleTextBox.Text = currBook.Title;
            isbnTextBox.Text = currBook.ISBN;
            authorTextBox.Text = currBook.Author;
            PubDatePicker.Text = currBook.PublishDate.ToString();
            dateAddedTimePicker.Text = currBook.DateAdded.ToString();
            publisherTextBox.Text = currBook.Publisher;
            numPagesTextBox.Text = currBook.NumOfPages.ToString();
            bookIDTextBox.Text = currBook.BookID;
            quantTextBox.Text = currBook.quantity.ToString();
            priceTextBox.Text = currBook.Price.ToString();
            genreTextBox.Text = currBook.Genre;
            bookTypeTextBox.Text = currBook.BookType;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) ||
                string.IsNullOrWhiteSpace(isbnTextBox.Text) ||
                string.IsNullOrWhiteSpace(authorTextBox.Text) ||
                string.IsNullOrWhiteSpace(publisherTextBox.Text) ||
                string.IsNullOrWhiteSpace(numPagesTextBox.Text) ||
                string.IsNullOrWhiteSpace(bookIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(quantTextBox.Text) ||
                string.IsNullOrWhiteSpace(priceTextBox.Text) ||
                string.IsNullOrWhiteSpace(genreTextBox.Text) ||
                string.IsNullOrWhiteSpace(bookTypeTextBox.Text))

            {
                MessageBox.Show("Please fill in all required fields.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            Book updatedBook = new Book()
            {
                Title = titleTextBox.Text,
                ISBN = isbnTextBox.Text,
                Author = authorTextBox.Text,
                PublishDate = DateTime.Parse(PubDatePicker.Text),
                DateAdded = DateTime.Parse(dateAddedTimePicker.Text),
                Publisher = publisherTextBox.Text,
                NumOfPages = int.Parse(numPagesTextBox.Text),
                BookID = bookIDTextBox.Text,
                quantity = int.Parse(quantTextBox.Text),
                Price = decimal.Parse(priceTextBox.Text),
                Genre = genreTextBox.Text,
                BookType = bookTypeTextBox.Text
            };

            MessageBox.Show("Book Edited: " + updatedBook.Title);

            BookRepository.Update(updatedBook);

            this.Close();

            
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel clicked.");
        }
    }
}
