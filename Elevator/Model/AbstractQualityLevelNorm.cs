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
        public string Id { get; set; }

        public AbstractQualityLevelNorm() { }

        public AbstractQualityLevelNorm(string id)
        {
            this.Id = id;
        }

        public AbstractQualityLevelNorm(string raw, string classRaw)
        {
            this.Raw = raw;
            this.ClassRaw = classRaw;
        }

        public AbstractQualityLevelNorm(string typeImp, string norm, string raw, string classRaw)
        {
            this.Raw = raw;
            this.ClassRaw = classRaw;
            this.TypeImp = typeImp;
            this.Norm = norm;
        }

        public AbstractQualityLevelNorm(string typeImp, string norm, string id)
        {
            this.Norm = norm;
            this.Id = id;
            this.TypeImp = typeImp;
        }
    }
}
