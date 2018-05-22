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
        public void changeButtonClick(Storage storage, Shipment delivery)
        {
            new AddDeliveryForm(storage, delivery).ShowDialog();
        }
        public void deleteButtonClick(Shipment shipment)
        {
           // DAO.getInstance().deleteShipment(shipment.Date, shipment.Contractor, shipment.Subdivision);
        }
        public void cancelShipmentClick(Shipment shipment)
        {
            string[] result = shipment.PlaceStorage.Split('?');
            string[] storage;
            List<string[]> array = new List<string[]>();
            for(int i=2; i< result.Length; i++)
            {
                storage = result[i].Split(',');
                array.Add(storage);
            }
            //string[] arr = array.ToArray<string>();
            for (int i = 0; i < array.Count; i++)
            {
                if (result[0] == "numb_store")
                {
                    string u = array[i].GetValue(2).ToString();
                    DAO.getInstance().updateStoragePlace(array[i].GetValue(1).ToString(), result[1], array[i].GetValue(2).ToString(),
                        StoreStoragePlace.NameTable, StoreStoragePlace.NumberAttr, StoreStoragePlace.WeightAttr,
                        array[i].GetValue(0).ToString(), result[1]);
                }
                else
                {
                    string u = array[i].GetValue(2).ToString();
                    DAO.getInstance().updateStoragePlace(array[i].GetValue(1).ToString(), result[1], array[i].GetValue(2).ToString(),
                        SilageStoragePlace.NameTable, SilageStoragePlace.NumberAttr, SilageStoragePlace.WeightAttr,
                        array[i].GetValue(0).ToString(), result[1]);
                }
            }
            DAO.getInstance().deleteShipment(shipment.Date, shipment.Contractor, shipment.Subdivision);
            
           /* if (shipment.PlaceStorage.Equals("склад"))
            {
                DAO.getInstance().cancelStoragePlace(Convert.ToString(shipment.Id), shipment.Number, shipment.Weight,
               StoreStoragePlace.NameTable, StoreStoragePlace.NumberAttr, StoreStoragePlace.WeightAttr,
               shipment.IdStorage);
            }
            else
            {
                DAO.getInstance().cancelStoragePlace(Convert.ToString(shipment.Id), shipment.Number, shipment.Weight,
               SilageStoragePlace.NameTable, SilageStoragePlace.NumberAttr, SilageStoragePlace.WeightAttr,
               shipment.IdPlaceStorage);
            }*/
        }
    }
}
