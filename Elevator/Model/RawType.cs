using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class RawType
    {
        public int TypeId { get; set; }
        public string RawId { get; set; }
        public const string TypeIdAttr = "id_type";
        public const string RawIdAttr = "id_NameRaw";
        public const string TypeNameAttr = "name_type_raw";
        public const string NameTable = "Type_raw";
        public int TypeName { get; set; }

        public RawType(int typeId, string rawId, int typeName)
        {
            this.TypeId = typeId;
            this.RawId = rawId;
            this.TypeName = typeName;
        }

        public RawType(string rawId)
        {
            this.RawId = rawId;
        }


        public RawType(int typeName, string rawId)
        {
            this.TypeName = typeName;
            this.RawId = rawId;
        }

        public RawType(string rawId, int typeId)
        {
            this.TypeId = typeId;
            this.RawId = rawId;
        }
    }
}
