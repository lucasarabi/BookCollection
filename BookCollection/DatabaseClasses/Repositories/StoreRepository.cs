using BookCollection.Database;
using BookCollection.ObjectClasses;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection.DatabaseClasses.Repositories
{
    internal class StoreRepository
    {
        public void Add(Store store)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO Stores (Name, Address, City, State, ZipCode) VALUES (@name, @addr, @city, @state, @zip)";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", store.name);
                    cmd.Parameters.AddWithValue("@addr", store.address);
                    cmd.Parameters.AddWithValue("@city", store.city);
                    cmd.Parameters.AddWithValue("@state", store.state);
                    cmd.Parameters.AddWithValue("@zip", store.zipCode);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Dictionary<int, Store> GetAll()
        {
            var list = new Dictionary<int, Store>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Stores", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["StoreID"];
                        var s = new Store
                        {
                            name = reader["Name"].ToString(),
                            address = reader["Address"].ToString(),
                            city = reader["City"].ToString(),
                            state = reader["State"].ToString(),
                            zipCode = reader["ZipCode"].ToString()
                        };
                        list.Add(id, s);
                    }
                }
            }
            return list;
        }
        public void Delete(int storeId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM Stores WHERE StoreID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", storeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
