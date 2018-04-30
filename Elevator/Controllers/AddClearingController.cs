using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddClearingController
    {
        public bool onSaveClick(Clearing clearing, bool forChange)
        {
            if (!forChange)
            {
                if (!DAO.getInstance().addClearing(clearing.Date, clearing.IdRaw, clearing.WeightBefore,
                    clearing.WeightAfter))
                {
                    MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            else
            {
                if (!DAO.getInstance().updateClearing(clearing.Date, clearing.IdRaw, clearing.WeightBefore,
                    clearing.WeightAfter))
                {
                    MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
        }

        public bool checkSave(string surname)
        {
            return isNotEmpty(surname);
        }
        public bool isNotEmpty(string text)
        {
            return text.Replace(" ", "").Length > 0;
        }
        public bool isEmpty(string text)
        {
            return text == null || text == string.Empty || text.Length == 0;
        }
    }
}
