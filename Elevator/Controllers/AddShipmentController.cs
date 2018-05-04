﻿using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddShipmentController
    {
        public void changeStorage(Storage storage, Shipment shipment)
        {
            DAO.getInstance().changeTransportation(Shipment.NameTable, shipment.Id, shipment.Contractor,
                shipment.Subdivision,
                 new FormValue<string, string>(Shipment.TransportAttr, shipment.Transport),
                 new FormValue<string, string>(Shipment.WeightAttr, shipment.Weight),
                 new FormValue<string, string>(Shipment.DateAttr, shipment.Date), storage.IdRaw,
                 storage.Raw, storage.Type, storage.Subtype, storage.Year);
        }

        public bool onSaveClick(Shipment shipment, bool forChange)
        {
            if (!forChange)
            {
                if (!DAO.getInstance().addShipment(shipment.Id, shipment.Contractor,
                shipment.Subdivision, shipment.Transport, shipment.Weight, shipment.Date))
                {
                    MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            else
            {
              /* if (!DAO.getInstance().changeTransportation(Shipment.NameTable, shipment.Id, shipment.Contractor,
              shipment.Subdivision,
               new FormValue<string, string>(Shipment.TransportAttr, shipment.Transport),
               new FormValue<string, string>(Shipment.WeightAttr, shipment.Weight),
               new FormValue<string, string>(Shipment.DateAttr, shipment.Date), storage.IdRaw,
               storage.Raw, storage.Type, storage.Subtype, storage.Year))
                {
                    MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else*/ return true;
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
