using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddNormOfRawController
    {
        public bool addClick(string nameTable, string name_imp, string valImp, string norm, string raw, string value, string numberClass)
        {
            if (!DAO.getInstance().addNorm(nameTable, name_imp, valImp, norm, raw, value, numberClass))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool changeClick(string valueImp, string nameTable, string raw, string valueNorm, string nameImp, string nameNorm, string numberClass)
        {
            if (!DAO.getInstance().changeNorm(valueImp, nameTable, raw, valueNorm, nameImp, nameNorm, numberClass))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
    }
}
