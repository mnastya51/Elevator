﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class Store:AbstractTypeStoragePlace
    {
        public const double Capacity = 3500;
        public const string NameTable = "Store";
        public const string CountAttr = "numb_store";
        public Store(int count) : base(count)
        {
        }
    }
}
