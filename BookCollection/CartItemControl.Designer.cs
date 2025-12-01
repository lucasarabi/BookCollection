namespace BookCollection
{
    partial class CartItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlBorder = new Panel();
            btnRemoveItem = new Button();
            btnQtyPlus = new Button();
            lblQuantity = new Label();
            btnQtyMinus = new Button();
            lblBookDetails = new Label();
            lblBookTitle = new Label();
            pnlBorder.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBorder
            // 
            pnlBorder.Controls.Add(btnRemoveItem);
            pnlBorder.Controls.Add(btnQtyPlus);
            pnlBorder.Controls.Add(lblQuantity);
            pnlBorder.Controls.Add(btnQtyMinus);
            pnlBorder.Controls.Add(lblBookDetails);
            pnlBorder.Controls.Add(lblBookTitle);
            pnlBorder.Location = new Point(3, 4);
            pnlBorder.Margin = new Padding(3, 4, 3, 4);
            pnlBorder.Name = "pnlBorder";
            pnlBorder.Size = new Size(384, 93);
            pnlBorder.TabIndex = 0;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(341, 31);
            btnRemoveItem.Margin = new Padding(3, 4, 3, 4);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(33, 31);
            btnRemoveItem.TabIndex = 6;
            btnRemoveItem.Text = "(0)";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnQtyPlus
            // 
            btnQtyPlus.Location = new Point(296, 28);
            btnQtyPlus.Margin = new Padding(3, 4, 3, 4);
            btnQtyPlus.Name = "btnQtyPlus";
            btnQtyPlus.Size = new Size(27, 31);
            btnQtyPlus.TabIndex = 4;
            btnQtyPlus.Text = "+";
            btnQtyPlus.UseVisualStyleBackColor = true;
            btnQtyPlus.Click += btnQtyPlus_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(269, 33);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(31, 31);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "(#)";
            // 
            // btnQtyMinus
            // 
            btnQtyMinus.Location = new Point(235, 28);
            btnQtyMinus.Margin = new Padding(3, 4, 3, 4);
            btnQtyMinus.Name = "btnQtyMinus";
            btnQtyMinus.Size = new Size(29, 31);
            btnQtyMinus.TabIndex = 2;
            btnQtyMinus.Text = "-";
            btnQtyMinus.UseVisualStyleBackColor = true;
            btnQtyMinus.Click += btnQtyMinus_Click;
            // 
            // lblBookDetails
            // 
            lblBookDetails.Location = new Point(7, 40);
            lblBookDetails.Name = "lblBookDetails";
            lblBookDetails.Size = new Size(222, 45);
            lblBookDetails.TabIndex = 1;
            lblBookDetails.Text = "(book details)";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(7, 8);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(83, 20);
            lblBookTitle.TabIndex = 0;
            lblBookTitle.Text = "(Book title)";
            // 
            // CartItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlBorder);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CartItemControl";
            Size = new Size(391, 100);
            pnlBorder.ResumeLayout(false);
            pnlBorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBorder;
        private Label lblBookDetails;
        private Label lblBookTitle;
        private Button btnRemoveItem;
        private Button btnQtyPlus;
        private Label lblQuantity;
        private Button btnQtyMinus;
    }
}
