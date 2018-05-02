using Elevator.AddAndEditForms;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class ProcessingController
    {
        public void addButtonClick(string idRaw, string raw)
        {
            new AddDryForm(idRaw, raw).ShowDialog();
        }
        public void changeButtonClick(Drying drying)
        {
            new AddDryForm(drying).ShowDialog();
        }
        public void addButtonClearClick(string idRaw, string raw)
        {
           new AddClearingForm(idRaw, raw).ShowDialog();
        }
        public void changeButtonClearClick(Clearing clearing)
        {
            new AddClearingForm(clearing).ShowDialog();
        }
    }
}
