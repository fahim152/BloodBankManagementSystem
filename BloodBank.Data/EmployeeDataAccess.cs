using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Entity;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;

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
            string query = "UPDATE employee SET Name = '" + employee.Name + "', Password = '" + employee.Password + "', Designation = '" + employee.Designation + "', Address = '" + employee.Address + "', Phone = '" + employee.Phone + "', Email = '" + employee.Email + "', Gender = '" + employee.Gender + "' WHERE ID = " + employee.Id;
            //string query = "UPDATE Person SET Name='" + employee.Name + "' Password= '" + employee.Password + "' Designation= '" + employee.Designation + "' Address= '" + employee.Address + "' Phone= '" + employee.Phone + "' Email= '" + employee.Email + "' Gender= '" + employee.Gender + "' WHERE id=" + employee.Id;
            return DataAccess.ExecuteQuery(query);
        }

        public List<Employee> GetAll()
        {
            string query = "SELECT * FROM employee";
            MySqlDataReader reader = DataAccess.GetData(query);

            Employee employee = null;
            List<Employee> employeeList = new List<Employee>();
            while (reader.Read())
            {
                employee = new Employee();
                employee.Id = Convert.ToInt32(reader["ID"]);
                employee.Name = reader["Name"].ToString();
                employee.Password = reader["Password"].ToString();
                employee.Designation = reader["Designation"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.Phone = reader["Phone"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Gender = reader["Gender"].ToString();

                employeeList.Add(employee);
            }
            return employeeList;
        }

        public List<Employee> GetByName(string name)
        {
            name += "%";
            string query = "SELECT * FROM employee WHERE Name LIKE '" + name + "'";
            MySqlDataReader reader = DataAccess.GetData(query);
            reader.Read();
            Employee employee = null;
            List<Employee> employeeList = new List<Employee>();
            while (reader.Read())
            {
                employee = new Employee();
                employee.Id = Convert.ToInt32(reader["ID"]);
                employee.Name = reader["Name"].ToString();
                employee.Password = reader["Password"].ToString();
                employee.Designation = reader["Designation"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.Phone = reader["Phone"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Gender = reader["Gender"].ToString();

                employeeList.Add(employee);
            }
            return employeeList;
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

        public string GetPassword(string email) {
            string query = string.Format("SELECT Password FROM employee WHERE Email = '{0}'", email);
            string password = null;
            MySqlDataReader reader = DataAccess.GetData(query);

            while (reader.Read())
            {
                password = reader["Password"].ToString();
            }

            return password;
        }

        public bool SendEmployeePassword(string email, string password) {
            bool status;
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("bloodbank152@gmail.com");
                message.Subject = "Blood Bank Forgot Password";
                message.Body = "Dear Employee, You have requested to retrieve your password.\n\nHere is your old password " + password + "\n\nIf it was not you, please ignore this email, Thank you! \n\n<<<<<<<<<<This is an auto-generated email, please DO NOT reply to this email.>>>>>>>>>> \n\nSystem Admin : Fahim Ahmed & Arefin Mehedi Ibtesham";
                message.To.Add(email);

                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential("bloodbank152@gmail.com", "fahimarefin");
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
                status = true;
            }
            catch
            {
                status = false;
            }

            return status;
        }
    }
}
