using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class RawSubtype
    {
        public int SubtypeId { get; set; }
        public string TypeId { get; set; }
        public const string SubtypeIdAttr = "id_subtype";
        public const string TypeIdAttr = "id_type";
        public const string SubtypeNameAttr = "name_subtype";
        public const string NameTable = "Subtype_raw";
        public int SubtypeName { get; set; }

        public RawSubtype(int subtypeId, string typeId, int subtypeName)
        {
            this.SubtypeId = subtypeId;
            this.TypeId = typeId;
            this.SubtypeName = subtypeName;
        }

        public RawSubtype(string typeId)
        {
            this.TypeId = typeId;
        }

        public RawSubtype(int subtypeName, string typeId)
        {
            this.SubtypeName = subtypeName;
            this.TypeId = typeId;
        }

        public RawSubtype(string typeId, int subtypeId)
        {
            this.SubtypeId = subtypeId;
            this.TypeId = typeId;
        }
    }
}
