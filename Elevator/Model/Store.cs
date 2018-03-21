using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class Store:AbstractStorage
    {
        public const string NameTable = "Store";
        public const string CountAttr = "numb_store";
        public Store(int count) : base(count)
        {
        }
    }
}
