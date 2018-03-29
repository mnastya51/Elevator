using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class WeedLevelOfQuality : AbstractLevelOfQuality
    {
        public const string NameTable = "Weed_impurities";
        public const string RawAttr = "id_raw";
        public const string ValueAttr = "value_weed_imp";
        public WeedLevelOfQuality(string levelOfQuality, string idRaw, string value) : base(levelOfQuality, idRaw, value)
        {
        }
    }
}
