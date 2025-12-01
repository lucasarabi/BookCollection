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
            pnlBorder.Location = new Point(3, 3);
            pnlBorder.Name = "pnlBorder";
            pnlBorder.Size = new Size(336, 70);
            pnlBorder.TabIndex = 0;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(298, 23);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(29, 23);
            btnRemoveItem.TabIndex = 6;
            btnRemoveItem.Text = "(0)";
            btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnQtyPlus
            // 
            btnQtyPlus.Location = new Point(259, 21);
            btnQtyPlus.Name = "btnQtyPlus";
            btnQtyPlus.Size = new Size(24, 23);
            btnQtyPlus.TabIndex = 4;
            btnQtyPlus.Text = "+";
            btnQtyPlus.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(235, 25);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(27, 23);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "(#)";
            // 
            // btnQtyMinus
            // 
            btnQtyMinus.Location = new Point(206, 21);
            btnQtyMinus.Name = "btnQtyMinus";
            btnQtyMinus.Size = new Size(25, 23);
            btnQtyMinus.TabIndex = 2;
            btnQtyMinus.Text = "-";
            btnQtyMinus.UseVisualStyleBackColor = true;
            // 
            // lblBookDetails
            // 
            lblBookDetails.Location = new Point(6, 30);
            lblBookDetails.Name = "lblBookDetails";
            lblBookDetails.Size = new Size(194, 34);
            lblBookDetails.TabIndex = 1;
            lblBookDetails.Text = "(book details)";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(6, 6);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(65, 15);
            lblBookTitle.TabIndex = 0;
            lblBookTitle.Text = "(Book title)";
            // 
            // CartItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlBorder);
            Name = "CartItemControl";
            Size = new Size(342, 75);
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
