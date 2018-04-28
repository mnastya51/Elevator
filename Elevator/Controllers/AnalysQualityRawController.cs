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
    class AnalysQualityRawController
    {
        public void addButtonClick(GeneralLevelOfQuality generalLevelOfQuality, string[] change, LinkedList<string> impurities)
        {//TypeHarmfulLevelOfQuality.NameTable, HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr, impurities
            string[] imp = DAO.getInstance().getImpurity(change[0], change[1], impurities);
            if (imp.Length > 0)
                new AddAnalysQualityRawForm(generalLevelOfQuality, imp).ShowDialog();
            else MessageBox.Show("У всех показателей качества определено значение!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void addButtonClick(HarmfulLevelOfQuality harmfulLevelOfQuality, string[] change, LinkedList<string> impurities)
        {
            string[] imp = DAO.getInstance().getImpurity(change[0], change[1], impurities);
            if (imp.Length > 0)
                new AddAnalysQualityRawForm(harmfulLevelOfQuality, imp).ShowDialog();
            else MessageBox.Show("У всех показателей качества определено значение!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void addButtonClick(GrainLevelOfQuality grainLevelOfQuality, string[] change, LinkedList<string> impurities)
        {
            string[] imp = DAO.getInstance().getImpurity(change[0], change[1], impurities);
            if (imp.Length > 0)
                new AddAnalysQualityRawForm(grainLevelOfQuality, imp).ShowDialog();
            else MessageBox.Show("У всех показателей качества определено значение!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void addButtonClick(WeedLevelOfQuality weedLevelOfQuality, string[] change, LinkedList<string> impurities)
        {
            string[] imp = DAO.getInstance().getImpurity(change[0], change[1], impurities);
            if (imp.Length > 0)
                new AddAnalysQualityRawForm(weedLevelOfQuality, imp).ShowDialog();
            else MessageBox.Show("У всех показателей качества определено значение!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void changeButtonClick(GeneralLevelOfQuality generalLevelOfQuality, bool forChange)
        {
            new AddAnalysQualityRawForm(generalLevelOfQuality, forChange).ShowDialog();
        }

        public void changeButtonClick(HarmfulLevelOfQuality hurmfulLevelOfQuality, bool forChange)
        {
            new AddAnalysQualityRawForm(hurmfulLevelOfQuality, forChange).ShowDialog();
        }

        public void changeButtonClick(GrainLevelOfQuality grainLevelOfQuality, bool forChange)
        {
            new AddAnalysQualityRawForm(grainLevelOfQuality, forChange).ShowDialog();
        }

        public void changeButtonClick(WeedLevelOfQuality weedLevelOfQuality, bool forChange)
        {
            new AddAnalysQualityRawForm(weedLevelOfQuality, forChange).ShowDialog();
        }

        public string defineClassClick(GeneralLevelOfQuality generalLevelOfQuality, string raw, string type, 
            string subtype, DataGridView dataGridViewAnalys)
        {
            string numberClass = "";
            string[] classes = DAO.getInstance().getClasses(raw);
            bool flag = true;
            if (classes.Length > 0)
            {
                for (int i = 0; i < classes.Length; i++)
                {
                    LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(generalLevelOfQuality.IdRaw,
                    classes[i], GeneralLevelOfQualityNorm.NormAttr, GeneralLevelOfQualityNorm.NameTable,
                    GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr);
                    FormValue<string, string>[] valueArray = value.ToArray<FormValue<string, string>>();
                    string[] res = fillWithClassForGeneral(dataGridViewAnalys, i, flag, classes, valueArray, generalLevelOfQuality.IdRaw, type);
                    numberClass = res[0];
                    i = Convert.ToInt32(res[1]);
                }
                dataGridViewAnalys.ClearSelection();
                return numberClass;
            }
            else
            {
                LinkedList<FormValue<string, string>> value = DAO.getInstance().defineState(generalLevelOfQuality.IdRaw, type, GeneralLevelOfQualityNorm.NormAttr,
                    GeneralLevelOfQualityNorm.NameTable,
                    GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr);
                FormValue<string, string>[] valueArray = value.ToArray<FormValue<string, string>>();
                for (int i = 0; i < value.Count; i++)
                {
                    try
                    {
                        DataGridViewRow row = dataGridViewAnalys.Rows[i];
                        if (row.Cells[1].Value.ToString() == valueArray[i].getKey())
                        {
                            row.Cells[3].Value = valueArray[i].getValue();
                            bool isMax = DAO.getInstance().isMaximum(generalLevelOfQuality.IdRaw, type, "", row.Cells[1].Value.ToString());
                            if (!isMax)
                            {
                                if (Convert.ToDouble(row.Cells[2].Value) > Convert.ToDouble(row.Cells[3].Value))
                                    dataGridViewAnalys.Rows[i].Cells[2].Style.BackColor = System.Drawing.Color.LightBlue;
                            }
                            else
                            {
                                if (Convert.ToDouble(row.Cells[2].Value) < Convert.ToDouble(row.Cells[3].Value))
                                    dataGridViewAnalys.Rows[i].Cells[2].Style.BackColor = System.Drawing.Color.LightBlue;
                            }
                        }
                    }
                    catch { i++; }
                }
                dataGridViewAnalys.ClearSelection();
                return numberClass;
            }           
        }
        public string defineClassClick(HarmfulLevelOfQuality harmfulLevelOfQuality, string raw, string type, string subtype,
             DataGridView dataGridViewAnalys)
        {
            string numberClass = "";
            string[] classes = DAO.getInstance().getClasses(raw);
            bool flag = true;
            if (classes.Length > 0)
            {
                for (int i = 0; i < classes.Length; i++)
                {
                    LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(harmfulLevelOfQuality.IdRaw,
                    classes[i], HarmfulLevelOfQualityNorm.NormAttr, HarmfulLevelOfQualityNorm.NameTable,
                    HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr);
                    FormValue<string, string>[] valueArray = value.ToArray<FormValue<string, string>>();
                    string[] res = fillWithClass(dataGridViewAnalys, i, flag, classes, valueArray);
                    numberClass = res[0];
                    i = Convert.ToInt32(res[1]);
                }
                dataGridViewAnalys.ClearSelection();
                return numberClass;
            }
            else
            {
                LinkedList<FormValue<string, string>> value = DAO.getInstance().defineState(harmfulLevelOfQuality.IdRaw, type,
                    HarmfulLevelOfQualityNorm.NormAttr,
                    HarmfulLevelOfQualityNorm.NameTable,
                    HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr);
                FormValue<string, string>[] valueArray = value.ToArray<FormValue<string, string>>();
                fillWithoutClass(dataGridViewAnalys, valueArray);
                return numberClass;
            }
        }
        public string defineClassClick(WeedLevelOfQuality weedLevelOfQuality, string raw, string type, string subtype,
            DataGridView dataGridViewAnalys)
        {
            string numberClass = "";
            string[] classes = DAO.getInstance().getClasses(raw);
            bool flag = true;
            if (classes.Length > 0)
            {
                for (int i = 0; i < classes.Length; i++)
                {
                    LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(weedLevelOfQuality.IdRaw,
                    classes[i], WeedLevelOfQualityNorm.NormAttr, WeedLevelOfQualityNorm.NameTable,
                   WeedLevelOfQualityNorm.TypeOfLevelQualityAttr);
                    FormValue<string, string>[] valueArray = value.ToArray<FormValue<string, string>>();
                    string[] res = fillWithClass(dataGridViewAnalys, i, flag, classes, valueArray);
                    numberClass = res[0];
                    i = Convert.ToInt32(res[1]);
                }
                dataGridViewAnalys.ClearSelection();
                return numberClass;
            }
            else
            {
                LinkedList<FormValue<string, string>> value = DAO.getInstance().defineState(weedLevelOfQuality.IdRaw, type,
                    WeedLevelOfQualityNorm.NormAttr,
                    WeedLevelOfQualityNorm.NameTable,
                    WeedLevelOfQualityNorm.TypeOfLevelQualityAttr);
                FormValue<string, string>[] valueArray = value.ToArray<FormValue<string, string>>();
                fillWithoutClass(dataGridViewAnalys, valueArray);
                return numberClass;
            }
        }
        public string defineClassClick(GrainLevelOfQuality grainLevelOfQuality, string raw, string type, string subtype,
            DataGridView dataGridViewAnalys)
        {
            string numberClass = "";
            string[] classes = DAO.getInstance().getClasses(raw);
            bool flag = true;
            if (classes.Length > 0)
            {
                for (int i = 0; i < classes.Length; i++)
                {
                    LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(grainLevelOfQuality.IdRaw,
                    classes[i], GrainLevelOfQualityNorm.NormAttr, GrainLevelOfQualityNorm.NameTable,
                    GrainLevelOfQualityNorm.TypeOfLevelQualityAttr);
                    FormValue<string, string>[] valueArray = value.ToArray<FormValue<string, string>>();
                    string[] res = fillWithClass(dataGridViewAnalys, i, flag, classes, valueArray);
                    numberClass = res[0];
                    i = Convert.ToInt32(res[1]);
                }
                dataGridViewAnalys.ClearSelection();
                return numberClass;
            }
            else
            {
                LinkedList<FormValue<string, string>> value = DAO.getInstance().defineState(grainLevelOfQuality.IdRaw, type,
                    GrainLevelOfQualityNorm.NormAttr,
                    GrainLevelOfQualityNorm.NameTable,
                    GrainLevelOfQualityNorm.TypeOfLevelQualityAttr);
                FormValue<string, string>[] valueArray = value.ToArray<FormValue<string, string>>();
                fillWithoutClass(dataGridViewAnalys, valueArray);
                return numberClass;
            }
        }

        public void fillWithoutClass(DataGridView dataGridViewAnalys, FormValue<string, string>[] valueArray)
        {
            for (int i = 0; i < valueArray.Length; i++)
            {
                try
                {
                    DataGridViewRow row = dataGridViewAnalys.Rows[i];
                    if (row.Cells[1].Value.ToString() == valueArray[i].getKey())
                    {
                        row.Cells[3].Value = valueArray[i].getValue();
                        if (Convert.ToDouble(row.Cells[2].Value) > Convert.ToDouble(row.Cells[3].Value))
                            dataGridViewAnalys.Rows[i].Cells[2].Style.BackColor = System.Drawing.Color.LightBlue;
                    }
                }
                catch { i++; }
            }
            dataGridViewAnalys.ClearSelection();
        }

        public string[] fillWithClass(DataGridView dataGridViewAnalys, int i, bool flag, string[] classes, FormValue<string, string>[] valueArray)
        {
            string[] res = new string [2];
            for (int j = 0; j < valueArray.Length; j++)
            {
                try
                {
                    DataGridViewRow row = dataGridViewAnalys.Rows[j];
                    if (row.Cells[1].Value.ToString() == valueArray[j].getKey())
                    {
                        row.Cells[3].Value = valueArray[j].getValue();
                        if (Convert.ToDouble(row.Cells[2].Value) <= Convert.ToDouble(valueArray[j].getValue()))
                        {
                            dataGridViewAnalys.Rows[j].Cells[2].Style.BackColor = System.Drawing.Color.White;
                            if (flag && j == valueArray.Length - 1)
                            {
                                res[0] = classes[i];
                                res[1] = classes.Length.ToString();                               
                            }
                        }
                        else
                        {
                            flag = false;
                            if (i == valueArray.Length - 1)
                                dataGridViewAnalys.Rows[j].Cells[2].Style.BackColor = System.Drawing.Color.LightBlue;
                            j = valueArray.Length;
                            res[0] = classes[i];
                            res[1] = i.ToString();
                        }
                    }
                }
                catch { j++; }
            }
            return res;
        }
        public string[] fillWithClassForGeneral(DataGridView dataGridViewAnalys, int i, bool flag, 
            string[] classes, FormValue<string, string>[] valueArray, string idRaw, string type)
        {
            string[] res = new string[2];
            for (int j = 0; j < valueArray.Length; j++)
            {
                try
                {
                    DataGridViewRow row = dataGridViewAnalys.Rows[j];
                    if (row.Cells[1].Value.ToString() == valueArray[j].getKey())
                    {
                        row.Cells[3].Value = valueArray[j].getValue();
                        bool isMax = DAO.getInstance().isMaximum(idRaw, type, classes[i], row.Cells[1].Value.ToString());
                        if (isMax)
                        {
                            if (Convert.ToDouble(row.Cells[2].Value) > Convert.ToDouble(valueArray[j].getValue()))
                            {
                                dataGridViewAnalys.Rows[j].Cells[2].Style.BackColor = System.Drawing.Color.White;
                                if (flag && j == valueArray.Length - 1)
                                {
                                    res[0] = classes[i];
                                    res[1] = classes.Length.ToString();
                                }
                            }
                            else
                            {
                                flag = false;
                                if (i == valueArray.Length)
                                    dataGridViewAnalys.Rows[j].Cells[2].Style.BackColor = System.Drawing.Color.LightBlue;
                                j = valueArray.Length;
                                res[0] = classes[i];
                                res[1] = i.ToString();
                            }
                        }
                        else
                        {
                            if (Convert.ToDouble(row.Cells[2].Value) <= Convert.ToDouble(valueArray[j].getValue()))
                            {
                                dataGridViewAnalys.Rows[j].Cells[2].Style.BackColor = System.Drawing.Color.White;
                                if (flag && j == valueArray.Length - 1)
                                {
                                    res[0] = classes[i];
                                    res[1] = classes.Length.ToString();
                                }
                            }
                            else
                            {
                                flag = false;
                                if (i == valueArray.Length - 1)
                                    dataGridViewAnalys.Rows[j].Cells[2].Style.BackColor = System.Drawing.Color.LightBlue;
                                j = valueArray.Length;
                                res[0] = classes[i];
                                res[1] = i.ToString();
                            }
                        }                                              
                    }
                }
                catch { j++; }
            }
            return res;
        }
    }
}
