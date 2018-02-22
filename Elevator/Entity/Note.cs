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
        public int ParentColumn { get; set; }
        public int Column { get; set; }

        public Note()
        {
        }
        public Note(int idClass, int parentColumn, int column)
        {
            this.Id = idClass;
            this.ParentColumn = parentColumn;
            this.Column = column;
        }
        public Note(int column, int parentColumn)
        {
           this.Column = column;
           this.ParentColumn = parentColumn;
        }
    }
}
