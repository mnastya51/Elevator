﻿using Elevator.AddAndEditForms;
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
        public void addButtonClick(GeneralLevelOfQualityNorm generalLevelOfQualityNorm, LinkedList<string> impurities)
        {
            string[] imp = DAO.getInstance().getImpurity(TypeGeneralLevelOfQuality.NameTable, GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr, impurities);
            if (imp.Length > 0)
                new AddNormOfRawForm(generalLevelOfQualityNorm, imp).ShowDialog();
            else MessageBox.Show("У всех показателей качества определена норма!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void addButtonClick(HarmfulLevelOfQualityNorm hurmfulLevelOfQualityNorm, LinkedList<string> impurities)
        {
            string[] imp = DAO.getInstance().getImpurity(TypeHarmfulLevelOfQuality.NameTable, HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr, impurities);
            if(imp.Length > 0)
                new AddNormOfRawForm(hurmfulLevelOfQualityNorm, imp).ShowDialog();
            else  MessageBox.Show("У всех показателей качества определена норма!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void addButtonClick(GrainLevelOfQualityNorm grainLevelOfQualityNorm, LinkedList<string> impurities)
        {
            string[] imp = DAO.getInstance().getImpurity(TypeGrainLevelOfQuality.NameTable, GrainLevelOfQualityNorm.TypeOfLevelQualityAttr, impurities);
            if (imp.Length > 0)
                new AddNormOfRawForm(grainLevelOfQualityNorm, imp).ShowDialog();
            else MessageBox.Show("У всех показателей качества определена норма!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void addButtonClick(WeedLevelOfQualityNorm weedLevelOfQualityNorm, LinkedList<string> impurities)
        {
            string[] imp = DAO.getInstance().getImpurity(TypeWeedLevelOfQuality.NameTable, WeedLevelOfQualityNorm.TypeOfLevelQualityAttr, impurities);
            if (imp.Length > 0)
                new AddNormOfRawForm(weedLevelOfQualityNorm, imp).ShowDialog();
            else MessageBox.Show("У всех показателей качества определена норма!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /*public void changeButtonClick(string valueImp, string valueNorm, string nameTable, string raw, string nameImp, string nameNorm, string numberClass)
        {
            new AddNormOfRawForm(valueImp, valueNorm, nameTable, raw, nameImp, nameNorm, numberClass).ShowDialog();
        }*/

        public void changeButtonClick(GeneralLevelOfQualityNorm generalLevelOfQualityNorm, bool forChange)
        {
            new AddNormOfRawForm(generalLevelOfQualityNorm, forChange).ShowDialog();
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
            DAO.getInstance().deleteNorm(GeneralLevelOfQualityNorm.NameTable, GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr,
                generalLevelOfQualityNorm.TypeImp, generalLevelOfQualityNorm.Raw, generalLevelOfQualityNorm.ClassRaw.ToString());
        }
        public void deleteButtonClick(HarmfulLevelOfQualityNorm hurmfulLevelOfQualityNorm)
        {
            DAO.getInstance().deleteNorm(HarmfulLevelOfQualityNorm.NameTable, HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr,
                hurmfulLevelOfQualityNorm.TypeImp, hurmfulLevelOfQualityNorm.Raw, hurmfulLevelOfQualityNorm.ClassRaw.ToString());
        }
        public void deleteButtonClick(WeedLevelOfQualityNorm weedLevelOfQualityNorm)
        {
            DAO.getInstance().deleteNorm(WeedLevelOfQualityNorm.NameTable, WeedLevelOfQualityNorm.TypeOfLevelQualityAttr,
                weedLevelOfQualityNorm.TypeImp, weedLevelOfQualityNorm.Raw, weedLevelOfQualityNorm.ClassRaw.ToString());
        }
        public void deleteButtonClick(GrainLevelOfQualityNorm grainLevelOfQualityNorm)
        {
            DAO.getInstance().deleteNorm(GrainLevelOfQualityNorm.NameTable, GrainLevelOfQualityNorm.TypeOfLevelQualityAttr,
                grainLevelOfQualityNorm.TypeImp, grainLevelOfQualityNorm.Raw, grainLevelOfQualityNorm.ClassRaw.ToString());
        }
    }
}
