using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class HarmfulLevelOfQuality : AbstractLevelOfQuality
    {
        public const string NameTable = "Harmful_impurities";
        public const string ValueAttr = "value_harm_imp";
        public HarmfulLevelOfQuality(string levelOfQuality, string idRaw, string value) : base(levelOfQuality, idRaw, value)
        {
        }
        public HarmfulLevelOfQuality(string idRaw) : base(idRaw)
        {
        }
    }
}
