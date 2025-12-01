namespace BookCollection
{
    partial class FormAdminDirectory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            storeGroupBox = new GroupBox();
            storeListBox = new ListBox();
            storeAdd = new Button();
            storeRemove = new Button();
            storeEdit = new Button();
            employeeGroupBox = new GroupBox();
            employeeListBox = new ListBox();
            employeeAdd = new Button();
            employeeRemove = new Button();
            employeeEdit = new Button();
            storeGroupBox.SuspendLayout();
            employeeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // storeGroupBox
            // 
            storeGroupBox.Controls.Add(storeListBox);
            storeGroupBox.Controls.Add(storeAdd);
            storeGroupBox.Controls.Add(storeRemove);
            storeGroupBox.Controls.Add(storeEdit);
            storeGroupBox.Location = new Point(12, 12);
            storeGroupBox.Name = "storeGroupBox";
            storeGroupBox.Size = new Size(325, 539);
            storeGroupBox.TabIndex = 0;
            storeGroupBox.TabStop = false;
            storeGroupBox.Text = "Stores";
            // 
            // storeListBox
            // 
            storeListBox.FormattingEnabled = true;
            storeListBox.Location = new Point(6, 26);
            storeListBox.Name = "storeListBox";
            storeListBox.Size = new Size(313, 364);
            storeListBox.TabIndex = 3;
            // 
            // storeAdd
            // 
            storeAdd.Location = new Point(6, 398);
            storeAdd.Name = "storeAdd";
            storeAdd.Size = new Size(313, 41);
            storeAdd.TabIndex = 2;
            storeAdd.Text = "Add";
            storeAdd.UseVisualStyleBackColor = true;
            storeAdd.Click += storeAdd_Click;
            // 
            // storeRemove
            // 
            storeRemove.Location = new Point(6, 445);
            storeRemove.Name = "storeRemove";
            storeRemove.Size = new Size(313, 41);
            storeRemove.TabIndex = 1;
            storeRemove.Text = "Remove";
            storeRemove.UseVisualStyleBackColor = true;
            storeRemove.Click += storeRemove_Click;
            // 
            // storeEdit
            // 
            storeEdit.Location = new Point(6, 492);
            storeEdit.Name = "storeEdit";
            storeEdit.Size = new Size(313, 41);
            storeEdit.TabIndex = 0;
            storeEdit.Text = "Edit";
            storeEdit.UseVisualStyleBackColor = true;
            storeEdit.Click += storeEdit_Click;
            // 
            // employeeGroupBox
            // 
            employeeGroupBox.Controls.Add(employeeListBox);
            employeeGroupBox.Controls.Add(employeeAdd);
            employeeGroupBox.Controls.Add(employeeRemove);
            employeeGroupBox.Controls.Add(employeeEdit);
            employeeGroupBox.Location = new Point(345, 12);
            employeeGroupBox.Name = "employeeGroupBox";
            employeeGroupBox.Size = new Size(325, 539);
            employeeGroupBox.TabIndex = 1;
            employeeGroupBox.TabStop = false;
            employeeGroupBox.Text = "Employees";
            // 
            // employeeListBox
            // 
            employeeListBox.FormattingEnabled = true;
            employeeListBox.Location = new Point(6, 28);
            employeeListBox.Name = "employeeListBox";
            employeeListBox.Size = new Size(313, 364);
            employeeListBox.TabIndex = 6;
            // 
            // employeeAdd
            // 
            employeeAdd.Location = new Point(6, 398);
            employeeAdd.Name = "employeeAdd";
            employeeAdd.Size = new Size(313, 41);
            employeeAdd.TabIndex = 5;
            employeeAdd.Text = "Add";
            employeeAdd.UseVisualStyleBackColor = true;
            employeeAdd.Click += employeeAdd_Click;
            // 
            // employeeRemove
            // 
            employeeRemove.Location = new Point(6, 445);
            employeeRemove.Name = "employeeRemove";
            employeeRemove.Size = new Size(313, 41);
            employeeRemove.TabIndex = 4;
            employeeRemove.Text = "Remove";
            employeeRemove.UseVisualStyleBackColor = true;
            employeeRemove.Click += employeeRemove_Click;
            // 
            // employeeEdit
            // 
            employeeEdit.Location = new Point(6, 492);
            employeeEdit.Name = "employeeEdit";
            employeeEdit.Size = new Size(313, 41);
            employeeEdit.TabIndex = 3;
            employeeEdit.Text = "Edit";
            employeeEdit.UseVisualStyleBackColor = true;
            employeeEdit.Click += employeeEdit_Click;
            // 
            // FormAdminDirectory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 563);
            Controls.Add(employeeGroupBox);
            Controls.Add(storeGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAdminDirectory";
            Text = "Admin Directory";
            storeGroupBox.ResumeLayout(false);
            employeeGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox storeGroupBox;
        private Button storeEdit;
        private GroupBox employeeGroupBox;
        private Button storeAdd;
        private Button storeRemove;
        private Button employeeAdd;
        private Button employeeRemove;
        private Button employeeEdit;
        private ListBox storeListBox;
        private ListBox employeeListBox;
    }
}