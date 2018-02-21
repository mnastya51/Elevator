using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Entity
{
    public class Note
    {
        public int Id { get; set; }
        public int IdNameRaw { get; set; }
        public int Column { get; set; }

        public Note()
        {
        }
        public Note(int idClass, int idNameRaw, int column)
        {
            this.Id = idClass;
            this.IdNameRaw = idNameRaw;
            this.Column = column;
        }
        public Note(int column, int idNameRaw)
        {
           this.Column = column;
           this.IdNameRaw = idNameRaw;
        }
    }
}
