using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddDateAnalysController
    {
        public bool onSaveClick(DateAnalys dateAnalys, bool forChange)
        {
            if (!forChange)
            {
                if (!DAO.getInstance().addNote("Analysis", new FormValue<string, string>("id_contractor", dateAnalys.IdContractor.ToString()),
                new FormValue<string, string>("id_raw", dateAnalys.IdRaw.ToString()),
                new FormValue<string, string>("date_analysis", dateAnalys.Date)))
                {
                    MessageBox.Show("Данная дата анализа уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            else
            {
                if (!DAO.getInstance().updateNote("Analysis", new FormValue<string, string>("id_analysis", dateAnalys.Id.ToString()),
                    new FormValue<string, string>("date_analysis", dateAnalys.Date)))
                {
                    MessageBox.Show("Данная дата анализа уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
        }
    }
}
