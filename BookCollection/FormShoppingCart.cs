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
        public static List<BookItem> TestBooks = new List<BookItem>
        {
            new BookItem { Title = "Book A", Details = "Author: John", Quantity = 1, Price = 10 },
            new BookItem { Title = "Book B", Details = "Author: Sarah", Quantity = 2, Price = 15 },
            new BookItem { Title = "Book C", Details = "Author: Mike", Quantity = 1, Price = 12 },
        };

        // LOAD CART
        private void LoadCart()
        {
            flpCartItems.Controls.Clear();

            foreach (var book in TestBooks)
            {
                CartItemControl item = new CartItemControl();
                item.LoadData(book);

                // Subscribe to events
                item.QuantityIncreased += (s, e) => { book.Quantity++; UpdateTotals(); };
                item.QuantityDecreased += (s, e) => { book.Quantity--; UpdateTotals(); };
                item.ItemRemoved += (s, e) =>
                {
                    TestBooks.Remove(book);
                    flpCartItems.Controls.Remove(item);
                    UpdateTotals();
                };

                flpCartItems.Controls.Add(item);
            }
        }

        // UPDATE TOTALS
        private void UpdateTotals()
        {
            decimal subtotal = TestBooks.Sum(b => b.Price * b.Quantity);
            decimal tax = subtotal * 0.07m;
            decimal total = subtotal + tax;

            lblSubtotalValue.Text = subtotal.ToString("C");
            lblTaxValue.Text = tax.ToString("C");
            lblTotalValue.Text = total.ToString("C");
        }

        // BUTTONS
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            TestBooks.Clear();
            flpCartItems.Controls.Clear();
            UpdateTotals();
        }

        private void btnSaveCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cart saved (placeholder).");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Checkout complete (placeholder).");
        }

        private void FormShoppingCart_Load(object sender, EventArgs e)
        {

        }
    }
}
