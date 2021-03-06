﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elevator.Model;

namespace Elevator.Controllers
{
    class AddlevelOfQualityController
    {
        public bool onSaveClick(FormValue<string, string> formValue, string value)
        {
            if (!DAO.getInstance().addNote(formValue.getKey(), new FormValue<string, string> (formValue.getValue(), value)))
            {
                MessageBox.Show("Данный показатель уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        public bool checkSave(string name)
        {
            return isNotEmpty(name);
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
