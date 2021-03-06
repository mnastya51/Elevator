﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class Drying
    {
        public string IdRaw { get; set; }
        public string IdContractor { get; set; }
        public string Date { get; set; }
        public string WeightBefore { get; set; }
        public string WeightAfter { get; set; }
        public string WetAfter { get; set; }
        public string WetBefore { get; set; }

        public Drying(string newIdRaw, string idContractor, string newDate, string newWeightBefore, string newWeightAfter,
            string newWetBefore, string newWetAfter)
        {
            this.IdRaw = newIdRaw;
            this.Date = newDate;
            this.WeightBefore = newWeightBefore;
            this.WeightAfter = newWeightAfter;
            this.WetBefore = newWetBefore;
            this.WetAfter = newWetAfter;
            this.IdContractor = idContractor;
        }
    }
}
