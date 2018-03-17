using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BloodBank.Entity;
using System.Net;
using System.Net.Mail;

namespace BloodBank.Data
{
    public class DonorsDataAccess
    {
        public int Add(Donors donors)
        {
            string query = string.Format("INSERT INTO donors VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}', '{10}')", donors.Id, donors.Name, donors.Address, donors.Age, donors.Gender, donors.Phone, donors.Email, donors.BloodGroup, donors.Weight, "Pending", donors.Date);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(int id)
        {
            string query = "DELETE FROM Donors WHERE id=" + id;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Donors donors)
        {
            string query = "UPDATE donors SET Name = '"+ donors.Name + "', Address = '"+ donors.Address + "', Age = '" + donors.Age + "', Gender = '" + donors.Gender + "', Phone = '" + donors.Phone + "', Blood_Group = '" + donors.BloodGroup + "', Weight = '" + donors.Weight + "' WHERE ID = " + donors.Id;
            //string query = "UPADATE donors SET Name='" + donors.Name + "' Age= '" + donors.Age + "' Address= '" + donors.Address + "' Phone= '" + donors.Phone + "' Email= '" + donors.Email + "' Gender= '" + donors.Gender + "' Weight= '" + donors.Weight + "' Blood_Group= '" + donors.BloodGroup + "' WHERE id=" + id;
            return DataAccess.ExecuteQuery(query);
        }

        public int ResetDate(int id, string date) {
            string query = string.Format("UPDATE donors SET Date = '{0}' WHERE ID = '{1}'", date, id);
            return DataAccess.ExecuteQuery(query);
        }

        public List<Donors> GetAll()
        {
            string query = "SELECT * FROM donors";
            MySqlDataReader reader = DataAccess.GetData(query);

            Donors donors = null;
            List<Donors> donorsList = new List<Donors>();
            while (reader.Read())
            {
                donors = new Donors();
                donors.Id = Convert.ToInt32(reader["ID"].ToString());
                donors.Name = reader["Name"].ToString();
                donors.Address = reader["Address"].ToString();
                donors.Age = Convert.ToInt32(reader["Age"].ToString());
                donors.Phone = reader["Phone"].ToString();
                donors.Email = reader["Email"].ToString();
                donors.Gender = reader["Gender"].ToString();
                donors.Weight = Convert.ToInt32(reader["Weight"].ToString());
                donors.BloodGroup = reader["Blood_Group"].ToString();
                donors.Status = reader["Status"].ToString();
                donors.Date = reader["Date"].ToString();
                donorsList.Add(donors);
            }
            return donorsList;
        }

        public List<Donors> GetByName(string name)
        {
            name += "%";
            string query = "SELECT * FROM donors WHERE Name LIKE '" + name + "'";
            MySqlDataReader reader = DataAccess.GetData(query);
            //reader.Read();

            Donors donors = null;
            List<Donors> donorsList = new List<Donors>();
            while (reader.Read())
            {
                donors = new Donors();
                donors.Id = Convert.ToInt32(reader["ID"].ToString());
                donors.Name = reader["Name"].ToString();
                donors.Address = reader["Address"].ToString();
                donors.Age = Convert.ToInt32(reader["Age"].ToString());
                donors.Phone = reader["Phone"].ToString();
                donors.Email = reader["Email"].ToString();
                donors.Gender = reader["Gender"].ToString();
                donors.Weight = Convert.ToInt32(reader["Weight"].ToString());
                donors.BloodGroup = reader["Blood_Group"].ToString();
                donors.Status = reader["Status"].ToString();
                donors.Date = reader["Date"].ToString();
                donorsList.Add(donors);
            }
            return donorsList;
        }

        public List<Donors> getDonorListByEmail(string email) {
            email += "%";
            string query = "SELECT * FROM donors WHERE Email LIKE '" + email + "'";
            MySqlDataReader reader = DataAccess.GetData(query);
            //reader.Read();

            Donors donors = null;
            List<Donors> donorsList = new List<Donors>();
            while (reader.Read())
            {
                donors = new Donors();
                donors.Id = Convert.ToInt32(reader["ID"].ToString());
                donors.Name = reader["Name"].ToString();
                donors.Address = reader["Address"].ToString();
                donors.Age = Convert.ToInt32(reader["Age"].ToString());
                donors.Phone = reader["Phone"].ToString();
                donors.Email = reader["Email"].ToString();
                donors.Gender = reader["Gender"].ToString();
                donors.Weight = Convert.ToInt32(reader["Weight"].ToString());
                donors.BloodGroup = reader["Blood_Group"].ToString();
                donors.Status = reader["Status"].ToString();
                donors.Date = reader["Date"].ToString();
                donorsList.Add(donors);
            }
            return donorsList;
        }

        public List<Donors> getDonorListByPhone(string phone) {
            phone += "%";
            string query = "SELECT * FROM donors WHERE Phone LIKE '" + phone + "'";
            MySqlDataReader reader = DataAccess.GetData(query);
            //reader.Read();

            Donors donors = null;
            List<Donors> donorsList = new List<Donors>();
            while (reader.Read())
            {
                donors = new Donors();
                donors.Id = Convert.ToInt32(reader["ID"].ToString());
                donors.Name = reader["Name"].ToString();
                donors.Address = reader["Address"].ToString();
                donors.Age = Convert.ToInt32(reader["Age"].ToString());
                donors.Phone = reader["Phone"].ToString();
                donors.Email = reader["Email"].ToString();
                donors.Gender = reader["Gender"].ToString();
                donors.Weight = Convert.ToInt32(reader["Weight"].ToString());
                donors.BloodGroup = reader["Blood_Group"].ToString();
                donors.Status = reader["Status"].ToString();
                donors.Date = reader["Date"].ToString();
                donorsList.Add(donors);
            }
            return donorsList;
        }

        public List<Donors> getDonorListByBloodGroup(string bloodGroup) {
            bloodGroup += "%";
            string query = "SELECT * FROM donors WHERE Blood_Group LIKE '" + bloodGroup + "'";
            MySqlDataReader reader = DataAccess.GetData(query);
            //reader.Read();

            Donors donors = null;
            List<Donors> donorsList = new List<Donors>();
            while (reader.Read())
            {
                donors = new Donors();
                donors.Id = Convert.ToInt32(reader["ID"].ToString());
                donors.Name = reader["Name"].ToString();
                donors.Address = reader["Address"].ToString();
                donors.Age = Convert.ToInt32(reader["Age"].ToString());
                donors.Phone = reader["Phone"].ToString();
                donors.Email = reader["Email"].ToString();
                donors.Gender = reader["Gender"].ToString();
                donors.Weight = Convert.ToInt32(reader["Weight"].ToString());
                donors.BloodGroup = reader["Blood_Group"].ToString();
                donors.Status = reader["Status"].ToString();
                donors.Date = reader["Date"].ToString();
                donorsList.Add(donors);
            }
            return donorsList;
        }

        public bool SendDonorEmail(string donorEmail) 

        {
            bool status;
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("bloodbank152@gmail.com");
                message.Subject = "Blood Bank Registration";
                message.Body = " Dear Donor, Thank you for registering and for your donation. Your contribution may help to save a life.\n \n \n <<<<<<<<<<  This is an Auto Generated Email. Please Do not reply to this email >>>>>>>>>> \n\n  Blood Bank Management System \n System Admin : Fahim Ahmed & Arefin Mehedi Ibtesham";
                message.To.Add(donorEmail);

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

        public object RowCount()
        {
            string query = "SELECT COUNT(*) FROM donors";
            return DataAccess.ExecuteScalar(query);
        }


        public int ChangeStatus(Donors donors) {
            string query = "UPDATE donors SET Status = '"+ donors.Status +"' WHERE ID = " + donors.Id;
            return DataAccess.ExecuteQuery(query);
        }

        public List<Donors> getDonorListByDate(string firstDate, string secondDate) {
            string query = string.Format("SELECT * FROM donors WHERE (date BETWEEN '{0}' AND '{1}')",firstDate, secondDate);
            MySqlDataReader reader = DataAccess.GetData(query);
            //reader.Read();

            Donors donors = null;
            List<Donors> donorsList = new List<Donors>();
            while (reader.Read())
            {
                donors = new Donors();
                donors.Id = Convert.ToInt32(reader["ID"].ToString());
                donors.Name = reader["Name"].ToString();
                donors.Address = reader["Address"].ToString();
                donors.Age = Convert.ToInt32(reader["Age"].ToString());
                donors.Phone = reader["Phone"].ToString();
                donors.Email = reader["Email"].ToString();
                donors.Gender = reader["Gender"].ToString();
                donors.Weight = Convert.ToInt32(reader["Weight"].ToString());
                donors.BloodGroup = reader["Blood_Group"].ToString();
                donors.Status = reader["Status"].ToString();
                donors.Date = reader["Date"].ToString();
                donorsList.Add(donors);
            }
            return donorsList;
        }

        public int resetDonorStatus(int id) {
            string query = string.Format("UPDATE donors SET Status = '{0}' WHERE ID = '{1}'", "Pending", id);
            return DataAccess.ExecuteQuery(query);
        }

    } 
}



