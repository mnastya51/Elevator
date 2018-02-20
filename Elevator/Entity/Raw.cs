using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Entity
{
    public class Raw
    {
        public string Name { get; set; }
        public string Gost { get; set; }

        public Raw()
        {
        }

        public Raw(string name, string gost)
        {
            this.Name = name;
            this.Gost = gost;
        }

        public Raw(string name)
        {
            this.Name = name;
        }
    } 
}
