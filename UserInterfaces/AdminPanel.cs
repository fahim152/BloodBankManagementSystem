using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBank;

namespace UserInterfaces
{
    public partial class AdminPanel : Form
    {
        

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPanel lp = new LoginPanel();
            this.Hide();
            lp.ShowDialog();
            this.Close();
        }

        private void registerStaffChemistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffRegistration sf = new StaffRegistration();
            this.Hide();
            sf.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
