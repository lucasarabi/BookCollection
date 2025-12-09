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
            storeGroupBox.Location = new Point(10, 9);
            storeGroupBox.Margin = new Padding(3, 2, 3, 2);
            storeGroupBox.Name = "storeGroupBox";
            storeGroupBox.Padding = new Padding(3, 2, 3, 2);
            storeGroupBox.Size = new Size(284, 404);
            storeGroupBox.TabIndex = 0;
            storeGroupBox.TabStop = false;
            storeGroupBox.Text = "Stores";
            // 
            // storeListBox
            // 
            storeListBox.FormattingEnabled = true;
            storeListBox.ItemHeight = 15;
            storeListBox.Location = new Point(5, 20);
            storeListBox.Margin = new Padding(3, 2, 3, 2);
            storeListBox.Name = "storeListBox";
            storeListBox.Size = new Size(274, 274);
            storeListBox.TabIndex = 3;
            // 
            // storeAdd
            // 
            storeAdd.Location = new Point(5, 298);
            storeAdd.Margin = new Padding(3, 2, 3, 2);
            storeAdd.Name = "storeAdd";
            storeAdd.Size = new Size(274, 31);
            storeAdd.TabIndex = 2;
            storeAdd.Text = "Add";
            storeAdd.UseVisualStyleBackColor = true;
            storeAdd.Click += storeAdd_Click;
            // 
            // storeRemove
            // 
            storeRemove.Location = new Point(5, 334);
            storeRemove.Margin = new Padding(3, 2, 3, 2);
            storeRemove.Name = "storeRemove";
            storeRemove.Size = new Size(274, 31);
            storeRemove.TabIndex = 1;
            storeRemove.Text = "Remove";
            storeRemove.UseVisualStyleBackColor = true;
            storeRemove.Click += storeRemove_Click;
            // 
            // storeEdit
            // 
            storeEdit.Location = new Point(5, 369);
            storeEdit.Margin = new Padding(3, 2, 3, 2);
            storeEdit.Name = "storeEdit";
            storeEdit.Size = new Size(274, 31);
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
            employeeGroupBox.Location = new Point(302, 9);
            employeeGroupBox.Margin = new Padding(3, 2, 3, 2);
            employeeGroupBox.Name = "employeeGroupBox";
            employeeGroupBox.Padding = new Padding(3, 2, 3, 2);
            employeeGroupBox.Size = new Size(284, 404);
            employeeGroupBox.TabIndex = 1;
            employeeGroupBox.TabStop = false;
            employeeGroupBox.Text = "Employees";
            // 
            // employeeListBox
            // 
            employeeListBox.FormattingEnabled = true;
            employeeListBox.ItemHeight = 15;
            employeeListBox.Location = new Point(5, 21);
            employeeListBox.Margin = new Padding(3, 2, 3, 2);
            employeeListBox.Name = "employeeListBox";
            employeeListBox.Size = new Size(274, 274);
            employeeListBox.TabIndex = 6;
            // 
            // employeeAdd
            // 
            employeeAdd.Location = new Point(5, 298);
            employeeAdd.Margin = new Padding(3, 2, 3, 2);
            employeeAdd.Name = "employeeAdd";
            employeeAdd.Size = new Size(274, 31);
            employeeAdd.TabIndex = 5;
            employeeAdd.Text = "Add";
            employeeAdd.UseVisualStyleBackColor = true;
            employeeAdd.Click += employeeAdd_Click;
            // 
            // employeeRemove
            // 
            employeeRemove.Location = new Point(5, 334);
            employeeRemove.Margin = new Padding(3, 2, 3, 2);
            employeeRemove.Name = "employeeRemove";
            employeeRemove.Size = new Size(274, 31);
            employeeRemove.TabIndex = 4;
            employeeRemove.Text = "Remove";
            employeeRemove.UseVisualStyleBackColor = true;
            employeeRemove.Click += employeeRemove_Click;
            // 
            // employeeEdit
            // 
            employeeEdit.Location = new Point(5, 369);
            employeeEdit.Margin = new Padding(3, 2, 3, 2);
            employeeEdit.Name = "employeeEdit";
            employeeEdit.Size = new Size(274, 31);
            employeeEdit.TabIndex = 3;
            employeeEdit.Text = "Edit";
            employeeEdit.UseVisualStyleBackColor = true;
            employeeEdit.Click += employeeEdit_Click;
            // 
            // FormAdminDirectory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 422);
            Controls.Add(employeeGroupBox);
            Controls.Add(storeGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
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