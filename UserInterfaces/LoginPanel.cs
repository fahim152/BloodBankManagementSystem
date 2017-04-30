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
using BloodBank;
using BloodBank.Core;

namespace UserInterfaces
{
    public partial class LoginPanel : Form
    {

        public LoginPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(userNameBox.Text);
            string password = passwordBox.Text;
            EmployeeService employeeService = new EmployeeService();

            if (employeeService.CheckLogin(id, password) == "Admin")
            {
                AdminPanel ap = new AdminPanel();
                this.Hide();
                ap.ShowDialog();
                this.Close();
            }
            else if (employeeService.CheckLogin(id, password) == "Pathologist")
            {
                PathologistPanel pp = new PathologistPanel();
                this.Hide();
                pp.ShowDialog();
                this.Close();
            }
            else if (employeeService.CheckLogin(id, password) == "Nurse")
            {
                NursePanel np = new NursePanel();
                this.Hide();
                np.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid User id or Password!!");
            }
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {

        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button b = new Button();
                e.SuppressKeyPress = true;
                
            }
        }

        private void userNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                 e.SuppressKeyPress = true;
        }

        private void ForrgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.ShowDialog();
        }
    }
}
