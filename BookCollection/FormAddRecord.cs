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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCollection
{
    public partial class FormAddRecord : Form
    {
        public FormAddRecord()
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
            MessageBox.Show("Cancel button clicked.");
            this.Close();
        }

        private void addrecGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
