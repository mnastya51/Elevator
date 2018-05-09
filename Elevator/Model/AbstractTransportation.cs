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
        public string PlaceStorage { get; set; }
        public string IdPlaceStorage { get; set; }
        public string Number { get; set; }
        public string Contractor { get; set; }
        public string Subdivision { get; set; }
        public string Transport { get; set; }
        public string Weight { get; set; }
        public string Date { get; set; }

        public AbstractTransportation(){}

        public AbstractTransportation(int id, string contractor, string subdivision, string date, string transport, string weight)
        {
            this.Id = id;
            this.Transport = transport;
            this.Weight = weight;
            this.Date = date;
            this.Contractor = contractor;
            this.Subdivision = subdivision;
        }

        public AbstractTransportation(int id, string contractor, string subdivision, string date, string transport, string weight,
            string placeStorage, string number, string idPlaceStorage)
        {
            this.Id = id;
            this.Transport = transport;
            this.Weight = weight;
            this.Date = date;
            this.Contractor = contractor;
            this.Subdivision = subdivision;
            this.IdPlaceStorage = idPlaceStorage;
            this.Number = number;
            this.PlaceStorage = placeStorage;
        }
        public AbstractTransportation(string contractor, string subdivision, string date, string transport, string weight)
        {
            this.Transport = transport;
            this.Weight = weight;
            this.Date = date;
            this.Contractor = contractor;
            this.Subdivision = subdivision;
        }
    }
}
