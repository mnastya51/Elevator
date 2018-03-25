using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class Delivery: AbstractTransportation
    {
        public const string NameTable = "Delivery";
        public const string DateAttr = "date_delivery";
        public const string TransportAttr = "type_transport_delivery";
        public const string WeightAttr = "weight_delivery";
        public Delivery(int id, string contractor, string subdivision, string date, string transport,string weight) : 
            base(id, contractor, subdivision, date, transport, weight)
        {
        }
        public Delivery(string contractor, string subdivision, string date, string transport,string weight) : 
            base(contractor, subdivision, date, transport, weight)
        {
        }
    }
}
