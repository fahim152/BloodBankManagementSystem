using BloodBank.Core;
using BloodBank.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class DonorUpdate : Form
    {
        Donors d = new Donors();
        string[] bloodGroups = { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
        string[] genders = { "Male", "Female", "Others" };
        public DonorUpdate(Donors d)
        {
            InitializeComponent();
            this.d = d; 
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
           DonorsService ds = new DonorsService();

           ds.Edit(d, d.Id);
            

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DonorUpdate_Load(object sender, EventArgs e)
        {
            nameBox.Text = d.Name;
            addressBox.Text = d.Address;
            genderBox.Text = d.Gender;
            phoneBox.Text = d.Phone;
            emailBox.Text = d.Email;
            weightBox.Text = d.Weight.ToString();
            bloodgroupBox.Text = d.BloodGroup;

            foreach (string str in bloodGroups)
            {
                bloodgroupBox.Items.Add(str);
            }

            foreach (string str in genders)
            {
                genderBox.Items.Add(str);
            }
        }

        private void bloodgroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
