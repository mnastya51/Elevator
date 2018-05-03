using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class SilageStoragePlace : AbstractStoragePlace
    {
        public const string NameTable = "Silage_raw";
        public const string WeightAttr = "weight_silage";
        public const string NumberAttr = "numb_silage";
        public SilageStoragePlace(string idRaw, string number, string weight) : base(idRaw, number, weight)
        {
        }
        public SilageStoragePlace(string idRaw, string idPlaceStorage, string number, string weight) : base(idRaw, idPlaceStorage, number, weight)
        {
        }
    }
}
