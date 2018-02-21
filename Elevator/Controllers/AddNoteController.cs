using Elevator.Entity;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
   class AddNoteController
    {
        public bool onSaveClick(Note note)
        {
            if (!DAO.getInstance().addNote("Class", new FormValue<string, string>("number_class", note.NumberClass.ToString()),
                new FormValue<string, string> ("id_NameRaw ", note.IdNameRaw.ToString())))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }                  
             else return true; 
        }
    }
}


