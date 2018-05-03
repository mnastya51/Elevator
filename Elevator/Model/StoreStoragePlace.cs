using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class StoreStoragePlace : AbstractStoragePlace
    {
        public const string NameTable = "Store_raw";
        public const string WeightAttr = "weight_store";
        public const string NumberAttr = "numb_store";
        public StoreStoragePlace(string idRaw, string number, string weight) : base(idRaw, number, weight)
        {
        }
        public StoreStoragePlace(string idRaw, string idPlaceStorage, string number, string weight) : base(idRaw, idPlaceStorage, number, weight)
        {
        }
    }
}
