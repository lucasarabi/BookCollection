using BookCollection.Database;
using BookCollection.ObjectClasses;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection.DatabaseClasses.Repositories
{
    internal static class BookRepository
    {
        public static void Add(Book book)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO Books (BookID, Title, ISBN, Author, PublishDate, DateAdded, Publisher, NumOfPages, Price, Genre, BookType, Quantity) 
                               VALUES (@id, @title, @isbn, @author, @pDate, @dAdded, @pub, @pages, @price, @genre, @type, @qty)";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", book.BookID);
                    cmd.Parameters.AddWithValue("@title", book.Title);
                    cmd.Parameters.AddWithValue("@isbn", book.ISBN);
                    cmd.Parameters.AddWithValue("@author", book.Author);
                    cmd.Parameters.AddWithValue("@pDate", book.PublishDate);
                    cmd.Parameters.AddWithValue("@dAdded", book.DateAdded);
                    cmd.Parameters.AddWithValue("@pub", book.Publisher);
                    cmd.Parameters.AddWithValue("@pages", book.NumOfPages);
                    cmd.Parameters.AddWithValue("@price", book.Price);
                    cmd.Parameters.AddWithValue("@genre", book.Genre);
                    cmd.Parameters.AddWithValue("@type", book.BookType);
                    cmd.Parameters.AddWithValue("@qty", book.quantity);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Book> GetAll()
        {
            var list = new List<Book>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Books";

                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Book
                        {
                            BookID = reader["BookID"].ToString(),
                            Title = reader["Title"].ToString(),
                            ISBN = reader["ISBN"].ToString(),
                            Author = reader["Author"].ToString(),
                            PublishDate = (DateTime)reader["PublishDate"],
                            DateAdded = (DateTime)reader["DateAdded"],
                            Publisher = reader["Publisher"].ToString(),
                            NumOfPages = (int)reader["NumOfPages"],
                            Price = (decimal)reader["Price"],
                            Genre = reader["Genre"].ToString(),
                            BookType = reader["BookType"].ToString(),
                            quantity = (int)reader["Quantity"]
                        });
                    }
                }
            }
            return list;
        }

        public static Book? GetById(string bookID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Books WHERE BookID = @id";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", bookID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Book
                            {
                                BookID = reader["BookID"].ToString(),
                                Title = reader["Title"].ToString(),
                                ISBN = reader["ISBN"].ToString(),
                                Author = reader["Author"].ToString(),
                                PublishDate = (DateTime)reader["PublishDate"],
                                DateAdded = (DateTime)reader["DateAdded"],
                                Publisher = reader["Publisher"].ToString(),
                                NumOfPages = (int)reader["NumOfPages"],
                                Price = (decimal)reader["Price"],
                                Genre = reader["Genre"].ToString(),
                                BookType = reader["BookType"].ToString(),
                                quantity = (int)reader["Quantity"]
                            };
                        }
                    }
                }
            }

            return null; 
        }

        public static void Update(Book book)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE Books SET Price = @price, Quantity = @qty WHERE BookID = @id";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@price", book.Price);
                    cmd.Parameters.AddWithValue("@qty", book.quantity);
                    cmd.Parameters.AddWithValue("@id", book.BookID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(string bookID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Books WHERE BookID = @id";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", bookID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
