using Elevator.AddAndEditForms;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class NormOfRawController
    {
        /*public void addButtonClick(string nameTable, string nameImp,  LinkedList<string> impurities, string norm, string raw, string nameTableNorm, string numberClass)
        {
            new AddNormOfRawForm(nameTable, nameImp,  impurities, norm, raw, nameTableNorm, numberClass).ShowDialog();
        }*/
        public void addButtonClick(GeneralLevelOfQualityNorm generalLevelOfQualityNorm, LinkedList<string> impurities, string type, string subtype)
        {
            string[] imp = DAO.getInstance().getImpurity(TypeGeneralLevelOfQuality.NameTable, GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr, impurities);
            if (imp.Length > 0)
                new AddNormOfGeneralLevelForm(generalLevelOfQualityNorm, imp, type, subtype).ShowDialog();
            else MessageBox.Show("У всех показателей качества определена норма!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void addButtonClick(HarmfulLevelOfQualityNorm hurmfulLevelOfQualityNorm, LinkedList<string> impurities, string type, string subtype)
        {
            string[] imp = DAO.getInstance().getImpurity(TypeHarmfulLevelOfQuality.NameTable, HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr, impurities);
            if(imp.Length > 0)
                new AddNormOfRawForm(hurmfulLevelOfQualityNorm, imp, type, subtype).ShowDialog();
            else  MessageBox.Show("У всех показателей качества определена норма!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void addButtonClick(GrainLevelOfQualityNorm grainLevelOfQualityNorm, LinkedList<string> impurities, string type, string subtype)
        {
            string[] imp = DAO.getInstance().getImpurity(TypeGrainLevelOfQuality.NameTable, GrainLevelOfQualityNorm.TypeOfLevelQualityAttr, impurities);
            if (imp.Length > 0)
                new AddNormOfRawForm(grainLevelOfQualityNorm, imp, type, subtype).ShowDialog();
            else MessageBox.Show("У всех показателей качества определена норма!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void addButtonClick(WeedLevelOfQualityNorm weedLevelOfQualityNorm, LinkedList<string> impurities, string type, string subtype)
        {
            string[] imp = DAO.getInstance().getImpurity(TypeWeedLevelOfQuality.NameTable, WeedLevelOfQualityNorm.TypeOfLevelQualityAttr, impurities);
            if (imp.Length > 0)
                new AddNormOfRawForm(weedLevelOfQualityNorm, imp, type, subtype).ShowDialog();
            else MessageBox.Show("У всех показателей качества определена норма!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /*public void changeButtonClick(string valueImp, string valueNorm, string nameTable, string raw, string nameImp, string nameNorm, string numberClass)
        {
            new AddNormOfRawForm(valueImp, valueNorm, nameTable, raw, nameImp, nameNorm, numberClass).ShowDialog();
        }*/

        public void changeButtonClick(GeneralLevelOfQualityNorm generalLevelOfQualityNorm, bool forChange)
        {
            new AddNormOfGeneralLevelForm(generalLevelOfQualityNorm, forChange).ShowDialog();
        }

        public void changeButtonClick(HarmfulLevelOfQualityNorm hurmfulLevelOfQualityNorm, bool forChange)
        {
            new AddNormOfRawForm(hurmfulLevelOfQualityNorm, forChange).ShowDialog();
        }

        public void changeButtonClick(GrainLevelOfQualityNorm grainLevelOfQualityNorm, bool forChange)
        {
            new AddNormOfRawForm(grainLevelOfQualityNorm, forChange).ShowDialog();
        }

        public void changeButtonClick(WeedLevelOfQualityNorm weedLevelOfQualityNorm, bool forChange)
        {
            new AddNormOfRawForm(weedLevelOfQualityNorm, forChange).ShowDialog();
        }

        /*public void deleteButtonClick(string nameTable, string nameImp, string valueImp, string raw, string numberClass)
        {
            DAO.getInstance().deleteNorm(nameTable, nameImp, valueImp, raw, numberClass);
        } */
        public void deleteButtonClick(GeneralLevelOfQualityNorm generalLevelOfQualityNorm)
        {
            DAO.getInstance().deleteNorm(GeneralLevelOfQualityNorm.NameTable, GeneralLevelOfQualityNorm.IdAttr,
                generalLevelOfQualityNorm.Id);
        }
        public void deleteButtonClick(HarmfulLevelOfQualityNorm hurmfulLevelOfQualityNorm)
        {
            DAO.getInstance().deleteNorm(HarmfulLevelOfQualityNorm.NameTable, HarmfulLevelOfQualityNorm.IdAttr,
                hurmfulLevelOfQualityNorm.Id);
        }
        public void deleteButtonClick(WeedLevelOfQualityNorm weedLevelOfQualityNorm)
        {
            DAO.getInstance().deleteNorm(WeedLevelOfQualityNorm.NameTable, WeedLevelOfQualityNorm.IdAttr,
                weedLevelOfQualityNorm.Id);
        }
        public void deleteButtonClick(GrainLevelOfQualityNorm grainLevelOfQualityNorm)
        {
            DAO.getInstance().deleteNorm(GrainLevelOfQualityNorm.NameTable, GrainLevelOfQualityNorm.IdAttr,
                grainLevelOfQualityNorm.Id);
        }
    }
}
