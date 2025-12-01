using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection.ObjectClasses
{
    public class Book
    {
        public required string Title { get; set; }
        public required string ISBN { get; set; }
        public required string Author { get; set; }
        public required DateTime PublishDate { get; set; }
        public required DateTime DateAdded { get; set; }
        public required string Publisher { get; set; }
        public required int NumOfPages { get; set; }
        public required string BookID { get; set; }
        public required decimal Price { get; set; }
        public required string Genre { get; set; }
        public required string BookType { get; set; }
        public required int quantity { get; set; }
    }
}
