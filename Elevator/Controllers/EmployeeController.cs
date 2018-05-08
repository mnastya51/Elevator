using Elevator.Model;
using Elevator.AddAndEditForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class EmployeeController
    {
        public void changeButtonClick(Employee employee)
        {
            new AddEmployeeForm(employee).ShowDialog();
        }
        public void deleteButtonClick(string id)
        {
            DAO.getInstance().deleteNote("Employee", new FormValue<string, string>("id_emp", id));
        }
        public DataTable findButtonClick(string value)
        {
            return DAO.getInstance().findRow("Employee", new FormValue<string, string>("surname", value));
        }
        public void addButtonClick()
        {
            new AddEmployeeForm().ShowDialog();
        }
        public Employee GetEmployeeByAuthorization(string login, string password)
        {
            return DAO.getInstance().GetEmployeeByAuthorization(login, password);
        }
    }
}
