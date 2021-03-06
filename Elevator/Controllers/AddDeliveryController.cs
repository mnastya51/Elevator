﻿using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddDeliveryController
    {
        public bool onSaveClick(Delivery delivery, Storage storage, bool forChange)
        {
            if (!forChange)
            {
                /*if (!DAO.getInstance().addDelivery("Delivery", delivery.Contractor, delivery.Raw, delivery.Type, delivery.Subtype,                
                    new FormValue<string, string>("date_delivery ", delivery.Date), delivery.Year,
                    new FormValue<string, string>("type_transport_delivery ", delivery.Transport),
                    new FormValue<string, string>("weight_delivery ", delivery.Weight)))*/
                if (!DAO.getInstance().addDelivery(delivery.Id, Delivery.NameTable, delivery.Contractor,
                    delivery.Subdivision,
                new FormValue<string, string>(Delivery.DateAttr, delivery.Date),
                new FormValue<string, string>(Delivery.TransportAttr, delivery.Transport),
                new FormValue<string, string>(Delivery.WeightAttr, delivery.Weight),
                storage.Raw, storage.Type, storage.Subtype, storage.Year))
                {
                    MessageBox.Show("Данная запись о поставке уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            else
            {
                if (!DAO.getInstance().changeTransportation(Delivery.NameTable, delivery.Id, delivery.Contractor,
              delivery.Subdivision,
               new FormValue<string, string>(Delivery.TransportAttr, delivery.Transport),
               new FormValue<string, string>(Delivery.WeightAttr, delivery.Weight),
               new FormValue<string, string>(Delivery.DateAttr, delivery.Date), storage.IdRaw,
               storage.Raw, storage.Type, storage.Subtype, storage.Year))
                {
                    MessageBox.Show("Данная запись о поставке уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }

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

        public void changeStorage(Storage storage, Shipment shipment)
        {           
            DAO.getInstance().changeTransportation(Shipment.NameTable, shipment.Id, shipment.Contractor,
                shipment.Subdivision,
                 new FormValue<string, string>(Shipment.TransportAttr, shipment.Transport),
                 new FormValue<string, string>(Shipment.WeightAttr, shipment.Weight),
                 new FormValue<string, string>(Shipment.DateAttr, shipment.Date), storage.IdRaw,
                 storage.Raw, storage.Type, storage.Subtype, storage.Year);
        }

        public bool onSaveClick(Shipment shipment, Storage storage, bool forChange, string dateOld)
        {
            if (!forChange)
            {
                if (!DAO.getInstance().addDelivery(shipment.Id, Shipment.NameTable, shipment.Contractor,
                shipment.Subdivision,
            new FormValue<string, string>(Shipment.DateAttr, shipment.Date),
            new FormValue<string, string>(Shipment.TransportAttr, shipment.Transport),
            new FormValue<string, string>(Shipment.WeightAttr, shipment.Weight),
                storage.Raw, storage.Type, storage.Subtype, storage.Year))
                {
                    MessageBox.Show("Данная запись об отгрузке уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            else
            {
                if (!DAO.getInstance().changeTransportation(Shipment.NameTable, dateOld, shipment.Id, shipment.Contractor,
              shipment.Subdivision,
               new FormValue<string, string>(Shipment.TransportAttr, shipment.Transport),
               new FormValue<string, string>(Shipment.WeightAttr, shipment.Weight),
               new FormValue<string, string>(Shipment.DateAttr, shipment.Date), storage.IdRaw,
               storage.Raw, storage.Type, storage.Subtype, storage.Year))
                {
                    MessageBox.Show("Данная запись об отгрузке уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (shipment.PlaceStorage.Equals("склад"))
                    {
                        if (!DAO.getInstance().cancelStoragePlace(Convert.ToString(shipment.Id), shipment.Number, shipment.Weight,
                       StoreStoragePlace.NameTable, StoreStoragePlace.NumberAttr, StoreStoragePlace.WeightAttr,
                       shipment.IdPlaceStorage, shipment.WeightBefore))
                        {
                            MessageBox.Show("Превышен вес!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else return true;
                    }
                    else
                    {
                        if (!DAO.getInstance().cancelStoragePlace(Convert.ToString(shipment.Id), shipment.Number, shipment.Weight,
                       SilageStoragePlace.NameTable, SilageStoragePlace.NumberAttr, SilageStoragePlace.WeightAttr,
                       shipment.IdPlaceStorage, shipment.WeightBefore))
                        {
                            MessageBox.Show("Превышен вес!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else return true;
                    }
                }
            }
        }
        public bool checkSave(string surname)
        {
            return isNotEmpty(surname);
        }
        public bool isNotEmpty(string text)
        {
            return text.Replace(" ", "").Length > 0;
        }

        public bool isEmpty(string text)
        {
            return text == null || text == string.Empty || text.Length == 0;
        }
    }
   
}
        
    

