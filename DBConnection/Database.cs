using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace DBConnection
{
    public class Database
    {
        public static void Main(String[] args) {

        }


        public bool InsertDonor(int id, string name, string address, int age, string gender, string phone, string email, string bloodGroup, int weight) {

            bool status;
            string connString = "Server=localhost;Uid=root;Database=blood_bank";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("INSERT INTO donors (ID, Name, Address, Age, Gender, Phone, Email, Blood_Group, Weight) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", id, name, address, age, gender, phone, email, bloodGroup, weight);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                status = true;
            }
            else {
                status = false;
            }
            conn.Close();

            return status;

        }

        public bool Login(int userid, string password)
        {
            bool status;
            string connString = "Server=localhost;Uid=root;Database=blood_bank";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("SELECT * FROM employee WHERE ID = '{0}' AND Password = '{1}'", userid, password);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            //string str = Convert.ToString(cmd.ExecuteScalar());
            //status = int.Parse(str);
            if (reader.Read())
            {
                status = true;
            }
            else {
                status = false;
            }
            
            //cmd.ExecuteNonQuery();
            conn.Close();
            return status;

        }

        public DataSet retrieveDonorData() {

            string connString = "Server=localhost;Uid=root;Database=blood_bank";
            MySqlConnection conn = new MySqlConnection(connString);
            string query = "SELECT * FROM donors";
            conn.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder cmdBuilder = new MySqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            return ds;
        }

        public bool RegisterEmployee(string name, int id, string password, string designation, string address, string phone, string email, string gender) {
            bool status;
            string connString = "Server=localhost;Uid=root;Database=blood_bank";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("INSERT INTO employee (ID, Name, Password, Designation, Address, Phone, Email, Gender) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", id, name, password, designation, address, phone, email, gender);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            conn.Close();

            return status;
        }

        public DataSet SearchDonor(string name) {
            string connString = "Server=localhost;Uid=root;Database=blood_bank";
            string p = "%";
            MySqlConnection conn = new MySqlConnection(connString);
            string query = "SELECT * FROM donors WHERE Name LIKE '"+name+ "' '" + p + "'";
            conn.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder cmdBuilder = new MySqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            return ds;
        }

        public DataSet SearchEmployee(string name)
        {
            string connString = "Server=localhost;Uid=root;Database=blood_bank";
            string p = "%";
            MySqlConnection conn = new MySqlConnection(connString);
            string query = "SELECT * FROM employee WHERE Name LIKE '" + name + "' '" + p + "'";
            conn.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder cmdBuilder = new MySqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            return ds;
        }
    }
}
