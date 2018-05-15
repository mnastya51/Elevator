using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class Shipment: AbstractTransportation
    {
        public const string NameTable = "Shipment ";
        public const string DateAttr = "date_shipment";
        public const string TransportAttr = "type_transport_shipment";
        public const string WeightAttr = "weight_shipment";
        public string IdStorage { get; set; }
        public double WeightBefore { get; set; }
        public Shipment(int id, string contractor, string subdivision, string date, string transport, string weight,
           string placeStorage, string number, string idPlaceStorage) : 
            base(id, contractor, subdivision, date, transport, weight, placeStorage, number, idPlaceStorage)
        {
        }  
        public Shipment(int id, string contractor, string subdivision, string date, string transport, string weight,
               double weightBefore, string idPlaceStorage, string placeStorage, string number)
        {
            this.Id = id;
            this.Transport = transport;
            this.Weight = weight;
            this.Date = date;
            this.Contractor = contractor;
            this.Subdivision = subdivision;
            this.WeightBefore = weightBefore;
            this.IdPlaceStorage = IdPlaceStorage;
            this.PlaceStorage = placeStorage;
            this.Number = number;
        }

        public Shipment(int id, string contractor, string subdivision, string date, string transport, string weight,
               double weightBefore)
        {
            this.Id = id;
            this.Transport = transport;
            this.Weight = weight;
            this.Date = date;
            this.Contractor = contractor;
            this.Subdivision = subdivision;
            this.WeightBefore = weightBefore;
            this.IdPlaceStorage = IdPlaceStorage;
        }

        public Shipment(string contractor, string subdivision, string date, string transport, string weight,
              string idPlaceStorage, string placeStorage, string number)
        {
            this.Transport = transport;
            this.Weight = weight;
            this.Date = date;
            this.Contractor = contractor;
            this.Subdivision = subdivision;
            this.IdPlaceStorage = idPlaceStorage;
            this.PlaceStorage = placeStorage;
            this.Number = number;
        }

        public Shipment(int id, string contractor, string subdivision, string date, string transport, string weight) : 
            base(id, contractor, subdivision, date, transport, weight)
        {
        }
        public Shipment(string contractor, string subdivision, string date, string transport, string weight) : 
            base(contractor, subdivision, date, transport, weight)
        {
        }
        public Shipment(string contractor, string subdivision, string date, int idRaw) 
        {
            this.Id= idRaw;
            this.Contractor = contractor;
            this.Subdivision = subdivision;
            this.Date = date;
        }
        public Shipment(string contractor, string subdivision, string IdPlaceStorage, int id, string date,
            string placeStorage, string number, string weight)
        {
            this.IdPlaceStorage = IdPlaceStorage;
            this.Contractor = contractor;
            this.Subdivision = subdivision;
            this.Id = id;
            this.Date = date;
            this.PlaceStorage = placeStorage;
            this.Number = number;
            this.Weight = weight;
        }
    }
}
