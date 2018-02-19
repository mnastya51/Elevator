using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elevator.Model;
using Elevator.Entity;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddContractorController
    {
        public void onSaveClick(Contractor contractor, bool forChange)
        {
            if (!forChange)
            {
                DAO.getInstance().addNote("Contractor", new FormValue<string, string>("name_contr", contractor.Name),
                    new FormValue<string, string>("subdivision ", contractor.Sub),
                    new FormValue<string, string>("jur_address", contractor.YurAdress),
                    new FormValue<string, string>("fact_address", contractor.FactAdress),
                    new FormValue<string, string>("mail_index", contractor.Index.ToString().Replace(" ", "") == "0" ? string.Empty : contractor.Index.ToString()),
                    new FormValue<string, string>("phone", contractor.Phone.Replace(" ", "").Length == 14 ? contractor.Phone : string.Empty),
                    new FormValue<string, string>("inn", contractor.Inn.ToString()));
            }
            else
            {
                DAO.getInstance().updateNote("Contractor", new FormValue<string, string>("id_contractor", contractor.Id.ToString()),
                    new FormValue<string, string>("name_contr", contractor.Name),
                    new FormValue<string, string>("subdivision ", contractor.Sub),
                    new FormValue<string, string>("jur_address", contractor.YurAdress),
                    new FormValue<string, string>("fact_address", contractor.FactAdress),
                    new FormValue<string, string>("mail_index", contractor.Index.ToString().Replace(" ", "") == "0" ? string.Empty : contractor.Index.ToString()),
                    new FormValue<string, string>("phone", contractor.Phone.Replace(" ", "").Length == 14 ? contractor.Phone : string.Empty),
                    new FormValue<string, string>("inn", contractor.Inn.ToString()));
            }
        }

        public int checkIndex(string index)
        {
            try
            {
                if (index.Replace(" ", "").Length > 6)
                {
                    MessageBox.Show("Длина индекса должа быть равна 6", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return Convert.ToInt32(index.Substring(0, index.Length - 1));
                }
                return Convert.ToInt32(index);
            } catch (Exception e)
            {
                return -1;
            }
        }

        public bool checkSaveForIndex(string index)
        {
            if (index.Length == 0) return true;
            if (index.Length != 6) return false;
            return true;
        }

        public Int64 checkInn(string inn)
        {
            try
            {
                if (inn.Replace(" ", "").Length > 12)
                {
                    MessageBox.Show("Длина ИНН должа быть равна 12", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return Convert.ToInt64(inn.Substring(0, inn.Length - 1));
                }
                return Convert.ToInt64(inn);
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public bool checkSaveForInn(string inn)
        {
            if (inn.Length == 0) return true;
            if (inn.Length != 12) return false;
            return true;
        }

        public bool isSaveEnable(string text1, string text2)
        {
            return text1.Replace(" ", "").Length > 0 && text2.Replace(" ", "").Length > 0;
        }

        public static bool isEmpty(string text)
        {
            return text == null || text == string.Empty || text.Length == 0;
        }

        public bool checkSaveForAll(string name, string factAddress, string index, string inn, string phone)
        {
            return isSaveEnable(name, factAddress) && checkSaveForIndex(index) && checkSaveForInn(inn) && checkPhone(phone);
        }

        public bool checkPhone(string phone)
        {
            return phone.Replace(" ", "").Length == 14 || phone == "8(   )   -";
        }
        
    }
}