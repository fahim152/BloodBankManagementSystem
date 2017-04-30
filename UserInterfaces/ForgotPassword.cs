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

namespace BloodBank
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            string email = emailBox.Text;
            string password = employeeService.GetPassword(email);

            if (password != null)
            {
                if (employeeService.SendEmployeePassword(email, password))
                {
                    MessageBox.Show("Your password has been sent to your email, Please check your email!");
                }
            }
            else {
                MessageBox.Show("Your email is not registered! Please contact your administrator!");
            }
        }
    }
}
