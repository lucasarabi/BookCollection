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
        List<Store> stores;
        List<Employee> employees;

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
            stores = StoreRepository.GetAll();

            this.storeListBox.DataSource = null;
            this.storeListBox.DataSource = stores;

            this.storeListBox.DisplayMember = "name";
        }

        public void refreshEmployeeListBox()
        {
            employees = EmployeeRepository.GetAll();

            this.employeeListBox.DataSource = null;
            this.employeeListBox.DataSource = employees;

            this.employeeListBox.DisplayMember = "Name";
        }

        private void refreshEventWrapper(object sender, EventArgs e)
        {
            refreshStoreListBox();
            refreshEmployeeListBox();
        }

        private void storeAdd_Click(object sender, EventArgs e)
        {
            FormAddStore newStore = new FormAddStore(null);
            newStore.FormClosed += refreshEventWrapper;
            newStore.ShowDialog();
        }

        private void storeRemove_Click(object sender, EventArgs e)
        {
            if (this.storeListBox.SelectedItem == null) return;

            Store selected = (Store)this.storeListBox.SelectedItem;

            StoreRepository.Delete(selected.storeId);
            refreshStoreListBox();
        }

        private void storeEdit_Click(object sender, EventArgs e)
        {
            if (this.storeListBox.SelectedItem == null)
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
            if (this.employeeListBox.SelectedItem == null) return;

            Employee selected = (Employee)this.employeeListBox.SelectedItem;

            EmployeeRepository.Delete(selected.EmployeeID);

            refreshEmployeeListBox();
        }

        private void employeeEdit_Click(object sender, EventArgs e)
        {
            if (this.employeeListBox.SelectedItem == null)
            {
                MessageBox.Show("No employee selected!");
                return;
            }

            FormAddEmployee editEmployee = new FormAddEmployee((Employee)this.employeeListBox.SelectedItem);
            editEmployee.FormClosed += refreshEventWrapper;
            editEmployee.ShowDialog();
        }
    }
}