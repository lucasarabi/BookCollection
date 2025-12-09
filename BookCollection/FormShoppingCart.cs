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
    public partial class FormShoppingCart : Form
    {
        public FormShoppingCart()
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
            LoadCart();
            UpdateTotals();
        }

        public class BookItem
        {
            public string Title { get; set; } = "";
            public string Details { get; set; } = "";
            public int Quantity { get; set; }
            public decimal Price { get; set; } = 10.00m; 
        }

        private void LoadCart()
        {
            flpCartItems.Controls.Clear();

            foreach (var cartItem in DummyGlobalInfo.CURRENT_CART)
            {
                var bookItem = new BookItem
                {
                    Title = cartItem.Book.Title,
                    Details = $"Author: {cartItem.Book.Author}",
                    Quantity = cartItem.Quantity,
                    Price = cartItem.Book.Price
                };

                CartItemControl item = new CartItemControl();
                item.LoadData(bookItem);

                item.QuantityIncreased += (s, e) =>
                {
                    
                    if (cartItem.Book.quantity <= 0)
                    {
                        
                        item.Quantity--;  
                        MessageBox.Show("No more copies of this book are available.",
                                        "Out of Stock",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }

                    
                    cartItem.Quantity++;
                    cartItem.Book.quantity--;

                    bookItem.Quantity = cartItem.Quantity;
                    UpdateTotals();
                };

                item.QuantityDecreased += (s, e) =>
                {

                    cartItem.Quantity--;
                    cartItem.Book.quantity++; 

                    bookItem.Quantity = cartItem.Quantity;
                    UpdateTotals();
                };

                item.ItemRemoved += (s, e) =>
                {
                   
                    cartItem.Book.quantity += cartItem.Quantity;

                    DummyGlobalInfo.CURRENT_CART.Remove(cartItem);
                    flpCartItems.Controls.Remove(item);
                    UpdateTotals();

                };

                flpCartItems.Controls.Add(item);
            }
        }

        private void UpdateTotals()
        {
            if (DummyGlobalInfo.CURRENT_CART == null || DummyGlobalInfo.CURRENT_CART.Count == 0)
            {
                lblSubtotalValue.Text = 0m.ToString("C");
                lblTaxValue.Text = 0m.ToString("C");
                lblTotalValue.Text = 0m.ToString("C");
                return;
            }

            decimal subtotal = DummyGlobalInfo.CURRENT_CART
                .Sum(ci => ci.Book.Price * ci.Quantity);

            decimal tax = subtotal * 0.07m;   
            decimal total = subtotal + tax;

            lblSubtotalValue.Text = subtotal.ToString("C");
            lblTaxValue.Text = tax.ToString("C");
            lblTotalValue.Text = total.ToString("C");
        }

        // BUTTONS
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            foreach (var cartItem in DummyGlobalInfo.CURRENT_CART)
            {
                cartItem.Book.quantity += cartItem.Quantity;
            }

            DummyGlobalInfo.CURRENT_CART.Clear();
            flpCartItems.Controls.Clear();
            UpdateTotals();

            MessageBox.Show("Cart cleared.",
                            "Cart Emptied",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnSaveCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cart saved, returning to collection manager.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            decimal subtotal = DummyGlobalInfo.CURRENT_CART.Sum(ci => ci.Book.Price * ci.Quantity);
            decimal tax = subtotal * 0.07m;   
            decimal total = subtotal + tax;

            MessageBox.Show(
                $"Checkout complete!\n\nTotal: {total:C}",
                "Checkout Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            DummyGlobalInfo.CURRENT_CART.Clear();
            flpCartItems.Controls.Clear();
            UpdateTotals();

            this.Close();
        }

        private void FormShoppingCart_Load(object sender, EventArgs e)
        {

        }
    }
}
