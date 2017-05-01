using BloodBank.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data
{
    public class BloodDataAccess
    {
        public int Add(string bloodGroup, int quantity) 
        {
            string query = "Update blood_inventory SET Quantity = '" + quantity + "' WHERE Blood_Group = '" + bloodGroup +"'"; 
            return DataAccess.ExecuteQuery(query);
        }

        public int Update(string bloodGroup)  
        {
            string query = "UPDATE blood_inventory SET Quantity = Quantity + 1 WHERE Blood_Group = " + bloodGroup;
            return DataAccess.ExecuteQuery(query);
          
        }

        public int Reduce(string bloodGroup) {
            string query = "UPDATE blood_inventory SET Quantity = Quantity - 1 WHERE Blood_Group = " + bloodGroup;
            return DataAccess.ExecuteQuery(query);
        }

        public List<Blood> GetAll() {
            string query = "SELECT Blood_Group, Quantity FROM blood_inventory";
            MySqlDataReader reader = DataAccess.GetData(query);

            Blood blood = null;
            List<Blood> bloodList = new List<Blood>();

            while (reader.Read()) {
                blood = new Blood();

                blood.BloodGroup = reader["Blood_Group"].ToString();
                blood.Quantity = Convert.ToInt32(reader["Quantity"]);

                bloodList.Add(blood);
            }

            return bloodList;
        }

        public Blood GetByGroup(string bloodGroup)
        {
            string query = "SELECT * FROM blood_inventory WHERE Name = " + bloodGroup;
            MySqlDataReader reader = DataAccess.GetData(query);

            Blood blood = null;
            if (reader.HasRows)
            {
                blood = new Blood();

                blood.BloodGroup = reader["Blood_Group"].ToString();
                blood.Quantity = Convert.ToInt32(reader["Quantity"]);
            }

            return blood;
        }
        
        

        public int GetCurrentQuantity(string bloodGroup) {
            string query =  string.Format("SELECT Quantity FROM blood_inventory WHERE Blood_Group = '{0}'" , bloodGroup);
            //SELECT Quantity FROM blood_inventory WHERE Blood_Group = 'A+'
            int quantity = 0;
            MySqlDataReader reader = DataAccess.GetData(query);

            while (reader.Read())
            {
                quantity = int.Parse(reader[0].ToString());
            }

            return quantity;
        }
    }
}
