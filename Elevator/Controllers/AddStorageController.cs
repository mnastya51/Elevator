using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddStorageController
    {
        public bool onAddClick(StoragePlace storagePlace, StoreStoragePlace storeStoragePlace)
        {
            string weight = storeStoragePlace.Weight.Replace(",", ".");
            if (!DAO.getInstance().addStoragePlace(storagePlace.IdRaw, storeStoragePlace.Number,
                weight, StoreStoragePlace.NameTable, StoreStoragePlace.NumberAttr, StoreStoragePlace.WeightAttr))
            {
                MessageBox.Show("Данное сырье уже присутствует в данном хранилище!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        public bool onUpdateClick(StoreStoragePlace storeStoragePlace, string number)
        {
            string weight = storeStoragePlace.Weight.Replace(",", ".");
            if (!DAO.getInstance().updateStoragePlace(storeStoragePlace.IdRaw, storeStoragePlace.Number,
                weight, StoreStoragePlace.NameTable, StoreStoragePlace.NumberAttr, StoreStoragePlace.WeightAttr,
                storeStoragePlace.IdPlaceStorage, number))
            {
                MessageBox.Show("Данное сырье уже присутствует в данном хранилище!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        public bool onAddClick(StoragePlace storagePlace, SilageStoragePlace silageStoragePlace)
        {
            string weight = silageStoragePlace.Weight.Replace(",", ".");
            if (!DAO.getInstance().addStoragePlace(storagePlace.IdRaw, silageStoragePlace.Number,
                weight, SilageStoragePlace.NameTable, SilageStoragePlace.NumberAttr, SilageStoragePlace.WeightAttr))
            {
                MessageBox.Show("Данное сырье уже присутствует в данном хранилище!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        public bool onUpdateClick(SilageStoragePlace silageStoragePlace, string number)
        {
            string weight = silageStoragePlace.Weight.Replace(",", ".");
            if (!DAO.getInstance().updateStoragePlace(silageStoragePlace.IdRaw, silageStoragePlace.Number,
                weight, SilageStoragePlace.NameTable, SilageStoragePlace.NumberAttr, SilageStoragePlace.WeightAttr,
                silageStoragePlace.IdPlaceStorage, number))
            {
                MessageBox.Show("Данное сырье уже присутствует в данном хранилище!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
       

        public bool checkSave(string name)
        {
            return isNotEmpty(name);
        }
        public bool isNotEmpty(string text)
        {
            return text.Replace(" ", "").Length > 0;
        }       

        public bool isEmpty(string text)
        {
            return text == null || text == string.Empty || text.Length == 0;
        }
    }
}
