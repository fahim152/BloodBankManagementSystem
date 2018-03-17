using BloodBank.Core;
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
using BloodBank.Entity;

namespace UserInterfaces
{
    public partial class NursePanel : Form
    {
        string[] filters = { "Name", "Phone", "Email", "Blood Group" };
        Donors donors = new Donors();
        DateTime donorDate;
        public NursePanel()
        {
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addANewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorRegistration dn = new DonorRegistration();
            this.Hide();
            dn.ShowDialog();
            this.Close();

        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginPanel lp = new LoginPanel();
            this.Hide();
            lp.ShowDialog();
            this.Close();
        }

        private void NursePanel_Load(object sender, EventArgs e)
        {
            foreach (string item in filters)
            {
                filterBox.Items.Add(item);
            }
            LoadData();
        }

        public void LoadData() {
            dataGridView1.ReadOnly = false;
            DonorsService donorsService = new DonorsService();
            dataGridView1.DataSource = donorsService.GetAll();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string filteredItem = (string)filterBox.SelectedItem;
            string query = searchBox.Text;
            DonorsService ds = new DonorsService();

            if (filteredItem == "Name")
            {
                dataGridView1.DataSource = ds.GetByName(query);
            }
            else if (filteredItem == "Email")
            {
                dataGridView1.DataSource = ds.getDonorListByEmail(query);
            }
            else if (filteredItem == "Phone")
            {
                dataGridView1.DataSource = ds.getDonorListByPhone(query);
            }
            else if (filteredItem == "Blood Group")
            {
                dataGridView1.DataSource = ds.getDonorListByBloodGroup(query);
            }
            else
            {
                MessageBox.Show("Please select a filter to search for");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            donors.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            donorDate = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["Date"].Value.ToString());
            //donors.Date = donorDate.ToString("yyyy/MM/dd");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DonorsService ds = new DonorsService();
            //MessageBox.Show(donors.Date);

            DateTime now = DateTime.UtcNow.Date;
            donors.Date = now.ToString("yyyy/MM/dd");

            TimeSpan difference = now - donorDate;

            if (difference.TotalDays >= 90)
            {
                if (ds.resetDonorStatus(donors.Id) > 0)
                {
                    ds.ResetDate(donors.Id, donors.Date);
                    LoadData();
                }
            }
            else {
                MessageBox.Show("Sorry, you at least need to wait for 90 days before you can donate blood again!");
            }
        }
    }
}
