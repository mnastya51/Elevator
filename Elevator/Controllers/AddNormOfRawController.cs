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
        public bool onSaveClick(string nameTable, string name_imp, string valImp, string norm, string raw, string value)
        {
            if (!DAO.getInstance().addNorm(nameTable, name_imp, valImp, norm, raw, value))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
    }
}
