﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elevator.Model;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddContractorController
    {
        public bool onSaveClick(Contractor contractor, bool forChange)
        {
            if (!forChange)
            {
                if (!DAO.getInstance().addNote("Contractor", new FormValue<string, string>("name_contr", contractor.Name),
                    new FormValue<string, string>("subdivision ", contractor.Sub),
                    new FormValue<string, string>("jur_address", contractor.YurAdress),
                    new FormValue<string, string>("fact_address", contractor.FactAdress),
                    new FormValue<string, string>("mail_index", contractor.Index.ToString().Replace(" ", "") == "0" ? string.Empty : contractor.Index.ToString()),
                    new FormValue<string, string>("phone", contractor.Phone.Replace(" ", "").Length == 14 ? contractor.Phone : string.Empty),
                    new FormValue<string, string>("inn", contractor.Inn.ToString())))
                {
                    MessageBox.Show("Данный контрагент уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;                
                }
                else return true;
            }
            else
            {
                if(!DAO.getInstance().updateNote("Contractor", new FormValue<string, string>("id_contractor", contractor.Id.ToString()),
                    new FormValue<string, string>("name_contr", contractor.Name),
                    new FormValue<string, string>("subdivision ", contractor.Sub),
                    new FormValue<string, string>("jur_address", contractor.YurAdress),
                    new FormValue<string, string>("fact_address", contractor.FactAdress),
                    new FormValue<string, string>("mail_index", contractor.Index.ToString().Replace(" ", "") == "0" ? string.Empty : contractor.Index.ToString()),
                    new FormValue<string, string>("phone", contractor.Phone.Replace(" ", "").Length == 14 ? contractor.Phone : string.Empty),
                    new FormValue<string, string>("inn", contractor.Inn.ToString())))
                {
                    MessageBox.Show("Данный контрагент уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
        }

        public bool checkSaveForIndex(string index)
        {
            if (index.Length == 0) return true;
            if (index.Length != 6) return false;
            return true;
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