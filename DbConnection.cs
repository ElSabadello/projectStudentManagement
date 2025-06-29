using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace projectStudentManagement
{
    internal class DbConnection
    {
        public static readonly string _connectionString = "SERVER=localhost;DATABASE=student_information;UID=root;";
        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(_connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (MySqlException ex) {
                MessageBox.Show("Database Connection FAILED");
                throw;
            }
        }
    }
}
