using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddDryController
    {
        public bool onSaveClick(Drying drying, bool forChange)
        {
            if (!forChange)
            {
                if (!DAO.getInstance().addDry("Drying", new FormValue<string, string>("date_drying", drying.Date),
                    new FormValue<string, string>("id_raw", drying.IdRaw),
                    new FormValue<string, string>("weight_before_drying", drying.WeightBefore),
                    new FormValue<string, string>("weight_after_drying", drying.WeightAfter),
                    new FormValue<string, string>("wet_before", drying.WetBefore),
                    new FormValue<string, string>("wet_after", drying.WetAfter)))
                {
                    MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            else
            {
                if (!DAO.getInstance().updateDry("Drying", new FormValue<string, string>("id_raw", drying.IdRaw),
                    new FormValue<string, string>("date_drying", drying.Date),
                    new FormValue<string, string>("weight_before_drying ", drying.WeightBefore),
                    new FormValue<string, string>("weight_after_drying", drying.WeightAfter),
                    new FormValue<string, string>("wet_before", drying.WetBefore),
                    new FormValue<string, string>("wet_after", drying.WetAfter)))
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
