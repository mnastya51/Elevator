using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class TypeGeneralLevelOfQuality : AbstractTypeLevelOfQuality
    {
        public const string NameTable = "Type_general_impurities";
        public const string NameAttr = "name_imp";
        public TypeGeneralLevelOfQuality(string qualityLevelName) : base(qualityLevelName)
        {
        }
    }
}
