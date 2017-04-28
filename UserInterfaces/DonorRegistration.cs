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
    public partial class DonorRegistration : Form
    {

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
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            NursePanel ns = new NursePanel();
            this.Hide();
            ns.ShowDialog();
            this.Close();

        }
    }
}
