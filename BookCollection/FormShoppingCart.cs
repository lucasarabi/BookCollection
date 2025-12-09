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

        // The model representing a book in the cart
        public class BookItem
        {
            public string Title { get; set; } = "";
            public string Details { get; set; } = "";
            public int Quantity { get; set; }
            public decimal Price { get; set; } = 10.00m; // TEMP default
        }

        // Fake test data — remove when real DB is connected
        //public static List<BookItem> TestBooks = new List<BookItem>
        //{
        //    new BookItem { Title = "Book A", Details = "Author: John", Quantity = 1, Price = 10 },
        //    new BookItem { Title = "Book B", Details = "Author: Sarah", Quantity = 2, Price = 15 },
        //    new BookItem { Title = "Book C", Details = "Author: Mike", Quantity = 1, Price = 12 },
        //};

        // LOAD CART
        private void LoadCart()
        {
            flpCartItems.Controls.Clear();

            foreach (var cartItem in DummyGlobalInfo.CURRENT_CART)
            {
                // convert your CartItem -> the BookItem model used by the control
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
                    cartItem.Quantity++;
                    bookItem.Quantity = cartItem.Quantity;
                    UpdateTotals();
                };

                item.QuantityDecreased += (s, e) =>
                {
                    cartItem.Quantity--;
                    bookItem.Quantity = cartItem.Quantity;
                    UpdateTotals();
                };

                item.ItemRemoved += (s, e) =>
                {
                    DummyGlobalInfo.CURRENT_CART.Remove(cartItem);
                    flpCartItems.Controls.Remove(item);
                    UpdateTotals();
                };

                flpCartItems.Controls.Add(item);
            }
        }

        // UPDATE TOTALS
        private void UpdateTotals()
        {
            // if cart is empty, avoid errors
            if (DummyGlobalInfo.CURRENT_CART == null || DummyGlobalInfo.CURRENT_CART.Count == 0)
            {
                lblSubtotalValue.Text = 0m.ToString("C");
                lblTaxValue.Text = 0m.ToString("C");
                lblTotalValue.Text = 0m.ToString("C");
                return;
            }

            decimal subtotal = DummyGlobalInfo.CURRENT_CART
                .Sum(ci => ci.Book.Price * ci.Quantity);

            decimal tax = subtotal * 0.07m;   // 7% tax – adjust if needed
            decimal total = subtotal + tax;

            lblSubtotalValue.Text = subtotal.ToString("C");
            lblTaxValue.Text = tax.ToString("C");
            lblTotalValue.Text = total.ToString("C");
        }

        // BUTTONS
        private void btnClearCart_Click(object sender, EventArgs e)
        {
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

            // Close the shopping cart window
            this.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // Calculate totals from CURRENT_CART
            decimal subtotal = DummyGlobalInfo.CURRENT_CART.Sum(ci => ci.Book.Price * ci.Quantity);
            decimal tax = subtotal * 0.07m;   // 7% tax or your tax rate
            decimal total = subtotal + tax;

            // Show popup with total
            MessageBox.Show(
                $"Checkout complete!\n\nTotal: {total:C}",
                "Checkout Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // OPTIONAL: Clear cart after checkout
            DummyGlobalInfo.CURRENT_CART.Clear();
            flpCartItems.Controls.Clear();
            UpdateTotals();

            // Close the shopping cart page
            this.Close();
        }


        private void FormShoppingCart_Load(object sender, EventArgs e)
        {

        }
    }
}
