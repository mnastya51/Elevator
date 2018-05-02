using Elevator.AddAndEditForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class StorageController
    {
        public void addButtonClick(string idRaw)
        {
            new AddStorageForm().ShowDialog();
        }
    }
}
