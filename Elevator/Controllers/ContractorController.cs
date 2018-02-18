using Elevator.Entity;
using Elevator.Forms;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class ContractorController
    {
        public void addButtonClick()
        {
            new AddContractorForm().ShowDialog();
        }
        public void changeButtonClick(Contractor contractor)
        {
            new AddContractorForm(contractor).ShowDialog();
        }
        public void deleteButtonClick(string id)
        {
            DAO.getInstance().deleteNote("Contractor", new FormValue<string, string>("id_contractor", id));
        }
        public DataTable findButtonClick(string value)
        {
            return DAO.getInstance().findRow("Contractor", new FormValue<string, string>("name_contr", value));
        }
    }
}
