using Elevator.AddAndEditForms;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void addClassButtonClick(string field, RawClass rawClass)
        {//"class, number_class", "id_NameRaw", "id_class"
            if (DAO.getInstance().deleteChild(RawClass.NameTable, RawClass.ClassIdAttr, RawClass.RawIdAttr, Convert.ToInt32(rawClass.RawId), RawClass.ClassNameAttr))
            {
                MessageBox.Show("Нельзя добавить новую запись, если выбранное сырье, не имея классов, используется в других таблицах!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
                new AddNoteForm(field, rawClass.RawId, RawClass.NameTable, RawClass.ClassNameAttr, RawClass.RawIdAttr).ShowDialog();
        }

        public void addTypeButtonClick(string field, RawType rawType)
        {
             new AddNoteForm(field, rawType.RawId, RawType.NameTable, RawType.TypeNameAttr, RawType.RawIdAttr).ShowDialog();
        }

        public void addSubtypeButtonClick(string field, RawSubtype rawSubtype)
        {//"class, number_class", "id_NameRaw", "id_class"
            if (DAO.getInstance().deleteChild(RawSubtype.NameTable, RawSubtype.SubtypeIdAttr, RawSubtype.TypeIdAttr, rawSubtype.TypeId, RawSubtype.SubtypeNameAttr))
            {
                MessageBox.Show("Нельзя добавить новую запись, если выбранный тип, не имея подтипов, используется в других таблицах!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                new AddNoteForm(field, rawSubtype.TypeId, RawSubtype.NameTable, RawSubtype.SubtypeNameAttr, RawSubtype.TypeIdAttr).ShowDialog();
        }

        public void deleteClassButtonClick(RawClass rawClass)
        {
            DAO.getInstance().deleteNote (RawClass.NameTable, new FormValue<string, string>(RawClass.ClassIdAttr, rawClass.ClassId.ToString()));
        }

        public void deleteTypeButtonClick(RawType rawType)
        {
            DAO.getInstance().deleteNote(RawType.NameTable, new FormValue<string, string>(RawType.TypeIdAttr, rawType.TypeId.ToString()));
        }

        public void deleteSubtypeButtonClick(RawSubtype rawSubtype)
        {
            DAO.getInstance().deleteNote(RawSubtype.NameTable, new FormValue<string, string>(RawSubtype.SubtypeIdAttr, rawSubtype.SubtypeId.ToString()));
        }
    }
}
