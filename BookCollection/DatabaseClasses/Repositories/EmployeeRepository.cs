using BookCollection.ObjectClasses;
using BookCollection.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BookCollection.Repsitories
{
    internal class EmployeeRepository
    {
        public static void Add(Employee emp)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO Employees (Name, Pay, Birthday) VALUES (@name, @pay, @dob)";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", emp.Name);
                    cmd.Parameters.AddWithValue("@pay", emp.pay);
                    cmd.Parameters.AddWithValue("@dob", emp.Birthday);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Employee emp)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE Employees SET Name = @name, Pay = @pay, Birthday = @dob WHERE EmployeeID = @id";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", emp.EmployeeID);
                    cmd.Parameters.AddWithValue("@name", emp.Name);
                    cmd.Parameters.AddWithValue("@pay", emp.pay);
                    cmd.Parameters.AddWithValue("@dob", emp.Birthday);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Employee> GetAll()
        {
            var list = new List<Employee>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Employees", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Employee
                        {
                            EmployeeID = (int)reader["EmployeeID"],
                            Name = reader["Name"].ToString(),
                            pay = (decimal)reader["Pay"],
                            Birthday = (DateTime)reader["Birthday"]
                        });
                    }
                }
            }
            return list;
        }
        public static void Delete(int employeeId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", employeeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}