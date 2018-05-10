using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddClearingController
    {
        public bool onSaveClick(Clearing clearing, string raw, bool forChange)
        {
            if (!forChange)
            {
                string[] classes = DAO.getInstance().getClasses(raw);
                if (classes.Length > 0)
                {
                    LinkedList<FormValue<string, string>> valueH = DAO.getInstance().defineStateForClass(clearing.IdRaw,
                    classes[classes.Length-1], HarmfulLevelOfQualityNorm.NormAttr, HarmfulLevelOfQualityNorm.NameTable,
                    HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr);
                    FormValue<string, string>[] valueHarmful = valueH.ToArray<FormValue<string, string>>();

                    LinkedList<FormValue<string, string>> valueW = DAO.getInstance().defineStateForClass(clearing.IdRaw,
                    classes[classes.Length - 1], WeedLevelOfQualityNorm.NormAttr, WeedLevelOfQualityNorm.NameTable,
                   WeedLevelOfQualityNorm.TypeOfLevelQualityAttr);
                    FormValue<string, string>[] valueWeed = valueW.ToArray<FormValue<string, string>>();

                    LinkedList<FormValue<string, string>> valueG = DAO.getInstance().defineStateForClass(clearing.IdRaw,
                    classes[classes.Length - 1], GrainLevelOfQualityNorm.NormAttr, GrainLevelOfQualityNorm.NameTable,
                    GrainLevelOfQualityNorm.TypeOfLevelQualityAttr);
                    FormValue<string, string>[] valueGrain = valueG.ToArray<FormValue<string, string>>();

                    if (!DAO.getInstance().addClearing(clearing.Date, clearing.IdRaw, clearing.WeightBefore,
                clearing.WeightAfter, valueHarmful, valueWeed, valueGrain, clearing.IdContractor))
                    {
                        MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        DAO.getInstance().updateNote("Storage", new FormValue<string, string>("id_raw", clearing.IdRaw), new FormValue<string, string>("id_class", Convert.ToString(classes.Length - 1)));
                        return true;
                    }
                }
                else
                {
                    string[] typeAndSubtype = DAO.getInstance().selectTypeAndSubtype(clearing.IdRaw);
                    string type = typeAndSubtype[0];
                    LinkedList<FormValue<string, string>> valueH = DAO.getInstance().defineState(clearing.IdRaw, type,
                    HarmfulLevelOfQualityNorm.NormAttr,
                    HarmfulLevelOfQualityNorm.NameTable,
                    HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr);
                    FormValue<string, string>[] valueHarmful = valueH.ToArray<FormValue<string, string>>();

                    LinkedList<FormValue<string, string>> valueW = DAO.getInstance().defineState(clearing.IdRaw, type,
                    WeedLevelOfQualityNorm.NormAttr,
                    WeedLevelOfQualityNorm.NameTable,
                    WeedLevelOfQualityNorm.TypeOfLevelQualityAttr);
                    FormValue<string, string>[] valueWeed = valueW.ToArray<FormValue<string, string>>();

                    LinkedList<FormValue<string, string>> valueG = DAO.getInstance().defineState(clearing.IdRaw, type,
                    GrainLevelOfQualityNorm.NormAttr,
                    GrainLevelOfQualityNorm.NameTable,
                    GrainLevelOfQualityNorm.TypeOfLevelQualityAttr);
                    FormValue<string, string>[] valueGrain = valueG.ToArray<FormValue<string, string>>();

                    if (!DAO.getInstance().addClearing(clearing.Date, clearing.IdRaw, clearing.WeightBefore,
               clearing.WeightAfter, valueHarmful, valueWeed, valueGrain, clearing.IdContractor))
                    {
                        MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else return true;
                }
            }
            else
            {
                if (!DAO.getInstance().updateClearing(clearing.Date, clearing.IdRaw, clearing.WeightBefore,
                    clearing.WeightAfter, clearing.IdContractor))
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
