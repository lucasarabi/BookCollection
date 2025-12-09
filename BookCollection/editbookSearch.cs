using BookCollection.DatabaseClasses.Repositories;
using BookCollection.ObjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCollection
{
    public partial class editbookSearch : Form
    {
        public editbookSearch()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            InitializeComponent();
        }

        private void editbookSearch_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string id = searchTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please enter a Book ID.",
                                "Missing Book ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Book? foundBook = BookRepository.GetById(id);

            if (foundBook == null)
            {
                MessageBox.Show("No book found with that ID.",
                                "Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            FormEditRecord editForm = new FormEditRecord(foundBook);
            editForm.ShowDialog();

            this.Close();
        }
    }
}
