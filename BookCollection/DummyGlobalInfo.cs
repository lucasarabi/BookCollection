using BookCollection.ObjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection
{
    internal class DummyGlobalInfo
    {

        public static List<Book> ALL_BOOKS = new List<Book>();
        public static List<CartItem> CURRENT_CART = new List<CartItem>();
        public static List<Employee> ALL_EMPLOYEES = new List<Employee>();
        public static ShoppingCart CART = new ShoppingCart();
        public static List<Store> STORES = new List<Store>();

        public static void INITIALIZE_DUMMY_INFO()
        {
            ALL_BOOKS.Clear();
            CURRENT_CART.Clear();
            ALL_EMPLOYEES.Clear();
            CART = new ShoppingCart();
            STORES.Clear();

            ALL_BOOKS.Add(new Book("Dummy1", "1", "John Doe", DateTime.Today, DateTime.Today, "Some Publisher", 67, "1", 69.99m, "NonFiction", "Default", 1));
            ALL_BOOKS.Add(new Book("Dummy2", "2", "John Doe", DateTime.Today, DateTime.Today, "Some Publisher", 67, "2", 69.99m, "NonFiction", "Default", 1));
            ALL_BOOKS.Add(new Book("Dummy3", "3", "John Doe", DateTime.Today, DateTime.Today, "Some Publisher", 67, "3", 69.99m, "NonFiction", "Default", 1));
            ALL_BOOKS.Add(new Book("Dummy4", "4", "John Doe", DateTime.Today, DateTime.Today, "Some Publisher", 67, "4", 69.99m, "NonFiction", "Default", 1));

            ALL_EMPLOYEES.Add(new Employee("John Doe", 67.67m, DateTime.Today));

            STORES.Add(new Store("676767 SW 67th Ave", "Bikini Bottom", "Point Nemo", "67676", "BooksNStuff"));
        }

    }
}
