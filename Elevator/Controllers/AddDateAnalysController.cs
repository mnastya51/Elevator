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
        public bool onSaveClick(DateAnalys dateAnalys)
        {
            if (!DAO.getInstance().addNote("Analysis", new FormValue<string, string>("id_contractor", dateAnalys.IdContractor.ToString()),
                new FormValue<string, string>("id_raw", dateAnalys.IdRaw.ToString()),
                new FormValue<string, string>("date_analysis", dateAnalys.Date.ToString())))
             {
                 MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
             }
             else return true;
        }
    }
}
