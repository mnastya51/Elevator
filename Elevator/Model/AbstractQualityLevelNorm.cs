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
        public string ClassRaw { get; set; }
        public string TypeImp { get; set; }
        public AbstractQualityLevelNorm(string norm)
        {
            this.Norm = norm;
        }
        public AbstractQualityLevelNorm(string raw, string classRaw)
        {
            this.Raw = raw;
            this.ClassRaw = classRaw;
        }
    }
}
