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
        List<Book> all_books = new List<Book>();
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

            LoadBooks();

        }

        private void LoadBooks()
        {
            all_books.Clear();
            all_books = BookRepository.GetAll();
            UpdateUI();
        }

        private void UpdateUI()
        {
            resultsListView.Items.Clear();


            for (int i = 0; i < all_books.Count; i++)
            {
                Book book = all_books[i];
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
            string searchText = bookNameTxtBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadBooks();
                return;
            }

            var sortedBooks = all_books
                .Select(book => new
                {
                    Book = book,
                    Score = CalculateSimilarity(book, searchText)
                })
                .OrderByDescending(x => x.Score)
                .Where(x => x.Score > 0)
                .Select(x => x.Book)
                .ToList();

            UpdateUI();
        }

        private int CalculateSimilarity(Book book, string searchText)
        {
            int score = 0;

            if (book.Title.ToLower() == searchText)
                score += 1000;

            string[] searchWords = searchText.Split(' ');
            string[] titleWords = book.Title.ToLower().Split(' ');

            foreach (string searchWord in searchWords)
            {
                foreach (string titleWord in titleWords)
                {
                    if (titleWord == searchWord)
                        score += 50;
                    else if (titleWord.StartsWith(searchWord))
                        score += 25;
                }
            }

            return score;
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            FormAddRecord addRecord = new FormAddRecord();
            addRecord.ShowDialog();
        }

        private void editRecordBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = resultsListView.SelectedItems[0];

            string bookID = selectedItem.SubItems[1].Text;
            Book? book = null;
            foreach(Book b in all_books){
                if(b.BookID == bookID)
                {
                    book = b;
                    break;
                }
            }
            if (book != null)
            {
                FormEditRecord editRecord = new FormEditRecord(book);
                editRecord.ShowDialog();
            }
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
                Book? bookToRemove = all_books.FirstOrDefault(b => b.BookID == bookID);

                if (bookToRemove != null)
                {
                    all_books.Remove(bookToRemove);
                    BookRepository.Delete(bookID);

                    // Refresh the ListView
                    LoadBooks();

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
            foreach (Book book in all_books)
            {
                BookRepository.Delete(book.BookID);
            }
            LoadBooks();
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
