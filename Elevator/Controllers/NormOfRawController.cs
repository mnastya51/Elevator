using Elevator.AddAndEditForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class NormOfRawController
    {
        public void addButtonClick(string nameTable, string name_imp,  LinkedList<string> impurities, string norm, string raw, string nameTableNorm)
        {
            new AddNormOfRawForm(nameTable,  name_imp,  impurities, norm, raw, nameTableNorm).ShowDialog();
        }
    }
}
