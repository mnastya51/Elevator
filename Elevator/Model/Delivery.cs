using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class Delivery
    {
        public int Id { get; set; }
        public string Transport { get; set; }
        public string Weight { get; set; }
        public string Date { get; set; }
        public string Contractor { get; set; }
        public string Raw { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string Year { get; set; }

        public Delivery(int id, string contractor, string raw, string type, string subtype, string date, string year, string transport,
            string weight)
        {
            this.Id = id;
            this.Transport = transport;
            this.Weight = weight;
            this.Date = date;
            this.Contractor = contractor;
            this.Raw = raw;
            this.Type = type;
            this.Subtype = subtype;
            this.Year = year;
        }
        public Delivery(string contractor, string raw, string type, string subtype, string date, string year, string transport, 
            string weight)
        {
            this.Transport = transport;
            this.Weight = weight;
            this.Date = date;
            this.Contractor = contractor;
            this.Raw = raw;
            this.Type = type;
            this.Subtype = subtype;
            this.Year = year;
        }
    }
}
