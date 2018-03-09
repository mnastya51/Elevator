using Elevator.AddAndEditForms;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class ContractController
    {
        public void addButtonClick()
        {
            new AddContractForm().ShowDialog();
        }
        public void changeButtonClick(Contract contract)
        {
            new AddContractForm(contract).ShowDialog();
        }
        public void deleteButtonClick(string nameContractor, string nameContract)
        {
            DAO.getInstance().deleteContract(nameContractor, nameContract);
        }
        public void findButtonClick(string value, DataGridView dataGridViewContract)
        {
            DAO.getInstance().findContractor(value, dataGridViewContract);
        }
    }
}
