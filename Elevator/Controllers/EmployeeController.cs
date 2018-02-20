﻿using Elevator.Entity;
using Elevator.Forms;
using Elevator.Model;
using System;
using System.Collections.Generic;
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
    }
}
