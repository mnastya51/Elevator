using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class AbstractStoragePlace
    {
        public string IdRaw { get; set; }
        public string IdPlaceStorage { get; set; }
        public string Number { get; set; }
        public string Weight { get; set; }

        public AbstractStoragePlace(string idRaw, string number, string weight)
        {
            this.IdRaw = idRaw;
            this.Number = number;
            this.Weight = weight;
        }

        public AbstractStoragePlace(string idRaw, string idPlaceStorage, string number, string weight)
        {
            this.IdRaw = idRaw;
            this.IdPlaceStorage = idPlaceStorage;
            this.Number = number;
            this.Weight = weight;
        }
    }
}
