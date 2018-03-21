using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public abstract class AbstractStorage
    {
        public int Count { get; set; }
        public AbstractStorage(int count)
        {
            this.Count = count;
        }
    }
}
