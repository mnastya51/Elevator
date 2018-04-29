using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class DateAnalys
    {
        public string Id { get; set; }
        public int IdContractor { get; set; }
        public int IdRaw { get; set; }
        public string Date { get; set; }

        public DateAnalys(int idContractor, int idRaw)
        {
            this.IdContractor = idContractor;
            this.IdRaw = idRaw;
        }

        public DateAnalys(string id, string date)
        {
            this.Id = id;
            this.Date = date;
        }
    }
}
