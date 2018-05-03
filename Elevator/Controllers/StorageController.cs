using Elevator.AddAndEditForms;
using Elevator.Model;
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
            new AddStorageForm(idRaw).ShowDialog();
        }

        public void changeButtonClick(StoreStoragePlace store)
        {
            new AddStorageForm(store).ShowDialog();
        }

        public void changeButtonClick(SilageStoragePlace silage)
        {
            new AddStorageForm(silage).ShowDialog();
        }
    }
}
