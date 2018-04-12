using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddAnalysQualityRawController
    {
        public bool checkSave(string name)
        {
            return isNotEmpty(name);
        }
        public bool isNotEmpty(string text)
        {
            return text.Replace(" ", "").Length > 0;
        }
        public bool addClick(GeneralLevelOfQuality generalLevelOfQuality)
        {
            if (!DAO.getInstance().addValuesImpurities(GeneralLevelOfQuality.NameTable, 
                TypeGeneralLevelOfQuality.NameAttr,GeneralLevelOfQuality.ValueAttr, generalLevelOfQuality.IdRaw,
                 generalLevelOfQuality.LevelQuality, generalLevelOfQuality.Value))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        public bool addClick(HarmfulLevelOfQuality harmfulLevelOfQuality)
        {
            if (!DAO.getInstance().addValuesImpurities(HarmfulLevelOfQuality.NameTable,
                TypeHarmfulLevelOfQuality.NameAttr, HarmfulLevelOfQuality.ValueAttr, harmfulLevelOfQuality.IdRaw,
                 harmfulLevelOfQuality.LevelQuality, harmfulLevelOfQuality.Value))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        public bool addClick(GrainLevelOfQuality grainLevelOfQuality)
        {
            if (!DAO.getInstance().addValuesImpurities(GrainLevelOfQuality.NameTable,
                TypeGrainLevelOfQuality.NameAttr, GrainLevelOfQuality.ValueAttr, grainLevelOfQuality.IdRaw,
                 grainLevelOfQuality.LevelQuality, grainLevelOfQuality.Value))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        public bool addClick(WeedLevelOfQuality weedLevelOfQuality)
        {
            if (!DAO.getInstance().addValuesImpurities(WeedLevelOfQuality.NameTable,
                TypeWeedLevelOfQuality.NameAttr, WeedLevelOfQuality.ValueAttr, weedLevelOfQuality.IdRaw,
                 weedLevelOfQuality.LevelQuality, weedLevelOfQuality.Value))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool changeClick(GeneralLevelOfQuality generalLevelOfQuality)
        {
            if (!DAO.getInstance().changeQuality(generalLevelOfQuality.IdRaw, GeneralLevelOfQuality.NameTable,
                generalLevelOfQuality.LevelQuality, generalLevelOfQuality.Value, GeneralLevelOfQuality.ValueAttr,
                TypeGeneralLevelOfQuality.NameAttr))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool changeClick(HarmfulLevelOfQuality harmfulLevelOfQuality)
        {
            if (!DAO.getInstance().changeQuality(harmfulLevelOfQuality.IdRaw, HarmfulLevelOfQuality.NameTable,
                harmfulLevelOfQuality.LevelQuality, harmfulLevelOfQuality.Value, HarmfulLevelOfQuality.ValueAttr,
                TypeHarmfulLevelOfQuality.NameAttr))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool changeClick(WeedLevelOfQuality weedLevelOfQuality)
        {
            if (!DAO.getInstance().changeQuality(weedLevelOfQuality.IdRaw, WeedLevelOfQuality.NameTable,
                weedLevelOfQuality.LevelQuality, weedLevelOfQuality.Value, WeedLevelOfQuality.ValueAttr,
                TypeWeedLevelOfQuality.NameAttr))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        public bool changeClick(GrainLevelOfQuality grainLevelOfQuality)
        {
            if (!DAO.getInstance().changeQuality(grainLevelOfQuality.IdRaw, GrainLevelOfQuality.NameTable,
                grainLevelOfQuality.LevelQuality, grainLevelOfQuality.Value, GrainLevelOfQuality.ValueAttr,
                TypeGrainLevelOfQuality.NameAttr))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
    }
}

