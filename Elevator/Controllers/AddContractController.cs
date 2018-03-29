using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddContractController
    {
        public bool onSaveClick(Contract contract, bool forChange)
        {
            if (!forChange)
            {
                if (!DAO.getInstance().addContract(contract.NameContract, contract.NameContractor, contract.Subdivision, contract.Date, contract.Goal))
                {
                    MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            else
            {              
                if (!DAO.getInstance().updateContract(contract.NameContract, contract.NameContractor, contract.Subdivision, contract.Date, contract.Goal))
                {
                    MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
          }

        public static bool isEmpty(string text)
        {
            return text == null || text == string.Empty || text.Length == 0;
        }

        public bool checkSave(string nameContractor)
        {
            return nameContractor.Replace(" ", "").Length > 0;
        }
    }
}
