namespace BookCollection
{
    partial class FormShoppingCart
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            btnCheckout = new Button();
            lblTotalValue = new Label();
            lblTaxValue = new Label();
            lblSubtotalValue = new Label();
            lblTotalText = new Label();
            lblTaxText = new Label();
            lblSubtotalText = new Label();
            btnSaveCart = new Button();
            btnClearCart = new Button();
            flpCartItems = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCheckout);
            groupBox1.Controls.Add(lblTotalValue);
            groupBox1.Controls.Add(lblTaxValue);
            groupBox1.Controls.Add(lblSubtotalValue);
            groupBox1.Controls.Add(lblTotalText);
            groupBox1.Controls.Add(lblTaxText);
            groupBox1.Controls.Add(lblSubtotalText);
            groupBox1.Controls.Add(btnSaveCart);
            groupBox1.Controls.Add(btnClearCart);
            groupBox1.Controls.Add(flpCartItems);
            groupBox1.Location = new Point(17, 17);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(713, 549);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Your Shopping Cart";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(18, 443);
            btnCheckout.Margin = new Padding(3, 4, 3, 4);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(429, 77);
            btnCheckout.TabIndex = 9;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(535, 293);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(123, 20);
            lblTotalValue.TabIndex = 8;
            lblTotalValue.Text = "valueplaceholder";
            // 
            // lblTaxValue
            // 
            lblTaxValue.AutoSize = true;
            lblTaxValue.Location = new Point(535, 259);
            lblTaxValue.Name = "lblTaxValue";
            lblTaxValue.Size = new Size(123, 20);
            lblTaxValue.TabIndex = 7;
            lblTaxValue.Text = "valueplaceholder";
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.AutoSize = true;
            lblSubtotalValue.Location = new Point(535, 223);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(123, 20);
            lblSubtotalValue.TabIndex = 6;
            lblSubtotalValue.Text = "valueplaceholder";
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Location = new Point(487, 293);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(45, 20);
            lblTotalText.TabIndex = 5;
            lblTotalText.Text = "Total:";
            // 
            // lblTaxText
            // 
            lblTaxText.AutoSize = true;
            lblTaxText.Location = new Point(497, 259);
            lblTaxText.Name = "lblTaxText";
            lblTaxText.Size = new Size(33, 20);
            lblTaxText.TabIndex = 4;
            lblTaxText.Text = "Tax:";
            // 
            // lblSubtotalText
            // 
            lblSubtotalText.AutoSize = true;
            lblSubtotalText.Location = new Point(466, 223);
            lblSubtotalText.Name = "lblSubtotalText";
            lblSubtotalText.Size = new Size(68, 20);
            lblSubtotalText.TabIndex = 3;
            lblSubtotalText.Text = "Subtotal:";
            // 
            // btnSaveCart
            // 
            btnSaveCart.Location = new Point(466, 123);
            btnSaveCart.Margin = new Padding(3, 4, 3, 4);
            btnSaveCart.Name = "btnSaveCart";
            btnSaveCart.Size = new Size(217, 69);
            btnSaveCart.TabIndex = 2;
            btnSaveCart.Text = "Save Cart";
            btnSaveCart.UseVisualStyleBackColor = true;
            // 
            // btnClearCart
            // 
            btnClearCart.Location = new Point(466, 45);
            btnClearCart.Margin = new Padding(3, 4, 3, 4);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(217, 69);
            btnClearCart.TabIndex = 1;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = true;
            // 
            // flpCartItems
            // 
            flpCartItems.AutoScroll = true;
            flpCartItems.BorderStyle = BorderStyle.FixedSingle;
            flpCartItems.FlowDirection = FlowDirection.TopDown;
            flpCartItems.Location = new Point(17, 45);
            flpCartItems.Margin = new Padding(3, 4, 3, 4);
            flpCartItems.Name = "flpCartItems";
            flpCartItems.Size = new Size(429, 374);
            flpCartItems.TabIndex = 0;
            flpCartItems.WrapContents = false;
            // 
            // FormShoppingCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 580);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormShoppingCart";
            Text = "ShoppingCart";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flpCartItems;
        private Button btnSaveCart;
        private Button btnClearCart;
        private Button btnCheckout;
        private Label lblTotalValue;
        private Label lblTaxValue;
        private Label lblSubtotalValue;
        private Label lblTotalText;
        private Label lblTaxText;
        private Label lblSubtotalText;
    }
}