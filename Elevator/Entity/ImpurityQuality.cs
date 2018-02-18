using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Forms
{
    class ImpurityQualityClass
    {
        void qwe(string name, string[] values)
        {
            string val = string.Empty;
            val += values[0];
            for (int i = 1; i < values.Length; i++)
            {
                val += ", " + values[i];
            }



            string.Format("Insert /'{0}/' values({1})", name, val);
        }
    }
}
