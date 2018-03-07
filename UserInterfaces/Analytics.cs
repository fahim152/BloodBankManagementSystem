using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBank.Core;
using BloodBank;
using UserInterfaces;

namespace BloodBank
{
    public partial class Analytics : Form
    {

        string firstDate;
        string secondDate;

        public Analytics()
        {
            InitializeComponent();
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            firstDate = date1.Value.ToString("yyyy/MM/dd");
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            secondDate = date2.Value.ToString("yyyy/MM/dd");
        }

        private void showDonors_Click(object sender, EventArgs e)
        {
            DonorsService ds = new DonorsService();
            Console.WriteLine(firstDate);
            Console.WriteLine(secondDate);
            dataGridView1.DataSource = ds.getDonorListByDate(firstDate, secondDate);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            this.Hide();
            ap.ShowDialog();
            this.Close();
        }
    }
}
