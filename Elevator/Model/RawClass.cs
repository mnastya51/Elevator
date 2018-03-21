using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
   public class RawClass//string RawId, но  int ClassId. конструктор перегружен. добиться работоспособности
    {
        public int ClassId { get; set; }
        public string RawId { get; set; }
        public const string RawIdAttr = "id_NameRaw";
        public const string ClassIdAttr = "id_class";
        public const string ClassNameAttr = "number_class";
        public const string NameTable = "Class";
        public int ClassName { get; set; }

        public RawClass(int classId, string rawId, int className)
        {
            this.ClassId = classId;
            this.RawId = rawId;
            this.ClassName = className;
        }

        public RawClass(string rawId)
        {
            this.RawId = rawId;
        }


        public RawClass(int className, string rawId)
        {
            this.ClassName = className;
            this.RawId = rawId;
        }

        public RawClass(string rawId, int classId)
        {
            this.ClassId = classId;
            this.RawId = rawId;
        }
    }
}
