using Elevator.AddAndEditForms;
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
        public void addNoteButtonClick(string field, int idNameraw, string newNameTable, string newColumn, string parentColumn)
        {
            new AddNoteForm(field, idNameraw, newNameTable, newColumn, parentColumn).ShowDialog();
        }
        public void deleteNoteButtonClick(string nameTable, string column, string id)
        {
            DAO.getInstance().deleteNote (nameTable, new FormValue<string, string>(column, id));
        }
    }
}
