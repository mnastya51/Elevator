using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public abstract class AbstractTransportation
    {
        public int Id { get; set; }
        public string Contractor { get; set; }
        public string Transport { get; set; }
        public string Weight { get; set; }
        public string Date { get; set; }      
      
        public AbstractTransportation(int id, string contractor, string date, string transport, string weight)
        {
            this.Id = id;
            this.Transport = transport;
            this.Weight = weight;
            this.Date = date;
            this.Contractor = contractor;         
        }
        public AbstractTransportation(string contractor, string date, string transport, string weight)
        {
            this.Transport = transport;
            this.Weight = weight;
            this.Date = date;
            this.Contractor = contractor;
        }
    }
}
