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
    class DonorsDataAccess
    {
        public int Add(Donors donors)
        {


            string query = string.Format("INSERT INTO donors VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", donors.Id, donors.Name, donors.Address, donors.Age, donors.Gender, donors.Phone, donors.Email, donors.BloodGroup, donors.Weight);
            return DataAccess.ExecuteQuery(query);

        }

        public int Remove(Donors donors)
        {
            string query = "DELETE FROM Donors WHERE id=" + donors.Id;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Donors donors)
        {

            string query = "UPADATE donors SET Name='" + donors.Name  + "' Age= '" + donors.Age + "' Address= '" + donors.Address + "' Phone= '" + donors.Phone + "' Email= '" + donors.Email + "' Gender= '" + donors.Gender + "' Weight= '" + donors.Weight + "' Blood_Group= '" + donors.BloodGroup + "' WHERE id=" + donors.Id;
            return DataAccess.ExecuteQuery(query);
        }

        public List<Donors> GetAll()
        {
            string query = "SELECT ID, Name, Address, Age, Phone, Email, Gender, Weight, Blood_Group, Phone FROM donors";
            MySqlDataReader reader = DataAccess.GetData(query);

            Donors donors = null;
            List<Donors> donorsList = new List<Donors>();
            while (reader.Read())
            {
                donors = new Donors();
                donors.Id = Convert.ToInt32(reader["Id"]);
                donors.Name = reader["Name"].ToString();
                donors.Address = reader["Address"].ToString();
                donors.Age = Convert.ToInt32(reader["Age"]);
                donors.Phone = reader["Phone"].ToString();
                donors.Email = reader["Email"].ToString();
                donors.Gender = reader["Gender"].ToString();
                donors.Weight = Convert.ToInt32(reader["Address"]);
                donors.BloodGroup = reader["Blood_Group"].ToString();
                donorsList.Add(donors);
            }
            return donorsList;
        }

        public Donors GetById(int id)
        {
            string query = "SELECT ID, Name, Address, Age, Phone, Email, Gender, Weight, Blood_Group, Phone FROM donors WHERE id=" + id;
            MySqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Donors donors = null;
            if (reader.HasRows)
            {
                donors = new Donors();
                donors.Id = Convert.ToInt32(reader["Id"]);
                donors.Name = reader["Name"].ToString();
                donors.Address = reader["Address"].ToString();
                donors.Age = Convert.ToInt32(reader["Age"]);
                donors.Phone = reader["Phone"].ToString();
                donors.Email = reader["Email"].ToString();
                donors.Gender = reader["Gender"].ToString();
                donors.Weight = Convert.ToInt32(reader["Address"]);
                donors.BloodGroup = reader["Blood_Group"].ToString();
            }
            return donors;
        }

        public void DonorEmail() 
        {

            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("bloodbank152@gmail.com");
                message.Subject = "Blood Bank Registration";
                message.Body = " Dear Donor, Thanks for registering and for your donation. Your contribution may help to save one life. /n This is Auto Generated Mail. Please Do not reply this mail";
                message.To.Add("fahim152@gmail.com");

                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential("bloodbank152@gmail.com", "fahimarefin");
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
            }
            catch
            {
               


            }

        } 
    }

}
