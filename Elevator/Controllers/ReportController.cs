using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elevator.Model;

namespace Elevator.Controllers
{
    public class ReportController
    {
        public bool hasRawInPeriod(string dateS, string datePo)
        {
            if (DAO.getInstance().hasSpareInPeriod(dateS, datePo))
                return true;
            else
                return false;
        }
    }
}
