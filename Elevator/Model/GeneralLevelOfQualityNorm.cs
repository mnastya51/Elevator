using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class GeneralLevelOfQualityNorm : AbstractQualityLevelNorm
    {
        public const string NameTable = "Norm_general_impurities";
        public const string NormAttr = "norm_imp";
        public const string ClassIdAttr = "id_class";
        public const string TypeOfLevelQualityAttr = "name_imp";
        public GeneralLevelOfQualityNorm(string norm) : base(norm)
        {
        }
        public GeneralLevelOfQualityNorm(string raw, string classRaw) : base(raw, classRaw)
        {
        }
        public GeneralLevelOfQualityNorm(string typeImp, string norm, string raw, string classRaw) : base(typeImp, norm, raw, classRaw)
        {
        }
        public GeneralLevelOfQualityNorm(string typeImp, string raw, string classRaw) : base(typeImp, raw, classRaw)
        {
        }
    }
}
