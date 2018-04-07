using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class AbstractLevelOfQuality
    {
        public string LevelQuality { get; set; }
        public string IdRaw { get; set; }
        public string Value { get; set; }

        public AbstractLevelOfQuality(string levelOfQuality, string idRaw, string value)
        {
            this.LevelQuality = levelOfQuality;
            this.IdRaw = idRaw;
            this.Value = value;
        }

        public AbstractLevelOfQuality(string idRaw)
        {
            this.IdRaw = idRaw;
        }
    }
}
