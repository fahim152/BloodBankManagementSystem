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

        public Employee GetById(int id)
        {
            return employeeDataAccess.GetById(id);
        }

        public string CheckLogin(int id, string password) {
            return employeeDataAccess.CheckLogin(id, password);
        }

        public object RowCount() {
            return employeeDataAccess.RowCount();
        }
    }
}
