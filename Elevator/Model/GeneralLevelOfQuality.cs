using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class GeneralLevelOfQuality : AbstractLevelOfQuality
    {
        public const string NameTable = "General_impurities";
        public const string RawAttr = "id_raw";
        public const string ValueAttr = "value_imp";
        public GeneralLevelOfQuality(string levelOfQuality, string idRaw, string value) : base(levelOfQuality, idRaw, value)
        {
        }
    }
}
