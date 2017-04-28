using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BloodBank.Entity;

namespace BloodBank.Data
{
    class DonorsDataAccess
    {
        public int Add(Donors donors)
        {


            string query = string.Format("INSERT INTO donors VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", donors.Id, donors.Name, donors.Address, donors.Age, donors.Gender, donors.Phone, donors.Email, donors.BloodGroup, donors.Weight);
            return DataAccess.ExecuteQuery(query);

        }

        public int Remove(Donors donors)
        {
            string query = "DELETE FROM employee WHERE id=" + donors.Id;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Donors donors)
        {

            string query = "UPADATE donors SET Name='" + donors.Name + "' Password= '" + donors.Address + "' Designation= '" + donors.Age + "' Address= '" + donors.Gender + "' Phone= '" + donors.Phone + "' Email= '" + donors.Email + "' Gender= '" + donors.BloodGroup + "' WHERE id=" + donors.Weight;
            return DataAccess.ExecuteQuery(query);
        }

        public void RetrieveAll()
        {



        }


        public List<Employee> GetAll()
        {
            string query = "SELECT id, name, phone FROM employee";
            MySqlDataReader reader = DataAccess.GetData(query);

            Employee employee = null;
            List<Employee> employeeList = new List<Employee>();
            while (reader.Read())
            {
                employee = new Employee();
                employee.Id = Convert.ToInt32(reader["Id"]);
                employee.Name = reader["Name"].ToString();
                employee.Password = reader["Designation"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.Phone = reader["Phone"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Gender = reader["Gender"].ToString();

                employeeList.Add(employee);
            }
            return employeeList;
        }

        public Employee GetById(int id)
        {
            string query = "SELECT id, name, phone FROM employee WHERE id=" + id;
            MySqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Employee employee = null;
            if (reader.HasRows)
            {
                employee = new Employee();
                employee.Id = Convert.ToInt32(reader["Id"]);
                employee.Name = reader["Name"].ToString();
                employee.Password = reader["Designation"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.Phone = reader["Phone"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Gender = reader["Gender"].ToString();
            }
            return employee;
        }

        public string CheckLogin(int id, string password)
        {
            string query = string.Format("SELECT Designation FROM employee WHERE ID = '{0}' AND Password = '{1}'", id, password);
            string designation = null;
            MySqlDataReader reader = DataAccess.GetData(query);

            while (reader.Read())
            {
                designation = reader["Designation"].ToString();
            }

            return designation;
        }

        public object RowCount()
        {
            string query = "SELECT COUNT(*) FROM employee";
            return DataAccess.ExecuteScalar(query);
        }
    }

}
