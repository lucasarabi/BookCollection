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
    public partial class FormAdminDirectory : Form
    {
        List<Employee> employees;
        List<Store> stores;

        public FormAdminDirectory()
        {
            InitializeComponent();
        }

        private void storeAdd_Click(object sender, EventArgs e)
        {
            FormAddStore newStore = new FormAddStore(false);
            newStore.ShowDialog();
        }

        private void storeRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alert", "Removing store");
        }

        private void storeEdit_Click(object sender, EventArgs e)
        {
            FormAddStore editStore = new FormAddStore(true);
        }

        private void employeeAdd_Click(object sender, EventArgs e)
        {
            FormAddEmployee newEmployee = new FormAddEmployee(false);
            newEmployee.ShowDialog();
        }

        private void employeeRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alert", "Removing employee");
        }

        private void employeeEdit_Click(object sender, EventArgs e)
        {
            FormAddEmployee editEmployee = new FormAddEmployee(true);
        }

    }
}
