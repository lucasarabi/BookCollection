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
            // View Cart caca
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            // Add Stuff Caca
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Query Caca
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
