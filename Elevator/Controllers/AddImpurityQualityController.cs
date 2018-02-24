using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elevator.Model;

namespace Elevator.Controllers
{
    class AddImpurityQualityController
    {
        public bool onSaveClick(FormValue<string, string> formValue, string value)
        {
            if (!DAO.getInstance().addNote(formValue.getKey(), new FormValue<string, string> (formValue.getValue(), value)))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
    }
}
