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
        public void addButtonDeliveryClick()
        {
            new AddDeliveryForm().ShowDialog();
        }

        public void addButtonShipmentClick()
        {
            new AddShipmentForm().ShowDialog();
        }

        public void changeButtonClick(Storage storage, Delivery delivery)
        {
            new AddDeliveryForm(storage, delivery).ShowDialog();
        }

        public void deleteButtonClick(Shipment shipment)
        {
            DAO.getInstance().deleteShipment(shipment.IdStorage, shipment.Contractor, shipment.Subdivision, shipment.Id);
        }
    }
}
