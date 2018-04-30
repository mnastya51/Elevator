using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class Clearing
    {
        public string IdRaw { get; set; }
        public string Date { get; set; }
        public string WeightBefore { get; set; }
        public string WeightAfter { get; set; }

        public Clearing(string newIdRaw, string newDate, string newWeightBefore, string newWeightAfter)
        {
            this.IdRaw = newIdRaw;
            this.Date = newDate;
            this.WeightBefore = newWeightBefore;
            this.WeightAfter = newWeightAfter;
        }
    }
}
