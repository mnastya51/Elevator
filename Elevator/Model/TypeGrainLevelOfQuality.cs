using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class TypeGrainLevelOfQuality : AbstractTypeLevelOfQuality
    {
        public const string NameTable = "Type_grain_impurities ";
        public const string NameAttr = "name_grain_imp";
        public TypeGrainLevelOfQuality(string qualityLevelName) : base(qualityLevelName)
        {
        }
    }
}
