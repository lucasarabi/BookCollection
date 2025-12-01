using BookCollection.ObjectClasses;

namespace BookCollection
{
    public partial class FormUserBookCollectionManagement : Form
    {
        public FormUserBookCollectionManagement()
        {
            InitializeComponent();

            // This is where the ListView Columns are cacaed
            resultsListView.FullRowSelect = true;
            resultsListView.GridLines = true;
            resultsListView.View = View.Details;
            resultsListView.Columns.Add("Book Name", -2, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Book ID", -2, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Author", -2, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Status", -2, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Quantity", -2, HorizontalAlignment.Left);
            resultsListView.Columns.Add("Count", -2, HorizontalAlignment.Left);

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

        private void viewCartBtn_Click(object sender, EventArgs e)
        {
            FormShoppingCart shoppingCart = new FormShoppingCart();
            shoppingCart.ShowDialog(this);
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            DummyGlobalInfo.CURRENT_CART.Add(new CartItem(
                new Book("Dummy1", "1", "John Doe", DateTime.Today, DateTime.Today, "Some Publisher", 67, "1", 69.99m, "NonFiction", "Default", 1),1));
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
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
    }
}
