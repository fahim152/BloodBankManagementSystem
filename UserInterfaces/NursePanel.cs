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

namespace UserInterfaces
{
    public partial class NursePanel : Form
    {
       
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
    }
}
