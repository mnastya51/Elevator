using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Entity
{
    public class Note
    {
        public int IdClass { get; set; }
        public int IdNameRaw { get; set; }
        public int NumberClass { get; set; }

        public Note()
        {
        }
        public Note(int idClass, int idNameRaw, int numberClass)
        {
            this.IdClass = idClass;
            this.IdNameRaw = idNameRaw;
            this.NumberClass = numberClass;
        }
        public Note(int numberClass, int idNameRaw)
        {
           this.NumberClass = numberClass;
           this.IdNameRaw = idNameRaw;
        }
    }
}
