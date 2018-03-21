using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class TypeWeedLevelOfQuality : AbstractTypeLevelOfQuality
    {
        public const string NameTable = "Type_weed_impurities";
        public const string NameAttr = "name_weed_imp";
        public TypeWeedLevelOfQuality(string qualityLevelName) : base(qualityLevelName)
        {
        }
    }
}
