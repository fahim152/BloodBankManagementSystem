using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Entity;
using BloodBank.Data;

namespace BloodBank.Core
{
    public class EmployeeService
    {
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();

        public int Add(Employee employee)
        {
            return employeeDataAccess.Add(employee);
        }

        public int Remove(int id)
        {
            return employeeDataAccess.Remove(id);
        }

        public int Edit(Employee employee)
        {
            return employeeDataAccess.Edit(employee);
        }

        public List<Employee> GetAll()
        {
            return employeeDataAccess.GetAll();
        }

        public Employee GetByName(string name)
        {
            return employeeDataAccess.GetByName(name);
        }

        public string CheckLogin(int id, string password) {
            return employeeDataAccess.CheckLogin(id, password);
        }

        public object RowCount() {
            return employeeDataAccess.RowCount();
        }

        public string GetPassword(string email) {
            return employeeDataAccess.GetPassword(email);
        }

        public bool SendEmployeePassword(string email, string password) {
            return employeeDataAccess.SendEmployeePassword(email, password);
        }
    }
}
