using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddEmployeeController
    {
        public bool onSaveClick(Employee employee, bool forChange)
        {
            if (!forChange)
            {
                if(!DAO.getInstance().addNote("employee", new FormValue<string, string>("surname", employee.Surname),
                    new FormValue<string, string>("name", employee.Name),
                    new FormValue<string, string>("secName", employee.SecName),
                    new FormValue<string, string>("post", employee.Post),
                    new FormValue<string, string>("login", employee.Login),
                    new FormValue<string, string>("password", employee.Password)))
                {
                    MessageBox.Show("Данный логин уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            else
            {
                if (employee.Password != "")
                {
                    if (!DAO.getInstance().updateNote("employee", new FormValue<string, string>("id_emp", employee.Id.ToString()),
                        new FormValue<string, string>("surname", employee.Surname),
                        new FormValue<string, string>("name", employee.Name),
                        new FormValue<string, string>("secName", employee.SecName),
                        new FormValue<string, string>("post", employee.Post),
                        new FormValue<string, string>("login", employee.Login),
                        new FormValue<string, string>("password", employee.Password)))
                    {
                        MessageBox.Show("Данный логин уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else return true;
                }
                else
                {
                    if (!DAO.getInstance().updateNote("employee", new FormValue<string, string>("id_emp", employee.Id.ToString()),
                        new FormValue<string, string>("surname", employee.Surname),
                        new FormValue<string, string>("name", employee.Name),
                        new FormValue<string, string>("secName", employee.SecName),
                        new FormValue<string, string>("post", employee.Post),
                        new FormValue<string, string>("login", employee.Login)))
                    {
                        MessageBox.Show("Данный логин уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else return true;
                }
            }
        }

        public static bool isEmpty(string text)
        {
            return text == null || text == string.Empty || text.Length == 0;
        }

        public bool checkSaveForAll(string surname, string name, string secName, string login, string password)
        {
            return isNotEmpty(surname) && isNotEmpty(name) && isNotEmpty(secName) && isNotEmpty(login) && isNotEmpty(password);
        }

        public bool isNotEmpty(string text)
        {
            return text.Replace(" ", "").Length > 0;
        }
    }
}
