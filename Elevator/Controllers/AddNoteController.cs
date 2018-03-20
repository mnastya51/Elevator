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
        public bool onSaveClick(RawClass rawClass, string nameTable, string column, string parentColumn)
        {
            if (!DAO.getInstance().addNote(nameTable, new FormValue<string, string>(column, rawClass.ClassName.ToString()),
                new FormValue<string, string> (parentColumn, rawClass.RawId.ToString())))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }                  
             else return true; 
        }
    }
}


