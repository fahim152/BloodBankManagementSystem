using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data
{
    public static class DataAccess
    {
        static MySqlConnection conn;

        static MySqlConnection Connection
        {
            get
            {
                string connString = "Server=localhost;Uid=root;Database=blood_bank";
                conn = new MySqlConnection(connString);
                conn.Open();
                return conn;
            }
        }

        public static int ExecuteQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            return cmd.ExecuteNonQuery();
        }

        public static MySqlDataReader GetData(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            return cmd.ExecuteReader();
        }

        public static object ExecuteScalar(string query) {
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            object obj = cmd.ExecuteScalar();
            return obj;
        }
    }
}
