using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddTransportationController
    {
        public bool onSaveClick(Delivery delivery, bool forChange)
        {
            if (!forChange)
            {
                /*if (!DAO.getInstance().addDelivery("Delivery", delivery.Contractor, delivery.Raw, delivery.Type, delivery.Subtype,                
                    new FormValue<string, string>("date_delivery ", delivery.Date), delivery.Year,
                    new FormValue<string, string>("type_transport_delivery ", delivery.Transport),
                    new FormValue<string, string>("weight_delivery ", delivery.Weight)))*/
                if (!DAO.getInstance().addTransportation(delivery.Id, Delivery.NameTable, delivery.Contractor,
                new FormValue<string, string>(Delivery.DateAttr, delivery.Date),
                new FormValue<string, string>(Delivery.TransportAttr, delivery.Transport),
                new FormValue<string, string>(Delivery.WeightAttr, delivery.Weight)))
                {
                    MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            else return false;

            /*else
            {
                if (!DAO.getInstance().updateNote("Contractor", new FormValue<string, string>("id_contractor", delivery.ClassId.ToString()),
                    new FormValue<string, string>("name_contr", delivery.Name),
                    new FormValue<string, string>("subdivision ", delivery.Sub),
                    new FormValue<string, string>("jur_address", delivery.YurAdress),
                    new FormValue<string, string>("fact_address", delivery.FactAdress),
                    new FormValue<string, string>("mail_index", delivery.Index.ToString().Replace(" ", "") == "0" ? string.Empty : delivery.Index.ToString()),
                    new FormValue<string, string>("phone", delivery.Phone.Replace(" ", "").Length == 14 ? delivery.Phone : string.Empty),
                    new FormValue<string, string>("inn", delivery.Inn.ToString())))
                {
                    MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;*/
        }
        public void changeStorage(Storage storage, Delivery delivery)
        {
            DAO.getInstance().changeStorage(storage.IdRaw, storage.Raw, storage.Type, storage.Subtype,
            storage.Year);
            DAO.getInstance().changeTransportation(Delivery.NameTable, delivery.Id, delivery.Contractor,
                 new FormValue<string, string>(Delivery.TransportAttr,delivery.Transport),
                 new FormValue<string, string>(Delivery.WeightAttr, delivery.Weight),
                 new FormValue<string, string>(Delivery.DateAttr, delivery.Date));
        }

        public void changeStorage(Storage storage, Shipment shipment)
        {
            DAO.getInstance().changeStorage(storage.IdRaw, storage.Raw, storage.Type, storage.Subtype,
            storage.Year);
            DAO.getInstance().changeTransportation(Shipment.NameTable, shipment.Id, shipment.Contractor,
                 new FormValue<string, string>(Shipment.TransportAttr, shipment.Transport),
                 new FormValue<string, string>(Shipment.WeightAttr, shipment.Weight),
                 new FormValue<string, string>(Shipment.DateAttr, shipment.Date));
        }

        public bool onSaveClick(Shipment shipment, bool forChange)
        {
            if (!DAO.getInstance().addTransportation(shipment.Id, Shipment.NameTable, shipment.Contractor,
            new FormValue<string, string>(Shipment.DateAttr, shipment.Date),
            new FormValue<string, string>(Shipment.TransportAttr, shipment.Transport),
            new FormValue<string, string>(Shipment.WeightAttr, shipment.Weight)))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;

        }
    }     
}
        
    

