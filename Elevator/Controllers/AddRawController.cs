using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddRawController
    {
        public bool onSaveClick(Raw raw, bool forChange)
        {
            if (!forChange)
            {
                if(!DAO.getInstance().addNote("Raw", new FormValue<string, string>("name_raw", raw.Name),
                 new FormValue<string, string>("number_gost  ", raw.Gost)))
                {
                    MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            else
            {
                if(!DAO.getInstance().updateNote("Raw", new FormValue<string, string>("id_NameRaw ", raw.Id.ToString()),
                    new FormValue<string, string>("name_raw", raw.Name),
                new FormValue<string, string>("number_gost  ", raw.Gost)))
                {
                    MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            
        }
        public bool checkSave(string surname)
        {
            return isNotEmpty(surname);
        }
        public bool isNotEmpty(string text)
        {
            return text.Replace(" ", "").Length > 0;
        }
        public static bool isEmpty(string text)
        {
            return text == null || text == string.Empty || text.Length == 0;
        }
    }
}
