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
using UserInterfaces;

namespace BloodBank
{
    public partial class EmployeeUpdate : Form
    {
        Employee emp = null;
        string[] designations = { "Admin", "Nurse", "Pathologist" };
        string[] genders = { "Male", "Female", "Others" };

        public EmployeeUpdate(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            emp.Name = nameBox.Text;
            emp.Address = addressBox.Text;
            emp.Gender = genderBox.Text;
            emp.Phone = phoneBox.Text;
            emp.Email = emailBox.Text;
            emp.Designation = designationBox.Text;
            emp.Password = passwordBox.Text;

           EmployeeService es = new EmployeeService();

            if (es.Edit(emp) > 0)
            {
                MessageBox.Show("Record Updated Successfully!");
                AdminPanel ap = new AdminPanel();
                ap.LoadData();
            }

         }

        private void EmployeeUpdate_Load(object sender, EventArgs e)
        {
             nameBox.Text = emp.Name ;
             addressBox.Text = emp.Address;
             genderBox.Text = emp.Gender.ToString(); ;
             phoneBox.Text = emp.Phone;
             emailBox.Text = emp.Email;
             designationBox.Text = emp.Designation.ToString() ;
             passwordBox.Text = emp.Password ;

             foreach (string str in designations)
             {
                 designationBox.Items.Add(str);
             }

             foreach (string str in genders)
             {
                 genderBox.Items.Add(str);
             }
        }

      }
 }



