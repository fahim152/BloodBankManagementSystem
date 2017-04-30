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

namespace BloodBank
{
    public partial class Blood_Inventory : Form
    {
        public Blood_Inventory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackProfile_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            this.Hide();
            ap.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Blood_Inventory_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            BloodService bs = new BloodService();
            dataGridView1.DataSource = bs.GetAll();
=======
            BloodService bloodService = new BloodService();
            dataGridView1.DataSource = bloodService.GetAll();
>>>>>>> origin/master
        }
    }
}
