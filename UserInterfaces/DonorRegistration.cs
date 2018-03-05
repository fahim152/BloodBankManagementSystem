using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterfaces;
using System.Net;
using System.Net.Mail;
using BloodBank.Core;
using BloodBank.Entity;

namespace UserInterfaces
{
    public partial class DonorRegistration : Form
    {
        string[] bloodGroups = {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"};
        string[] genders = { "Male", "Female", "Others" };

        public DonorRegistration()
        {
            InitializeComponent();
            
        }

        private void comboBoxBlooadgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DonorName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DonorRegister_Click(object sender, EventArgs e)
        {

            DonorsService donorsService = new DonorsService();
            Donors donors = new Donors();
            Blood blood = new Blood();

            int count = Convert.ToInt32(donorsService.RowCount());

            donors.Id = count += 101;
            donors.Name = DonorName.Text;
            donors.Address = DonorAddress.Text;
            donors.Age = Convert.ToInt32(DonorAge.Text);
            donors.Gender = (string)DonorGender.SelectedItem;
            donors.Phone = DonorPhone.Text;
            donors.Email = DonorEmail.Text;
            donors.BloodGroup = (string)DonorBloodGroup.SelectedItem;
            donors.Weight = Convert.ToInt32(DonorWeight.Text);

            DateTime dateTime = DateTime.UtcNow.Date;
            donors.Date = dateTime.ToString("yyyy/MM/dd");

            BloodService bloodService = new BloodService();

            string bloodGroup = (string)DonorBloodGroup.SelectedItem;
            int  quantity = bloodService.GetCurrentQuantity(bloodGroup);

            quantity += 1;
            bloodService.Add(bloodGroup, quantity);

            
            if (donorsService.SendDonorEmail(donors.Email) && DonorPhone.Text.Length == 11)
            {
                if(donorsService.Add(donors) > 0)
                {
                    MessageBox.Show("Record Added!");
                }
            }
      

            else {
                MessageBox.Show("Error! Please Check your Mail or Provide a Valid Phone number");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            NursePanel ns = new NursePanel();
            this.Hide();
            ns.ShowDialog();
            this.Close();

        }

        private void DonorRegistration_Load(object sender, EventArgs e)
        {
            foreach (string str in bloodGroups)
            {
                DonorBloodGroup.Items.Add(str);
            }

            foreach (string str in genders)
            {
                DonorGender.Items.Add(str);
            }
        }

        private void DonorEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void DonorPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
