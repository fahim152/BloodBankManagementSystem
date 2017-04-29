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
using BloodBank.Entity;

namespace UserInterfaces
{
    public partial class AdminPanel : Form
    {
        string idTextDonor;
        int idDonor;
        string idTextEmployee;
        int idEmployee;
        Donors d = new Donors();

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
            LoadData();
        }

        private void donorNameBox_TextChanged(object sender, EventArgs e)
        {
            string name = donorNameBox.Text;
            DonorsService donorsService = new DonorsService();
            dataGridView1.DataSource = new List<Donors> {donorsService.GetByName(name)};
        }

        private void staffNameBox_TextChanged(object sender, EventArgs e)
        {
            string name = staffNameBox.Text;
            EmployeeService employeeService = new EmployeeService();
            dataGridView2.DataSource = new List<Employee> { employeeService.GetByName(name)};
        }

        private void DonorUpdate_Click(object sender, EventArgs e)
        {
           
            DonorUpdate du = new DonorUpdate(d);
            du.ShowDialog();
        }

        private void DonorDelete_Click(object sender, EventArgs e)
        {
            DonorsService ds = new DonorsService();
            if (ds.Remove(idDonor) > 0)
            {
                MessageBox.Show("Record Deleted Successfully!!");
                LoadData();
            }

        }

        private void EmployeeUpdate_Click(object sender, EventArgs e)
        {
            EmployeeUpdate eu = new EmployeeUpdate();
            eu.ShowDialog();
            LoadData();

        }

        private void showBloodInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blood_Inventory bi = new Blood_Inventory();
            this.Hide();
            bi.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            idTextDonor = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            d.Name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            d.Address = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            d.Email = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            d.Age = int.Parse( dataGridView1.Rows[e.RowIndex].Cells["Age"].Value.ToString());
            d.Gender =  dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            d.Phone = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            d.BloodGroup = dataGridView1.Rows[e.RowIndex].Cells["BloodGroup"].Value.ToString();
            d.Weight = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Weight"].Value.ToString());

            idDonor = int.Parse(idTextDonor);


        }

        public void LoadData()
        {
            DonorsService donorsService = new DonorsService();
            dataGridView1.DataSource = donorsService.GetAll();

            EmployeeService employeeService = new EmployeeService();
            dataGridView2.DataSource = employeeService.GetAll();

        }

        private void EmployeeDelete_Click(object sender, EventArgs e)
        {
            EmployeeService ds = new EmployeeService();
            if (ds.Remove(idEmployee) > 0)
            {
                MessageBox.Show("Record Deleted Successfully!!");
                LoadData();
            }
           
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextEmployee = dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            idEmployee = int.Parse(idTextEmployee);
        }

    }
}
