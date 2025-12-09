using BookCollection.DatabaseClasses.Repositories;
using BookCollection.ObjectClasses;
using System.Linq;

namespace BookCollection
{
    public partial class FormUserBookCollectionManagement : Form
    {
        List<Book> all_books = new List<Book>();
        public FormUserBookCollectionManagement()
        {
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

            //Locks Column Resizing
            resultsListView.ColumnWidthChanging += ResultsListView_ColumnWidthChanging;

            // This is where the ListView Columns are cacaed
            resultsListView.FullRowSelect = true;
            resultsListView.GridLines = true;
            resultsListView.View = View.Details;
            resultsListView.Columns.Add("Book Name", 200, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Book ID", 80, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Author", 150, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Status", -2, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Quantity", 60, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Price", 80, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Genre", 80, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Book Type", 60, HorizontalAlignment.Left);


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
                item.SubItems.Add(book.Price.ToString("C"));
                item.SubItems.Add(book.Genre.ToString());
                item.SubItems.Add(book.BookType.ToString());

                item.Tag = book;

                resultsListView.Items.Add(item);
            }
        }

        private void ResultsListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = resultsListView.Columns[e.ColumnIndex].Width;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            bookNameTxtBox.Clear();
            isbnTxtBox.Clear();
            authorNameTxtBox.Clear();
            bookIdTxtBox.Clear();
        }

        private void viewCartBtn_Click(object sender, EventArgs e)
        {
            using (FormShoppingCart shoppingCart = new FormShoppingCart())
            {
                shoppingCart.ShowDialog(this);
            }

            UpdateUI();
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            if (resultsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a book from the results first.");
                return;
            }

            // get the selected row
            var selectedItem = resultsListView.SelectedItems[0];

            // get the Book object we stored in Tag
            if (selectedItem.Tag is not Book selectedBook)
            {
                MessageBox.Show("Unable to get selected book.");
                return;
            }

            if (selectedBook.quantity <= 0)
            {
                MessageBox.Show("No more copies of this book are available.",
                                "Out of Stock",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            var existing = DummyGlobalInfo.CURRENT_CART
                .FirstOrDefault(ci => ci.Book.BookID == selectedBook.BookID);

            if (existing != null)
            {
                existing.Quantity += 1;
            }
            else
            {
                DummyGlobalInfo.CURRENT_CART.Add(new CartItem(selectedBook, 1));
            }

            selectedBook.quantity--;
            selectedItem.SubItems[3].Text = selectedBook.quantity > 0 ? "Available" : "Out of Stock";
            selectedItem.SubItems[4].Text = selectedBook.quantity.ToString();

            MessageBox.Show($"{selectedBook.Title} has been added to your cart!",
                            "Item Added",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
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

        private void adminButton_Click(object sender, EventArgs e)
        {
            FormAdminBookCollectionManagement adminPage = new FormAdminBookCollectionManagement();
            adminPage.FormClosed += AdminPage_FormClosed;
            this.Hide();
            adminPage.ShowDialog();

        }

        private void LoadUserBooks()
        {
            resultsListView.Items.Clear();

            List<Book> books = BookRepository.GetAll();

            foreach (var book in books)
            {
                ListViewItem item = new ListViewItem(book.Title);
                item.SubItems.Add(book.BookID);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.quantity > 0 ? "Available" : "Out of Stock");
                item.SubItems.Add(book.quantity.ToString());
                resultsListView.Items.Add(item);
            }
        }
        private void RefreshListButton_Click(object sender, EventArgs e)
        {
            LoadUserBooks();
        }

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();

        }

        private void FormUserBookCollectionManagement_Load(object sender, EventArgs e)
        {

        }

        private void resultsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
