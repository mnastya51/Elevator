﻿using Elevator.Entity;
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
        public bool onSaveClick(Note note, string nameTable, string column, string parentColumn)
        {
            if (!DAO.getInstance().addNote(nameTable, new FormValue<string, string>(column, note.Column.ToString()),
                new FormValue<string, string> (parentColumn, note.ParentColumn.ToString())))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }                  
             else return true; 
        }
    }
}

