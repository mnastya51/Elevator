﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class Silage : AbstractTypeStoragePlace
    {
        public const double Capacity = 150;
        public const string NameTable = "Silage";
        public const string CountAttr = "numb_silage";
        public Silage(int count) : base(count)
        {
        }
    }
}
