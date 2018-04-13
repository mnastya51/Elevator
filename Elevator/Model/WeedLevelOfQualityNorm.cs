using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class WeedLevelOfQualityNorm : AbstractQualityLevelNorm
    {
        public const string NameTable = "Norm_weed_impurities";
        public const string NormAttr = "norm_weed_imp";
        public const string ClassIdAttr = "id_class";
        public const string TypeOfLevelQualityAttr = "name_weed_imp";
        public const string IdAttr = "id_norm_weed";
        public WeedLevelOfQualityNorm(string norm) : base(norm)
        {
        }
        public WeedLevelOfQualityNorm(string raw, string classRaw) : base(raw, classRaw)
        {
        }
        public WeedLevelOfQualityNorm(string typeImp, string norm, string raw, string classRaw) : base(typeImp, norm, raw, classRaw)
        {
        }
        public WeedLevelOfQualityNorm(string typeImp, string raw, string classRaw) : base(typeImp, raw, classRaw)
        {
        }
    }
}
