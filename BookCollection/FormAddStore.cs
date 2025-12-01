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
    public partial class FormAddStore : Form
    {
        public FormAddStore(bool editMode)
        {
            InitializeComponent();

            if (editMode)
            {
            
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Store store = new Store(
                addressTextBox.Text,
                cityTextBox.Text,
                stateTextBox.Text,
                zipTextBox.Text,
                nameTextBox.Text
                );
            DummyGlobalInfo.STORES.Add( store );
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            addressTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipTextBox.Clear();
            nameTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
