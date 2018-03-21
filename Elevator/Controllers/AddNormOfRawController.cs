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

        public bool addClick(GeneralLevelOfQualityNorm generalLevelOfQualityNorm)
        {
            if (!DAO.getInstance().addNorm(GeneralLevelOfQualityNorm.NameTable, GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr,
                generalLevelOfQualityNorm.TypeImp, GeneralLevelOfQualityNorm.NormAttr, generalLevelOfQualityNorm.Raw,
                 generalLevelOfQualityNorm.Norm, generalLevelOfQualityNorm.ClassRaw))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool addClick(HarmfulLevelOfQualityNorm harmfulLevelOfQualityNorm)
        {
            if (!DAO.getInstance().addNorm(HarmfulLevelOfQualityNorm.NameTable, HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr,
                harmfulLevelOfQualityNorm.TypeImp, HarmfulLevelOfQualityNorm.NormAttr, harmfulLevelOfQualityNorm.Raw,
                 harmfulLevelOfQualityNorm.Norm, harmfulLevelOfQualityNorm.ClassRaw))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool addClick(WeedLevelOfQualityNorm weedLevelOfQualityNorm)
        {
            if (!DAO.getInstance().addNorm(WeedLevelOfQualityNorm.NameTable, WeedLevelOfQualityNorm.TypeOfLevelQualityAttr,
                weedLevelOfQualityNorm.TypeImp, WeedLevelOfQualityNorm.NormAttr, weedLevelOfQualityNorm.Raw,
                 weedLevelOfQualityNorm.Norm, weedLevelOfQualityNorm.ClassRaw))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool addClick(GrainLevelOfQualityNorm grainLevelOfQualityNorm)
        {
            if (!DAO.getInstance().addNorm(GrainLevelOfQualityNorm.NameTable, GrainLevelOfQualityNorm.TypeOfLevelQualityAttr,
                grainLevelOfQualityNorm.TypeImp, GrainLevelOfQualityNorm.NormAttr, grainLevelOfQualityNorm.Raw,
                 grainLevelOfQualityNorm.Norm, grainLevelOfQualityNorm.ClassRaw))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        //здесь
       /* public bool changeClick(GeneralLevelOfQualityNorm generalLevelOfQualityNorm)
        {
            if (!DAO.getInstance().changeNorm(valueImp, nameTable, raw, valueNorm, nameImp, nameNorm, numberClass))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }*/

        public bool changeClick(string valueImp, string nameTable, string raw, string valueNorm, string nameImp, string nameNorm, string numberClass)
        {
            if (!DAO.getInstance().changeNorm(valueImp, nameTable, raw, valueNorm, nameImp, nameNorm, numberClass))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
    }
}
