using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class AddStorageController
    {
        public bool checkSaveForAll(string number, string weight)
        {
            return isSaveEnable(number, weight);
        }

        public bool isSaveEnable(string text1, string text2)
        {
            return text1.Replace(" ", "").Length > 0 && text2.Replace(" ", "").Length > 0;
        }

        public bool isEmpty(string text)
        {
            return text == null || text == string.Empty || text.Length == 0;
        }
    }
}
