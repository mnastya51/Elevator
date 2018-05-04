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
        public void addButtonClick(string idRaw, string raw, string type, string subtype, string classRaw, double weight)
        {
            new AddStorageForm(idRaw, raw, type, subtype, classRaw, weight).ShowDialog();
        }

        public void changeButtonClick(StoreStoragePlace store, string raw, string type, string subtype, string classRaw)
        {
            new AddStorageForm(store, raw, type, subtype, classRaw).ShowDialog();
        }

        public void changeButtonClick(SilageStoragePlace silage, string raw, string type, string subtype, string classRaw)
        {
            new AddStorageForm(silage, raw, type, subtype, classRaw).ShowDialog();
        }
    }
}
