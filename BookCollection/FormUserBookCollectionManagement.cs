using BookCollection.ObjectClasses;
using System.Linq;

namespace BookCollection
{
    public partial class FormUserBookCollectionManagement : Form
    {
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
            FormShoppingCart shoppingCart = new FormShoppingCart();
            shoppingCart.ShowDialog(this);
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

            // If the book is already in the cart, increase quantity
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

            MessageBox.Show($"{selectedBook.Title} has been added to your cart!",
                   "Item Added",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //DATABASE NEEDED 
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            FormAdminBookCollectionManagement adminPage = new FormAdminBookCollectionManagement();
            adminPage.FormClosed += AdminPage_FormClosed;
            this.Hide();
            adminPage.ShowDialog();

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
