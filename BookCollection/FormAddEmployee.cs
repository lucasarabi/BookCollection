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
            this.StartPosition = FormStartPosition.Manual;

            int screenW = Screen.PrimaryScreen.WorkingArea.Width;
            int screenH = Screen.PrimaryScreen.WorkingArea.Height;

            int targetX = (int)(screenW * (1.5 / 2.5));
            int targetY = screenH / 2 - this.Height;

            this.Location = new Point(targetX, targetY);

            this.StartPosition = FormStartPosition.Manual;
            this.MaximizeBox = false;

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
            DummyGlobalInfo.ALL_EMPLOYEES.Add(employeeObj);
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

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
