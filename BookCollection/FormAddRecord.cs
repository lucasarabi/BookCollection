using BookCollection.DatabaseClasses.Repositories;
using BookCollection.ObjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCollection
{
    public partial class FormAddRecord : Form
    {
        public FormAddRecord()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            InitializeComponent();

            DateAddedTimePicker.Value = DateTime.Now;
            PubDatePicker.Value = DateTime.Now;
            bookIDTextBox.Text = BookRepository.GetNextBookID();

        }

        private void AddRecord_Load(object sender, EventArgs e){}

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

            Book book = new Book()
            {
                Title = titleTextBox.Text,
                ISBN = isbnTextBox.Text,
                Author = authorTextBox.Text,
                PublishDate = DateTime.Parse(PubDatePicker.Text),
                DateAdded = DateTime.Parse(DateAddedTimePicker.Text),
                Publisher = publisherTextBox.Text,
                NumOfPages = int.Parse(numPagesTextBox.Text),
                BookID = bookIDTextBox.Text,
                quantity = int.Parse(quantTextBox.Text),
                Price = decimal.Parse(priceTextBox.Text),
                Genre = genreTextBox.Text,
                BookType = bookTypeTextBox.Text
            };

            BookRepository.Add(book);

            MessageBox.Show("Book Saved: " + book.Title);

            this.Close();
            
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addrecGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
