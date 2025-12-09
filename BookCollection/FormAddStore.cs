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
    public partial class FormAddStore : Form
    {
        private bool isEditMode = false;
        Store? selectedStore;
        public FormAddStore(Store? selectedStore)
        {

            this.StartPosition = FormStartPosition.Manual;

            int screenW = Screen.PrimaryScreen.WorkingArea.Width;
            int screenH = Screen.PrimaryScreen.WorkingArea.Height;

            int targetX = (int)(screenW * (1.5 / 2.5));
            int targetY = screenH / 2 - this.Height;

            this.Location = new Point(targetX, targetY);

            this.StartPosition = FormStartPosition.Manual;
            this.MaximizeBox = false;

            InitializeComponent();

            if (selectedStore != null) 
            {
                this.selectedStore = selectedStore;
                this.addressTextBox.Text = selectedStore.address;
                this.cityTextBox.Text = selectedStore.city;
                this.stateTextBox.Text = selectedStore.state;
                this.zipTextBox.Text = selectedStore.zipCode;
                this.nameTextBox.Text = selectedStore.name;
                isEditMode = true;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(cityTextBox.Text) ||
                string.IsNullOrWhiteSpace(stateTextBox.Text) ||
                string.IsNullOrWhiteSpace(zipTextBox.Text))
            {
                MessageBox.Show("All fields must be filled out.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (isEditMode)
            {
                selectedStore.address = this.addressTextBox.Text;
                selectedStore.city = this.cityTextBox.Text;
                selectedStore.state = this.stateTextBox.Text;
                selectedStore.zipCode = this.zipTextBox.Text;
                selectedStore.name = this.nameTextBox.Text;
                StoreRepository.Update(selectedStore);
            }
            else
            {
                Store store = new Store(
                    addressTextBox.Text,
                    cityTextBox.Text,
                    stateTextBox.Text,
                    zipTextBox.Text,
                    nameTextBox.Text
                    );
                StoreRepository.Add(store);
            }

            this.DialogResult = DialogResult.OK;
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

        private void FormAddStore_Load(object sender, EventArgs e)
        {

        }
    }
}
