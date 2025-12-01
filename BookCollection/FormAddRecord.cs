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

            if (string.IsNullOrWhiteSpace(pubDateTextBox.Text))
                pubDateTextBox.Text = "N/A";

            if (string.IsNullOrWhiteSpace(dateAddedTextBox.Text))
                dateAddedTextBox.Text = "N/A";

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
            $"Publish Date: {pubDateTextBox.Text}\n" +
            $"Date Added: {dateAddedTextBox.Text}\n" +
            $"Publisher: {publisherTextBox.Text}\n" +
            $"Num Pages: {numPagesTextBox.Text}\n" +
            $"Book ID: {bookIDTextBox.Text}\n" +
            $"Quantity: {quantTextBox.Text}\n" +
            $"Price: {priceTextBox.Text}\n" +
            $"Genre: {genreTextBox.Text}\n" +
            $"Book Type: {bookTypeTextBox.Text}");

            this.Close();

            
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel button clicked.");
            this.Close();
        }
    }
}
