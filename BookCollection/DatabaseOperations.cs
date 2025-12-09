using System;
using System.Data;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using BookCollection.ObjectClasses;

namespace BookCollection
{
    internal class DatabaseOperations
    {

        // FOR SOME REASON, MY COMPUTER DOESN'T WANT TO WORK WITH THE VISUAL STUDIO MSSQL DB SO I USED ONE IN A DOCKER CONTAINER RUNNING ON MY SERVER
        private static string connectionString = "Server=172.3.13.101,1433;Database=advwinprog;User Id=sa;Password=AdvWinPr0g!23R00T;TrustServerCertificate=True;Encrypt=True;";

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
        /**
         * EXAMPLE
         *  string query = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Books')
            BEGIN
                CREATE TABLE Books (
                    ID INT IDENTITY(1,1) PRIMARY KEY,
                    ...
                );
            END";
         * */
        public static void ExecuteFromSQLString(string sqlString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {


                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT BookID, Title, ISBN, Author, PublishDate, DateAdded, 
                         Publisher, NumOfPages, Price, Genre, BookType, Quantity 
                         FROM Books";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Book book = new Book(
                                reader["Title"].ToString(),
                                reader["ISBN"].ToString(),
                                reader["Author"].ToString(),
                                reader["PublishDate"] != DBNull.Value ? Convert.ToDateTime(reader["PublishDate"]) : DateTime.MinValue,
                                reader["DateAdded"] != DBNull.Value ? Convert.ToDateTime(reader["DateAdded"]) : DateTime.Now,
                                reader["Publisher"].ToString(),
                                reader["NumOfPages"] != DBNull.Value ? Convert.ToInt32(reader["NumOfPages"]) : 0,
                                reader["BookID"].ToString(),
                                reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0m,
                                reader["Genre"].ToString(),
                                reader["BookType"].ToString(),
                                reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0
                            );
                            books.Add(book);
                        }
                    }
                }
            }
            return books;
        }

        public static Book? GetBookById(string bookId)
        {
            Book? book = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT BookID, Title, ISBN, Author, PublishDate, DateAdded, 
                         Publisher, NumOfPages, Price, Genre, BookType, Quantity 
                         FROM Books WHERE BookID = @BookID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookId);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            book = new Book(
                                reader["Title"].ToString(),
                                reader["ISBN"].ToString(),
                                reader["Author"].ToString(),
                                reader["PublishDate"] != DBNull.Value ? Convert.ToDateTime(reader["PublishDate"]) : DateTime.MinValue,
                                reader["DateAdded"] != DBNull.Value ? Convert.ToDateTime(reader["DateAdded"]) : DateTime.Now,
                                reader["Publisher"].ToString(),
                                reader["NumOfPages"] != DBNull.Value ? Convert.ToInt32(reader["NumOfPages"]) : 0,
                                reader["BookID"].ToString(),
                                reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0m,
                                reader["Genre"].ToString(),
                                reader["BookType"].ToString(),
                                reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0
                            );
                        }
                    }
                }
            }
            return book;
        }

        public static string InsertBook(Book book)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Books (BookID, Title, ISBN, Author, PublishDate, DateAdded, 
                         Publisher, NumOfPages, Price, Genre, BookType, Quantity) 
                         VALUES (@BookID, @Title, @ISBN, @Author, @PublishDate, @DateAdded, 
                         @Publisher, @NumOfPages, @Price, @Genre, @BookType, @Quantity);
                         SELECT @BookID;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", book.BookID);
                    cmd.Parameters.AddWithValue("@Title", book.Title);
                    cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                    cmd.Parameters.AddWithValue("@Author", book.Author);
                    cmd.Parameters.AddWithValue("@PublishDate", book.PublishDate);
                    cmd.Parameters.AddWithValue("@DateAdded", book.DateAdded);
                    cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
                    cmd.Parameters.AddWithValue("@NumOfPages", book.NumOfPages);
                    cmd.Parameters.AddWithValue("@Price", book.Price);
                    cmd.Parameters.AddWithValue("@Genre", book.Genre);
                    cmd.Parameters.AddWithValue("@BookType", book.BookType);
                    cmd.Parameters.AddWithValue("@Quantity", book.Quantity);

                    conn.Open();
                    string newId = cmd.ExecuteScalar().ToString();
                    return newId;
                }
            }
        }
    }
}
