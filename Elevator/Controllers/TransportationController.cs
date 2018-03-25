using Elevator.AddAndEditForms;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class TransportationController
    {
        public void addButtonClick()
        {
            new AddTransportationForm().ShowDialog();
        }

        public void addButtonClick(string text)
        {
            new AddTransportationForm(text).ShowDialog();
        }

        public void changeButtonClick(Storage storage, Delivery delivery)
        {
            new AddTransportationForm(storage, delivery).ShowDialog();
        }

        public void changeButtonClick(Storage storage, Shipment shipment)
        {
            new AddTransportationForm(storage, shipment).ShowDialog();
        }
    }
}
