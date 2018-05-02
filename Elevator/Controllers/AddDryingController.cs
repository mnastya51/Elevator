using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddDryController
    {
        public bool onSaveClick(Drying drying, string raw, bool forChange)
        {
            if (!forChange)
            {
                string[] classes = DAO.getInstance().getClasses(raw);
                if (classes.Length > 0)
                {
                    LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(drying.IdRaw,
                   classes[classes.Length - 1], GeneralLevelOfQualityNorm.NormAttr, GeneralLevelOfQualityNorm.NameTable,
                   GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr);
                    FormValue<string, string>[] valueGeneral = value.ToArray<FormValue<string, string>>();

                    if (!DAO.getInstance().addDry(valueGeneral, drying.Date, drying.IdRaw, drying.WeightBefore,
                    drying.WeightAfter, drying.WetBefore, drying.WetAfter))
                  {
                      MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      return false;
                  }
                  else 
                    return true;
                }
                else {
                    string[] typeAndSubtype = DAO.getInstance().selectTypeAndSubtype(drying.IdRaw);
                    string type = typeAndSubtype[0];

                    LinkedList<FormValue<string, string>> value = DAO.getInstance().defineState(drying.IdRaw, type, GeneralLevelOfQualityNorm.NormAttr,
                    GeneralLevelOfQualityNorm.NameTable,
                    GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr);
                    FormValue<string, string>[] valueGeneral = value.ToArray<FormValue<string, string>>();

                    if (!DAO.getInstance().addDry(valueGeneral, drying.Date, drying.IdRaw, drying.WeightBefore,
                    drying.WeightAfter, drying.WetBefore, drying.WetAfter))
                    {
                        MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else return true;
                }
            }
            else
            {
                if (!DAO.getInstance().updateDry(drying.IdRaw, drying.Date, drying.WeightBefore,
                    drying.WeightAfter, drying.WetBefore, drying.WetAfter))
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
        public bool isEmpty(string text)
        {
            return text == null || text == string.Empty || text.Length == 0;
        }
    }
}
