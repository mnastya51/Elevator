using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class StorageController
    {
        public void onSaveClick(string nameTable, int value, int storage, string nameStorage)
        {
            if (storage == 0)
                DAO.getInstance().addStorage(nameTable, storage, value);
            else if (storage < value)
                DAO.getInstance().addStorage(nameTable, storage, value - storage);
            else if(storage > value)
                DAO.getInstance().deleteStorage(nameTable, storage, storage - value, nameStorage);
        }
        public Int32 getStorage(string nameTable, string column)
        {
            return DAO.getInstance().getStorage(nameTable, column);
        }
    }
}
