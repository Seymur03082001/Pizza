using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Helper
{
    internal class SQl
    {
        static string connectionString = "Server=CA-R215-PC07\\SQLEXPRESS; Database=PIZZA; Trusted_Connection=True; Integrated Security=true";
        static SqlConnection _connection;

        public static SqlConnection Connection
        {
            get
            {
                if(_connection == null)
                {
                    _connection = new SqlConnection(connectionString);
                }
                return _connection;
            }
        }
        public static int ExecCommand(string command)
        {
            int result = 0;
            Connection.Open();
            using (SqlCommand cmd = new SqlCommand(command, Connection))
            {
                result = cmd.ExecuteNonQuery();
            }
            Connection.Close();
            return result;
        }
        public static DataTable ExecQuery(string query)
        {
            DataTable dt = new DataTable();
            Connection.Open();
            using (SqlDataAdapter sd = new SqlDataAdapter(query, Connection))
            {
                sd.Fill(dt);
            }
            Connection.Close();
            return dt;
        }
    }
}
