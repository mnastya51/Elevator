using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddNormOfRawController
    {
       /* public bool addClick(string nameTable, string name_imp, string valImp, string norm, string raw, string value, string numberClass)
        {
            if (!DAO.getInstance().addNorm(nameTable, name_imp, valImp, norm, raw, value, numberClass))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }*/

        public bool addClick(GeneralLevelOfQualityNorm generalLevelOfQualityNorm, string type, string subtype)
        {
            if (!DAO.getInstance().addNormGeneral(GeneralLevelOfQualityNorm.NameTable, GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr,
                generalLevelOfQualityNorm.TypeImp, GeneralLevelOfQualityNorm.NormAttr, generalLevelOfQualityNorm.Raw,
                 generalLevelOfQualityNorm.Norm, Convert.ToString(generalLevelOfQualityNorm.ClassRaw),
                 generalLevelOfQualityNorm.Isminimum, GeneralLevelOfQualityNorm.IsminimumAttr, type, subtype))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool addClick(HarmfulLevelOfQualityNorm harmfulLevelOfQualityNorm, string type, string subtype)
        {
            if (!DAO.getInstance().addNorm(HarmfulLevelOfQualityNorm.NameTable, HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr,
                harmfulLevelOfQualityNorm.TypeImp, HarmfulLevelOfQualityNorm.NormAttr, harmfulLevelOfQualityNorm.Raw,
                 harmfulLevelOfQualityNorm.Norm, Convert.ToString(harmfulLevelOfQualityNorm.ClassRaw), type, subtype))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool addClick(WeedLevelOfQualityNorm weedLevelOfQualityNorm, string type, string subtype)
        {
            if (!DAO.getInstance().addNorm(WeedLevelOfQualityNorm.NameTable, WeedLevelOfQualityNorm.TypeOfLevelQualityAttr,
                weedLevelOfQualityNorm.TypeImp, WeedLevelOfQualityNorm.NormAttr, weedLevelOfQualityNorm.Raw,
                 weedLevelOfQualityNorm.Norm, Convert.ToString(weedLevelOfQualityNorm.ClassRaw), type, subtype))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool addClick(GrainLevelOfQualityNorm grainLevelOfQualityNorm, string type, string subtype)
        {
            if (!DAO.getInstance().addNorm(GrainLevelOfQualityNorm.NameTable, GrainLevelOfQualityNorm.TypeOfLevelQualityAttr,
                grainLevelOfQualityNorm.TypeImp, GrainLevelOfQualityNorm.NormAttr, grainLevelOfQualityNorm.Raw,
                 grainLevelOfQualityNorm.Norm, Convert.ToString(grainLevelOfQualityNorm.ClassRaw), type, subtype))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

       /* public bool changeClick(string valueImp, string nameTable, string raw, string valueNorm, string nameImp, string nameNorm, string numberClass)
        {
            if (!DAO.getInstance().changeNorm(valueImp, nameTable, raw, valueNorm, nameImp, nameNorm, numberClass))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }*/

        public bool changeClick(GeneralLevelOfQualityNorm generalLevelOfQualityNorm)
        {
            if (!DAO.getInstance().changeNormGeneral(generalLevelOfQualityNorm.TypeImp, GeneralLevelOfQualityNorm.NameTable,
                generalLevelOfQualityNorm.Raw, generalLevelOfQualityNorm.Norm, GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr, 
                GeneralLevelOfQualityNorm.NormAttr, generalLevelOfQualityNorm.ClassRaw.ToString(), 
                generalLevelOfQualityNorm.Isminimum, GeneralLevelOfQualityNorm.IsminimumAttr))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool changeClick(HarmfulLevelOfQualityNorm harmfulLevelOfQualityNorm)
        {
            if (!DAO.getInstance().changeNorm(harmfulLevelOfQualityNorm.TypeImp, HarmfulLevelOfQualityNorm.NameTable,
                harmfulLevelOfQualityNorm.Raw, harmfulLevelOfQualityNorm.Norm, HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr,
                HarmfulLevelOfQualityNorm.NormAttr, harmfulLevelOfQualityNorm.ClassRaw.ToString()))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool changeClick(WeedLevelOfQualityNorm weedLevelOfQualityNorm)
        {
            if (!DAO.getInstance().changeNorm(weedLevelOfQualityNorm.TypeImp, WeedLevelOfQualityNorm.NameTable,
                weedLevelOfQualityNorm.Raw, weedLevelOfQualityNorm.Norm, WeedLevelOfQualityNorm.TypeOfLevelQualityAttr,
                WeedLevelOfQualityNorm.NormAttr, weedLevelOfQualityNorm.ClassRaw.ToString()))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool changeClick(GrainLevelOfQualityNorm grainLevelOfQualityNorm)
        {
            if (!DAO.getInstance().changeNorm(grainLevelOfQualityNorm.TypeImp, GrainLevelOfQualityNorm.NameTable,
                grainLevelOfQualityNorm.Raw, grainLevelOfQualityNorm.Norm, GrainLevelOfQualityNorm.TypeOfLevelQualityAttr,
                GrainLevelOfQualityNorm.NormAttr, grainLevelOfQualityNorm.ClassRaw.ToString()))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
