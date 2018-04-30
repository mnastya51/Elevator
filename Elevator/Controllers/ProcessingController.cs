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
        public void addButtonClick(string idRaw)
        {
            new AddDryForm(idRaw).ShowDialog();
        }
        public void changeButtonClick(Drying drying)
        {
            new AddDryForm(drying).ShowDialog();
        }
    }
}
