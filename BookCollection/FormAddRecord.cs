using BookCollection.ObjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void AddRecord_Load(object sender, EventArgs e)
        {

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

            /*
            
            MessageBox.Show("SAVE clicked.\n\n" +
            $"Title: {titleTextBox.Text}\n" +
            $"ISBN: {isbnTextBox.Text}\n" +
            $"Author: {authorTextBox.Text}\n" +
            $"Publish Date: {PubDatePicker.Text}\n" +
            $"Date Added: {DateAddedTimePicker.Text}\n" +
            $"Publisher: {publisherTextBox.Text}\n" +
            $"Num Pages: {numPagesTextBox.Text}\n" +
            $"Book ID: {bookIDTextBox.Text}\n" +
            $"Quantity: {quantTextBox.Text}\n" +
            $"Price: {priceTextBox.Text}\n" +
            $"Genre: {genreTextBox.Text}\n" +
            $"Book Type: {bookTypeTextBox.Text}");

            */

            this.Close();

            Book newBook = new Book
            {
                Title = titleTextBox.Text,
                ISBN = isbnTextBox.Text,
                Author = authorTextBox.Text,
                PublishDate = PubDatePicker.Value,
                DateAdded = DateAddedTimePicker.Value,
                Publisher = publisherTextBox.Text,
                NumOfPages = int.Parse(numPagesTextBox.Text),
                BookID = bookIDTextBox.Text,
                Price = decimal.Parse(priceTextBox.Text),
                Genre = genreTextBox.Text,
                BookType = bookTypeTextBox.Text,
                quantity = int.Parse(quantTextBox.Text)

            };

            for (int i = 0; i < DummyGlobalInfo.ALL_BOOKS.Count; i++)
            {
                if (DummyGlobalInfo.ALL_BOOKS[i].ISBN.Equals(newBook.ISBN))
                {
                    DummyGlobalInfo.ALL_BOOKS[i].quantity += newBook.quantity;
                    return;
                }
            }
            DummyGlobalInfo.ALL_BOOKS.Add(newBook);
            Close();
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
