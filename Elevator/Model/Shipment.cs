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
        public Shipment(int id, string contractor, string date, string transport, string weight) : 
            base(id, contractor, date, transport, weight)
        {
        }
        public Shipment(string contractor, string date, string transport, string weight) : 
            base(contractor, date, transport, weight)
        {
        }
    }
}
