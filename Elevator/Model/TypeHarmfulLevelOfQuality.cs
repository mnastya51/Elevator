using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class TypeHarmfulLevelOfQuality : AbstractTypeLevelOfQuality
    {
        public const string NameTable = "Type_harmful_impurities ";
        public const string NameAttr = "name_harm_imp";
        public TypeHarmfulLevelOfQuality(string qualityLevelName) : base(qualityLevelName)
        {
        }
    }
}
