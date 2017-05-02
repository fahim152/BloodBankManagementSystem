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
using BloodBank;
using BloodBank.Core;

namespace UserInterfaces
{
    public partial class StaffRegistration : Form
    {
        string[] designations = { "Admin", "Nurse", "Pathologist" };
        string[] genders = { "Male", "Female", "Others" };

        public StaffRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();

            int count = Convert.ToInt32(employeeService.RowCount());
            count +=1001;
            Employee employee = new Employee();
            employee.Id = count;
            employee.Name = nameBox.Text;
            employee.Password = passwordBox.Text;
            employee.Designation = (string)designationBox.SelectedItem;
            employee.Address = addressBox.Text;
            employee.Phone = phoneBox.Text;
            employee.Email = emailBox.Text;
            employee.Gender = (string)genderBox.SelectedItem;


            if (employeeService.Add(employee) > 0 && phoneBox.Text.Length == 11)
            {
                MessageBox.Show("Record Added Succesfully");
            }    

            else 
           
           {
               MessageBox.Show("Error Please provide a valid phone number");
           
           }
            
            
        }

        private void designationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            designationBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void StaffRegistration_Load(object sender, EventArgs e)
        {
            foreach (string str in designations)
            {
                designationBox.Items.Add(str);
            }

            foreach (string str in genders)
            {
                genderBox.Items.Add(str);
            }
        }

        private void genderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            genderBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            this.Hide();
            ap.ShowDialog();
            this.Close();
        }

        private void phoneBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
