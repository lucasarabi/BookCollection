using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BookCollection.ObjectClasses;
using BookCollection.Repsitories;

namespace BookCollection
{
    public partial class FormAddEmployee : Form
    {

        private bool isEditMode = false;
        private Employee? selectedEmployee;
        public FormAddEmployee(Employee? selectedEmployee)
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

            if (selectedEmployee != null)
            {
                this.selectedEmployee = selectedEmployee;
                this.nameTextBox.Text = selectedEmployee.Name;
                this.employeeIdMaskedTextBox.Text = selectedEmployee.EmployeeID.ToString();
                this.payMaskedTextBox.Text = selectedEmployee.pay.ToString();
                this.birthdayDatePicker.Value = selectedEmployee.Birthday;
                this.ageMaskedTextBox.Text = selectedEmployee.age.ToString();
                isEditMode = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                selectedEmployee.Name = this.nameTextBox.Text;
                selectedEmployee.Birthday = this.birthdayDatePicker.Value;
                EmployeeRepository.Update(selectedEmployee);
            }
            else
            {
                Employee employee = new Employee(
                    nameTextBox.Text,
                    decimal.Parse(payMaskedTextBox.Text),
                    birthdayDatePicker.Value
                    );
                EmployeeRepository.Add(employee);
            }
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
