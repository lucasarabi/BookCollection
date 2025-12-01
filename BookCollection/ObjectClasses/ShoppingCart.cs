using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection.ObjectClasses
{
    public class ShoppingCart
    {
        private const decimal TaxRate = 0.07m;

        public List<CartItem> Items { get; } = new List<CartItem>();

        public void AddBook(Book book, int quantity)
        {
            Items.Add(new CartItem ( book, quantity ));
        }

        public void RemoveBook(CartItem item) 
        {
            Items.Remove(item);
        }

        public decimal GetTotalAfterTax()
        {
            decimal subtotal = Items.Sum(item => (item.Book?.Price ?? 0m) * item.Quantity);
            decimal tax = decimal.Round(subtotal * TaxRate, 2, MidpointRounding.AwayFromZero);
            decimal total = subtotal + tax;
            return decimal.Round(total, 2, MidpointRounding.AwayFromZero);
        }
    }
}
