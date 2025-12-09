using BookCollection.DatabaseClasses.Repositories;
using BookCollection.ObjectClasses;
using BookCollection.Repsitories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCollection
{
    public partial class FormAdminDirectory : Form
    {

        public FormAdminDirectory()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            InitializeComponent();
            refreshStoreListBox();
            refreshEmployeeListBox();
        }

        public void refreshStoreListBox()
        {
            this.storeListBox.DataSource = StoreRepository.GetAll().Select(s => s.name).ToList();
        }

        public void refreshEmployeeListBox()
        {
            this.employeeListBox.DataSource = EmployeeRepository.GetAll().Select(e => e.Name).ToList();
        }

        private void storeAdd_Click(object sender, EventArgs e)
        {
            FormAddStore newStore = new FormAddStore(null);
            newStore.FormClosed += refreshEventWrapper;
            newStore.ShowDialog();
        }

        private void refreshEventWrapper(object sender, EventArgs e)
        {
            refreshStoreListBox();
        }

        private void storeRemove_Click(object sender, EventArgs e)
        {
            StoreRepository.Delete(((Store)this.storeListBox.SelectedItem).storeId);
            refreshStoreListBox();
        }

        private void storeEdit_Click(object sender, EventArgs e)
        {
            if(this.storeListBox.SelectedItem == null)
            {
                MessageBox.Show("No store selected!");
                return;
            }
            FormAddStore editStore = new FormAddStore((Store)this.storeListBox.SelectedItem);
            editStore.FormClosed += refreshEventWrapper;
            editStore.ShowDialog();
        }

        private void employeeAdd_Click(object sender, EventArgs e)
        {
            FormAddEmployee newEmployee = new FormAddEmployee(null);
            newEmployee.FormClosed += refreshEventWrapper;
            newEmployee.ShowDialog();
        }

        private void employeeRemove_Click(object sender, EventArgs e)
        {
            EmployeeRepository.Delete(((Employee)this.employeeListBox.SelectedItem).EmployeeID);
            refreshStoreListBox();
        }

        private void employeeEdit_Click(object sender, EventArgs e)
        {
            if (this.storeListBox.SelectedItem == null)
            {
                MessageBox.Show("No store selected!");
                return;
            }
            FormAddEmployee editEmployee = new FormAddEmployee((Employee)this.employeeListBox.SelectedItem);
            editEmployee.FormClosed += refreshEventWrapper;
            editEmployee.ShowDialog();
        }
    }
}
