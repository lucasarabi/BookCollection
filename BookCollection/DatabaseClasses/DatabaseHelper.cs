using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; 

namespace BookCollection.Database
{
    internal class DatabaseHelper
    {
        private const string ConnectionString =
            @"Server=172.3.13.101,1433;Database=advwinprog;User Id=sa;Password=AdvWinPr0g!23R00T;TrustServerCertificate=True;Encrypt=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
