using Elevator.AddAndEditForms;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class DateAnalysController
    {
        public void changeButtonClick(DateAnalys dateAnalys, bool change)
        {
            new AddDateAnalysForm(dateAnalys, change).ShowDialog();
        }
        public void deleteButtonClick(string id)
        {
            DAO.getInstance().deleteNote("Analysis", new FormValue<string, string>("id_analysis", id));
        }
    }
}
