using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookCollection.ObjectClasses;

namespace BookCollection
{
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee(bool editMode)
        {
            InitializeComponent();

            if (editMode)
            {

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Employee employeeObj = new Employee(
                employeeIdMaskedTextBox.Text,
                nameTextBox.Text,
                decimal.Parse(payMaskedTextBox.Text),
                birthdayDatePicker.Value
                );
            DummyGlobalInfo.ALL_EMPLOYEES.Add( employeeObj );
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            employeeIdMaskedTextBox.Clear();
            payMaskedTextBox.Clear();
            birthdayDatePicker.Value = DateTime.Now;
            ageMaskedTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
