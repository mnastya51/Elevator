using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class StoragePlace
    {
        public string IdRaw { get; set; }
        public string IdPlaceStorage { get; set; }

        public StoragePlace(string idRaw)
        {
            this.IdRaw = idRaw;
        }

        public StoragePlace(string idRaw, string idPlaceStorage)
        {
            this.IdRaw = idRaw;
            this.IdPlaceStorage = idPlaceStorage;
        }
    }
}
