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
        public Shipment(int id, string contractor, string subdivision, string date, string transport, string weight,
           string placeStorage, string number, string idPlaceStorage) : 
            base(id, contractor, subdivision, date, transport, weight, placeStorage, number, idPlaceStorage )
        {
        }
        public Shipment(string contractor, string subdivision, string date, string transport, string weight) : 
            base(contractor, subdivision, date, transport, weight)
        {
        }
        public Shipment(string contractor, string subdivision, string idStorage, int id) 
        {
            this.IdStorage = idStorage;
            this.Contractor = contractor;
            this.Subdivision = subdivision;
            this.Id = id;
        }
        public Shipment(string contractor, string subdivision, string idStorage, int id, string placeStorage,
            string idPlaceStorage, string number, string weight)
        {
            this.IdStorage = idStorage;
            this.Contractor = contractor;
            this.Subdivision = subdivision;
            this.Id = id;
            this.PlaceStorage = placeStorage;
            this.IdPlaceStorage = idPlaceStorage;
            this.Number = number;
            this.Weight = weight;
        }
    }
}
