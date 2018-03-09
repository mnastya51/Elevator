using Elevator.AddAndEditForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class DeliveryController
    {
        public void addButtonClick()
        {
            new AddDeliveryForm().ShowDialog();
        }
        /*public void changeButtonClick(Contract contract)
        {
            new AddContractForm(contract).ShowDialog();
        }*/
    }
}
