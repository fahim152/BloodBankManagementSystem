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
            string query = string.Format("INSERT INTO donors VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", donors.Id, donors.Name, donors.Address, donors.Age, donors.Gender, donors.Phone, donors.Email, donors.BloodGroup, donors.Weight);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(int id)
        {
            string query = "DELETE FROM Donors WHERE id=" + id;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Donors donors)
        {

            string query = "UPADATE donors SET Name='" + donors.Name + "' Age= '" + donors.Age + "' Address= '" + donors.Address + "' Phone= '" + donors.Phone + "' Email= '" + donors.Email + "' Gender= '" + donors.Gender + "' Weight= '" + donors.Weight + "' Blood_Group= '" + donors.BloodGroup + "' WHERE id=" + donors.Id;
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
                donorsList.Add(donors);
            }
            return donorsList;
        }

        public Donors GetByName(string name)
        {
            string query = "SELECT ID, Name, Address, Age, Phone, Email, Gender, Weight, Blood_Group, Phone FROM donors WHERE Name = " +name;
            MySqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Donors donors = null;
            if (reader.HasRows)
            {
                donors = new Donors();
                donors.Id = Convert.ToInt32(reader["ID"]);
                donors.Name = reader["Name"].ToString();
                donors.Address = reader["Address"].ToString();
                donors.Age = Convert.ToInt32(reader["Age"]);
                donors.Phone = reader["Phone"].ToString();
                donors.Email = reader["Email"].ToString();
                donors.Gender = reader["Gender"].ToString();
                donors.Weight = Convert.ToInt32(reader["Weight"]);
                donors.BloodGroup = reader["Blood_Group"].ToString();
            }
            return donors;
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
    } 
}



