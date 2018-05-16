using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public abstract class AbstractLevelOfQualityNorm
    {
        public string Norm { get; set; }
        public string Raw { get; set; }
        public string ClassRaw { get; set; }
        public string TypeImp { get; set; }
        public string Id { get; set; }

        public AbstractLevelOfQualityNorm() { }

        public AbstractLevelOfQualityNorm(string id)
        {
            this.Id = id;
        }

        public AbstractLevelOfQualityNorm(string raw, string classRaw)
        {
            this.Raw = raw;
            this.ClassRaw = classRaw;
        }

        public AbstractLevelOfQualityNorm(string typeImp, string norm, string raw, string classRaw)
        {
            this.Raw = raw;
            this.ClassRaw = classRaw;
            this.TypeImp = typeImp;
            this.Norm = norm;
        }

        public AbstractLevelOfQualityNorm(string typeImp, string norm, string id)
        {
            this.Norm = norm;
            this.Id = id;
            this.TypeImp = typeImp;
        }
    }
}
