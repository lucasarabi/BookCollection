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
    public partial class FormAdminBookCollectionManagement : Form
    {
        public FormAdminBookCollectionManagement()
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

        }

        private void deleteAllRecordsBtn_Click(object sender, EventArgs e)
        {

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
    }
}
