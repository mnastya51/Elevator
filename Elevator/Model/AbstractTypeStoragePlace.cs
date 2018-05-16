using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public abstract class AbstractTypeStoragePlace
    {
        public int Count { get; set; }
        public AbstractTypeStoragePlace(int count)
        {
            this.Count = count;
        }
    }
}
