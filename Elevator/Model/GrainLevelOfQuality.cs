using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class GrainLevelOfQuality : AbstractLevelOfQuality
    {
        public const string NameTable = "Grain_impurities";
        public const string ValueAttr = "value_grain_imp";
        public GrainLevelOfQuality(string levelOfQuality, string idRaw, string value) : base(levelOfQuality, idRaw, value)
        {
        }
        public GrainLevelOfQuality(string idRaw) : base(idRaw)
        {
        }
    }
}
