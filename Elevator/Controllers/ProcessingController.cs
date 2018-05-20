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
        public void addButtonClick(string idRaw, string idContractor, string raw, string weightBefore)
        {
            new AddDryForm(idRaw, idContractor, raw, weightBefore).ShowDialog();
        }
        public void changeButtonClick(Drying drying)
        {
            new AddDryForm(drying).ShowDialog();
        }
        public void addButtonClearClick(string idRaw, string idContractor, string raw, string weightBefore)
        {
           new AddClearingForm(idRaw, idContractor, raw, weightBefore).ShowDialog();
        }
        public void changeButtonClearClick(Clearing clearing)
        {
            new AddClearingForm(clearing).ShowDialog();
        }
    }
}
