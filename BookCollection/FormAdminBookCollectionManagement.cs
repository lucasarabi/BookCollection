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
    public partial class FormAdminBookCollectionManagement : Form
    {
        public FormAdminBookCollectionManagement()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            InitializeComponent();
            // This is where the ListView Columns are cacaed
            resultsListView.FullRowSelect = true;
            resultsListView.GridLines = true;
            resultsListView.View = View.Details;
            resultsListView.Columns.Add("Book Name", 200, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Book ID", 80, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Author", 150, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Status", -2, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Quantity", 60, HorizontalAlignment.Left);

            LoadBooksFromDummyList();

        }

        private void LoadBooksFromDummyList()
        {
            resultsListView.Items.Clear();
            for (int i = 0; i < DummyGlobalInfo.ALL_BOOKS.Count; i++)
            {
                Book book = DummyGlobalInfo.ALL_BOOKS[i];
                ListViewItem item = new ListViewItem(book.Title);
                item.SubItems.Add(book.BookID);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.quantity > 0 ? "Available" : "Out of Stock");
                item.SubItems.Add(book.quantity.ToString());

                resultsListView.Items.Add(item);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            bookNameTxtBox.Clear();
            isbnTxtBox.Clear();
            authorNameTxtBox.Clear();
            bookIdTxtBox.Clear();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // DATABASE NEEDED
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            FormAddRecord addRecord = new FormAddRecord();
            addRecord.ShowDialog();
        }

        private void editRecordBtn_Click(object sender, EventArgs e)
        {
            FormEditRecord editRecord = new FormEditRecord();
            editRecord.ShowDialog();
        }

        private void deleteRecordBtn_Click(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (resultsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected item
            ListViewItem selectedItem = resultsListView.SelectedItems[0];

            // Get the BookID from the selected item (it's in the second column)
            string bookID = selectedItem.SubItems[1].Text;

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{selectedItem.Text}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Find and remove the book from the global list
                Book? bookToRemove = DummyGlobalInfo.ALL_BOOKS.FirstOrDefault(b => b.BookID == bookID);

                if (bookToRemove != null)
                {
                    DummyGlobalInfo.ALL_BOOKS.Remove(bookToRemove);

                    // Refresh the ListView
                    LoadBooksFromDummyList();

                    MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book not found in the collection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteAllRecordsBtn_Click(object sender, EventArgs e)
        {
            DummyGlobalInfo.ALL_BOOKS.Clear();
            LoadBooksFromDummyList();
        }

        private void OpenAdminDirectoryButton_Click(object sender, EventArgs e)
        {
            FormAdminDirectory adminDirectory = new FormAdminDirectory();
            adminDirectory.FormClosed += FormAdminBookCollectionManagement_ShowForm;
            this.Hide();
            adminDirectory.ShowDialog();
        }

        private void FormAdminBookCollectionManagement_ShowForm(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void FormAdminBookCollectionManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
