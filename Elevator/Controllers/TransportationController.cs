using Elevator.AddAndEditForms;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class TransportationController
    {
        public void addButtonClick()
        {
            new AddDeliveryForm().ShowDialog();
        }
        public void changeButtonClick(Storage storage, Delivery delivery)
        {
            new AddDeliveryForm(storage, delivery).ShowDialog();
        }
    }
}
