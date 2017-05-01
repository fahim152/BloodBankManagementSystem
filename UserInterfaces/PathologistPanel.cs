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

namespace UserInterfaces
{
    public partial class PathologistPanel : Form
    {
        string[] statuses = { "Approve", "Deny" };
        Donors donors = new Donors();

        public PathologistPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPanel lp = new LoginPanel();
            this.Hide();
            lp.ShowDialog();
            this.Close();
        }

        private void PathologistPanel_Load(object sender, EventArgs e)
        {
            foreach (string str in statuses)
            {
                statusBox.Items.Add(str);
            }
            LoadData();
        }

        public void LoadData() {
            dataGridView1.ReadOnly = true;
            DonorsService donorsService = new DonorsService();
            dataGridView1.DataSource = donorsService.GetAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            donors.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            donors.Status = (string)statusBox.SelectedItem;
            DonorsService donorsService = new DonorsService();

            if (donorsService.ChangeStatus(donors) > 0) {
                LoadData();
            }
        }
    }
}
