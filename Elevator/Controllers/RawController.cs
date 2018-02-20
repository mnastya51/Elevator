using Elevator.AddForms;
using Elevator.Entity;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class RawController
    {
        public void addButtonClick()
        {
            new AddRawForm().ShowDialog();
        }
        public void changeButtonClick(Raw raw)
        {
            new AddRawForm(raw).ShowDialog();
        }
        public void deleteButtonClick(string id)
        {
            DAO.getInstance().deleteNote("Raw", new FormValue <string, string>("id_NameRaw", id));
        }
    }
}
