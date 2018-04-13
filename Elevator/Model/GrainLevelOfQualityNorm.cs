using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class GrainLevelOfQualityNorm : AbstractQualityLevelNorm
    {
        public const string NameTable = "Norm_grain_impurities";
        public const string NormAttr = "norm_grain_imp";
        public const string ClassIdAttr = "id_class";
        public const string TypeOfLevelQualityAttr = "name_grain_imp";
        public const string IdAttr = "id_norm_grain";
        public GrainLevelOfQualityNorm(string norm) : base(norm)
        {
        }
        public GrainLevelOfQualityNorm(string raw, string classRaw) : base(raw, classRaw)
        {
        }
        public GrainLevelOfQualityNorm(string typeImp, string norm, string raw, string classRaw) : base(typeImp, norm, raw, classRaw)
        {
        }
        public GrainLevelOfQualityNorm(string typeImp, string norm, string id) : base(typeImp, norm, id)
        {
        }
    }
}
