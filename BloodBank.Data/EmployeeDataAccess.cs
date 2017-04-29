using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Entity;
using MySql.Data.MySqlClient;

namespace BloodBank.Data
{
    public class EmployeeDataAccess
    {
        public int Add(Employee employee)
        {
            string query = string.Format("INSERT INTO employee VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", employee.Id, employee.Name, employee.Password, employee.Designation, employee.Address, employee.Phone, employee.Email, employee.Gender);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(int id)
        {
            string query = "DELETE FROM employee WHERE id=" + id;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Employee employee)
        {
            string query = "UPADATE Person SET Name='" + employee.Name + "' Password= '" + employee.Password + "' Designation= '" + employee.Designation + "' Address= '" + employee.Address + "' Phone= '" + employee.Phone + "' Email= '" + employee.Email + "' Gender= '" + employee.Gender + "' WHERE id=" + employee.Id;
            return DataAccess.ExecuteQuery(query);
        }

        public List<Employee> GetAll()
        {
            string query = "SELECT ID, Name, Phone, Email, Password, Address, Gender FROM employee";
            MySqlDataReader reader = DataAccess.GetData(query);

            Employee employee = null;
            List<Employee> employeeList = new List<Employee>();
            while (reader.Read())
            {
                employee = new Employee();
                employee.Id = Convert.ToInt32(reader["ID"]);
                employee.Name = reader["Name"].ToString();
                employee.Password = reader["Password"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.Phone = reader["Phone"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Gender = reader["Gender"].ToString();

                employeeList.Add(employee);
            }
            return employeeList;
        }

        public Employee GetByName(string name)
        {
            string query = "SELECT ID, Name, Phone, Email, Password, Address, Gender FROM employee WHERE Name = "+name;
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

        public string CheckLogin(int id, string password) {
            string query = string.Format("SELECT Designation FROM employee WHERE ID = '{0}' AND Password = '{1}'", id, password);
            string designation = null;
            MySqlDataReader reader = DataAccess.GetData(query);

            while (reader.Read()) {
                designation = reader["Designation"].ToString();
            }

            return designation;
        }

        public object RowCount() {
            string query = "SELECT COUNT(*) FROM employee";
            return DataAccess.ExecuteScalar(query);
        }
    }
}
