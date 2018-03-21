using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public abstract class AbstractQualityLevelNorm
    {
        public string Norm { get; set; }
        public string Raw { get; set; }
        public int ClassRaw { get; set; }
        public string TypeImp { get; set; }
        public AbstractQualityLevelNorm(string norm)
        {
            this.Norm = norm;
        }
        public AbstractQualityLevelNorm(string raw, int classRaw)
        {
            this.Raw = raw;
            this.ClassRaw = classRaw;
        }

        public AbstractQualityLevelNorm(string typeImp, string norm, string raw, int classRaw)
        {
            this.Raw = raw;
            this.ClassRaw = classRaw;
            this.TypeImp = typeImp;
            this.Norm = norm;
        }

        public AbstractQualityLevelNorm(string typeImp, string raw, int classRaw)
        {
            this.Raw = raw;
            this.ClassRaw = classRaw;
            this.TypeImp = typeImp;
        }
    }
}
