using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection.ObjectClasses
{
    public class CartItem
    {
        public required Book Book { get; set; }
        public required int Quantity { get; set; }

        public decimal Subtotal => Book.Price * Quantity;
    }
}

