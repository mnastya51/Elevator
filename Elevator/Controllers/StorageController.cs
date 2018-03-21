using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class StorageController
    {//string nameTable, int value, int storage, string nameStorage
        public void onSaveClick(Store store, int storage)
        {
            if (storage == 0)
                DAO.getInstance().addStorage(Store.NameTable, storage, store.Count);
            else if (storage < store.Count)
                DAO.getInstance().addStorage(Store.NameTable, storage, store.Count - storage);
            else if(storage > store.Count)
                DAO.getInstance().deleteStorage(Store.NameTable, storage, storage - store.Count, Store.CountAttr);
        }

        public void onSaveClick(Silage silage, int storage)
        {
            if (storage == 0)
                DAO.getInstance().addStorage(Silage.NameTable, storage, silage.Count);
            else if (storage < silage.Count)
                DAO.getInstance().addStorage(Silage.NameTable, storage, silage.Count - storage);
            else if (storage > silage.Count)
                DAO.getInstance().deleteStorage(Silage.NameTable, storage, storage - silage.Count, Silage.CountAttr);
        }

        public Int32 getStorage(string nameTable, string column)
        {
            return DAO.getInstance().getStorage(nameTable, column);
        }
    }
}
