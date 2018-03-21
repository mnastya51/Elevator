﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class Storage
    {
        public string Raw { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string Year { get; set; }

        public Storage(string raw, string type, string subtype, string year)
        {
            this.Raw = raw;
            this.Type = type;
            this.Subtype = subtype;
            this.Year = year;
        }
    }
}
