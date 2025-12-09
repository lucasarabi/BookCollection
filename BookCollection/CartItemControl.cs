using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookCollection.FormShoppingCart;

namespace BookCollection
{
    public partial class CartItemControl : UserControl
    {
        public int Quantity
        {
            get => int.Parse(lblQuantity.Text);
            set => lblQuantity.Text = value.ToString();
        }

        public string Title
        {
            get => lblBookTitle.Text;
            set => lblBookTitle.Text = value;
        }

        public string Details
        {
            get => lblBookDetails.Text;
            set => lblBookDetails.Text = value;
        }

        // Events that notify the parent form
        public event EventHandler? QuantityIncreased;
        public event EventHandler? QuantityDecreased;
        public event EventHandler? ItemRemoved;

        public CartItemControl()
        {
            InitializeComponent();
        }

        public void LoadData(FormShoppingCart.BookItem book)
        {
            Title = book.Title;
            Details = book.Details;
            Quantity = book.Quantity;
        }

        private void btnQtyPlus_Click(object sender, EventArgs e)
        {
            Quantity++;
            QuantityIncreased?.Invoke(this, EventArgs.Empty);
        }

        private void btnQtyMinus_Click(object sender, EventArgs e)
        {
            if (Quantity > 1)
            {
                Quantity--;
                QuantityDecreased?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item removed from cart.",
                   "Removed",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

            ItemRemoved?.Invoke(this, EventArgs.Empty);
        }
    }
}