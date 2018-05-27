using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class StoragePlaceController
    {//string nameTable, int value, int storage, string nameStorage
        public bool onSaveClick(Store store, int storage)
        {
            if (storage == 0)
            {
                DAO.getInstance().addStorage(Store.NameTable, storage, store.Count);
                return true;
            }
            else if (storage < store.Count)
            {
                DAO.getInstance().addStorage(Store.NameTable, storage, store.Count - storage);
                return true;
            }
            else if (storage > store.Count)
            {
                try
                {
                    DAO.getInstance().deleteStorage(Store.NameTable, storage, storage - store.Count, Store.CountAttr);
                    return true;
                }
                catch
                {
                    MessageBox.Show("В одном из хранилищ находится зерно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public bool onSaveClick(Silage silage, int storage)
        {
            if (storage == 0)
            {
                DAO.getInstance().addStorage(Silage.NameTable, storage, silage.Count);
                return true;
            }
            else if (storage < silage.Count)
            {
                DAO.getInstance().addStorage(Silage.NameTable, storage, silage.Count - storage);
                return true;
            }
            else if (storage > silage.Count)
            {
                try
                {
                    DAO.getInstance().deleteStorage(Silage.NameTable, storage, storage - silage.Count, Silage.CountAttr);
                    return true;
                }
                catch
                {
                    MessageBox.Show("В одном из хранилищ находится зерно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public Int32 getStorage(string nameTable, string column)
        {
            return DAO.getInstance().getStorage(nameTable, column);
        }
    }
}
