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
                    if (valueArray.Length != 0)
                    {
                        string[] res = fillWithClassForGeneral(dataGridViewAnalys, i, flag, classes,
                            valueArray, generalLevelOfQuality.IdRaw, type);
                        numberClass = res[0];
                        i = Convert.ToInt32(res[1]);
                    }
                    else
                    {
                        for (int j = 0; j < dataGridViewAnalys.Rows.Count; j++)
                            dataGridViewAnalys.Rows[j].Cells[3].Value = "";
                        MessageBox.Show("Установите нормы для всех классов данного сырья!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
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
                if (valueArray.Length != 0)
                {
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
                }
                else
                {
                    for (int j = 0; j < dataGridViewAnalys.Rows.Count; j++)
                        dataGridViewAnalys.Rows[j].Cells[3].Value = "";
                    MessageBox.Show("Установите нормы для всех классов данного сырья!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (valueArray.Length != 0) {
                        string[] res = fillWithClass(dataGridViewAnalys, i, flag, classes, valueArray,
                            harmfulLevelOfQuality.IdRaw, "hurmful", type);
                        numberClass = res[0];
                        i = Convert.ToInt32(res[1]);
                    }
                    else
                    {
                        for (int j = 0; j < dataGridViewAnalys.Rows.Count; j++)
                            dataGridViewAnalys.Rows[j].Cells[3].Value = "";
                        MessageBox.Show("Установите нормы для всех классов данного сырья!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
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
                if(valueArray.Length != 0)
                    fillWithoutClass(dataGridViewAnalys, valueArray);
                else
                    {
                    for (int j = 0; j < dataGridViewAnalys.Rows.Count; j++)
                        dataGridViewAnalys.Rows[j].Cells[3].Value = "";
                    MessageBox.Show("Установите нормы для всех классов данного сырья!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                    if (valueArray.Length != 0)
                    {
                        string[] res = fillWithClass(dataGridViewAnalys, i, flag, classes, valueArray,
                            weedLevelOfQuality.IdRaw, "weed", type);
                        numberClass = res[0];
                        i = Convert.ToInt32(res[1]);
                    }
                    else
                    {
                        for (int j = 0; j < dataGridViewAnalys.Rows.Count; j++)
                            dataGridViewAnalys.Rows[j].Cells[3].Value = "";
                        MessageBox.Show("Установите нормы для всех классов данного сырья!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
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
                if (valueArray.Length != 0)
                    fillWithoutClass(dataGridViewAnalys, valueArray);
                else
                    {
                    for (int j = 0; j < dataGridViewAnalys.Rows.Count; j++)
                        dataGridViewAnalys.Rows[j].Cells[3].Value = "";
                    MessageBox.Show("Установите нормы для всех классов данного сырья!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return numberClass;
            }
        }
        public string defineClassClick(GrainLevelOfQuality grainLevelOfQuality, string raw,
            string type, string subtype, DataGridView dataGridViewAnalys)
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
                    if (valueArray.Length != 0)
                    {
                        string[] res = fillWithClass(dataGridViewAnalys, i, flag, classes, valueArray,
                        grainLevelOfQuality.IdRaw, "grain", type);
                        numberClass = res[0];
                        i = Convert.ToInt32(res[1]);
                    }
                    else
                    {
                        for (int j = 0; j < dataGridViewAnalys.Rows.Count; j++)
                            dataGridViewAnalys.Rows[j].Cells[3].Value = "";
                        MessageBox.Show("Установите нормы для всех классов данного сырья!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
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
                if (valueArray.Length != 0)
                    fillWithoutClass(dataGridViewAnalys, valueArray);
                 else
                    {
                    for (int j = 0; j < dataGridViewAnalys.Rows.Count; j++)
                        dataGridViewAnalys.Rows[j].Cells[3].Value = "";
                    MessageBox.Show("Установите нормы для всех классов данного сырья!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return numberClass;
            }
        }

        private void fillWithoutClass(DataGridView dataGridViewAnalys,
            FormValue<string, string>[] valueArray)
        {
            for (int i = 0; i < valueArray.Length; i++)
            {
                try
                {
                    DataGridViewRow row = dataGridViewAnalys.Rows[i];
                    if (row.Cells[1].Value.ToString() == valueArray[i].getKey())
                    {
                        row.Cells[3].Value = valueArray[i].getValue();
                        if (Convert.ToDouble(row.Cells[2].Value) > Convert.ToDouble(valueArray[i].getValue()))
                        {
                            dataGridViewAnalys.Rows[i].Cells[2].Style.BackColor = System.Drawing.Color.LightBlue;
                        }
                    }
                }
                catch { i++; }
            }
            dataGridViewAnalys.ClearSelection();
        }

        public string[] fillWithClass(DataGridView dataGridViewAnalys, int i, bool flag,
            string[] classes, FormValue<string, string>[] valueArray, string idRaw, 
            string groupLevel, string type)
        {
            string[] res = new string[2];
            string idClass = valueArray[0].getValue();
            int count;
            if (dataGridViewAnalys.Rows.Count > valueArray.Length - 1)
                count = valueArray.Length - 1;
            else count = dataGridViewAnalys.Rows.Count;
            for (int j = 1; j < valueArray.Length; j++)
            {
                try
                {
                    DataGridViewRow row = dataGridViewAnalys.Rows[j - 1];
                    if (row.Cells[1].Value.ToString() == valueArray[j].getKey())
                    {
                        if (Convert.ToDouble(row.Cells[2].Value) <= Convert.ToDouble(valueArray[j].getValue()))
                        {
                            //row.Cells[3].Value = valueArray[j].getValue();
                           // dataGridViewAnalys.Rows[j - 1].Cells[2].Style.BackColor = System.Drawing.Color.White;
                            if (flag && j == count)
                            {
                                switch (groupLevel)
                                {
                                    case "hurmful":
                                        {
                                            res = findClassGrain(i, classes, idRaw, dataGridViewAnalys);
                                            if (res[0] != "" && res[0] != null)
                                                res = findClassWeed(Convert.ToInt16(res[2]), classes, idRaw, dataGridViewAnalys);
                                            else break;
                                            if (res[0] != "" && res[0] != null)
                                                res = findClassGeneral(Convert.ToInt16(res[2]), classes, idRaw, dataGridViewAnalys, type);
                                            break;
                                        }
                                    case "weed":
                                        {
                                            res = findClassGrain(i, classes, idRaw, dataGridViewAnalys);
                                            if (res[0] != "" && res[0] != null)
                                                res = findClassHurmful(Convert.ToInt16(res[2]), classes, idRaw, dataGridViewAnalys);
                                            else break;
                                            if (res[0] != "" && res[0] != null)
                                                res = findClassGeneral(Convert.ToInt16(res[2]), classes, idRaw, dataGridViewAnalys, type);
                                            break;
                                        }
                                    case "grain":
                                        {
                                            res = findClassHurmful(i, classes, idRaw, dataGridViewAnalys);
                                            if (res[0] != "" && res[0] != null)
                                                res = findClassWeed(Convert.ToInt16(res[2]), classes, idRaw, dataGridViewAnalys);
                                            else break;
                                            if (res[0] != "" && res[0] != null)
                                                res = findClassGeneral(Convert.ToInt16(res[2]), classes, idRaw, dataGridViewAnalys, type);
                                            break;
                                        }
                                }
                                if (res[0] != "")
                                {                          
                                    switch (groupLevel)
                                    {
                                        case "hurmful":
                                            {
                                                LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(idRaw,
                                                    res[0], HarmfulLevelOfQualityNorm.NormAttr, HarmfulLevelOfQualityNorm.NameTable,
                                                     HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr);
                                                FormValue<string, string>[] valueResult = value.ToArray<FormValue<string, string>>();
                                                DAO.getInstance().updateNote("Storage", new FormValue<string, string>("id_raw", idRaw), new FormValue<string, string>("id_class", valueResult[0].getValue()));
                                                getValue(valueResult, dataGridViewAnalys);
                                                break;
                                            }
                                        case "weed":
                                            {
                                                LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(idRaw,
                                                     res[0], WeedLevelOfQualityNorm.NormAttr, WeedLevelOfQualityNorm.NameTable,
                                                      WeedLevelOfQualityNorm.TypeOfLevelQualityAttr);
                                                FormValue<string, string>[] valueResult = value.ToArray<FormValue<string, string>>();
                                                DAO.getInstance().updateNote("Storage", new FormValue<string, string>("id_raw", idRaw), new FormValue<string, string>("id_class", valueResult[0].getValue()));
                                                getValue(valueResult, dataGridViewAnalys);
                                                break;
                                            }
                                        case "grain":
                                            {
                                                LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(idRaw,
                                                     res[0], GrainLevelOfQualityNorm.NormAttr, GrainLevelOfQualityNorm.NameTable,
                                                      GrainLevelOfQualityNorm.TypeOfLevelQualityAttr);
                                                FormValue<string, string>[] valueResult = value.ToArray<FormValue<string, string>>();
                                                DAO.getInstance().updateNote("Storage", new FormValue<string, string>("id_raw", idRaw), new FormValue<string, string>("id_class", valueResult[0].getValue()));
                                                getValue(valueResult, dataGridViewAnalys);
                                                break;
                                            }                                        
                                    }
                                }
                                else
                                {
                                    for (int k = 1; k < valueArray.Length; k++)
                                    {
                                        row = dataGridViewAnalys.Rows[k - 1];
                                        if (row.Cells[1].Value.ToString() == valueArray[k].getKey())
                                        {
                                            row.Cells[3].Value = valueArray[k].getValue();
                                            dataGridViewAnalys.Rows[k - 1].Cells[2].Style.BackColor = System.Drawing.Color.White;
                                        }
                                    }
                                    DAO.getInstance().updateClassToNullForStorage(idRaw);
                                }
                                res[1] = classes.Length.ToString();
                            }
                        }
                        else
                        {
                            flag = false;
                            row.Cells[3].Value = valueArray[j].getValue();
                            if (i == classes.Length - 1)
                                dataGridViewAnalys.Rows[j - 1].Cells[2].Style.BackColor = System.Drawing.Color.LightBlue;
                            j = valueArray.Length;
                            res[0] = "";
                            DAO.getInstance().updateClassToNullForStorage(idRaw);
                            res[1] = i.ToString();
                        }
                    }
                    else { j++; }
                }
                catch { j++; }
            }
            return res;
        }
        private string[] fillWithClassForGeneral(DataGridView dataGridViewAnalys, int i, bool flag,
            string[] classes, FormValue<string, string>[] valueArray, string idRaw, string type)
        {
            string[] res = new string[2];
            string idClass = valueArray[0].getValue();
            int count;
            if (dataGridViewAnalys.Rows.Count > valueArray.Length-1)
                count = valueArray.Length-1;
            else count = dataGridViewAnalys.Rows.Count;
            for (int j = 1; j < valueArray.Length; j++)
            {
                try
                {
                    DataGridViewRow row = dataGridViewAnalys.Rows[j - 1];
                    if (row.Cells[1].Value.ToString() == valueArray[j].getKey())
                    {
                        bool isMax = DAO.getInstance().isMaximum(idRaw, type, classes[i], row.Cells[1].Value.ToString());
                        if (isMax)
                        {
                            if (Convert.ToDouble(row.Cells[2].Value) >= Convert.ToDouble(valueArray[j].getValue()))
                            {
                                row.Cells[3].Value = valueArray[j].getValue();
                                dataGridViewAnalys.Rows[j - 1].Cells[2].Style.BackColor = System.Drawing.Color.White;
                                if (flag && j == count)
                                {////////////////////////////////////////////////
                                    res = findClassGrain(i, classes, idRaw, dataGridViewAnalys);
                                    if (res[0] != "" && res[0] != null)
                                        res = findClassWeed(Convert.ToInt16(res[2]), classes, idRaw, dataGridViewAnalys);
                                    if (res[0] != "" && res[0] != null)
                                        res = findClassHurmful(Convert.ToInt16(res[2]), classes, idRaw, dataGridViewAnalys);
                                    if (res[0] != "" && res[0] != null)
                                    {
                                        LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(idRaw,
                                            res[0], GeneralLevelOfQualityNorm.NormAttr, GeneralLevelOfQualityNorm.NameTable,
                                             GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr);
                                        FormValue<string, string>[] valueResult = value.ToArray<FormValue<string, string>>();
                                        DAO.getInstance().updateNote("Storage", new FormValue<string, string>("id_raw", idRaw), new FormValue<string, string>("id_class", valueResult[0].getValue()));
                                        getValue(valueResult, dataGridViewAnalys);
                                        break;
                                    }
                                    else
                                    {
                                        for (int k = 1; k < valueArray.Length; k++)
                                        {
                                            row = dataGridViewAnalys.Rows[k - 1];
                                            if (row.Cells[1].Value.ToString() == valueArray[k].getKey())
                                            {
                                                row.Cells[3].Value = valueArray[k].getValue();
                                                dataGridViewAnalys.Rows[k - 1].Cells[2].Style.BackColor = System.Drawing.Color.White;
                                            }
                                        }
                                        DAO.getInstance().updateClassToNullForStorage(idRaw);
                                    }
                                    res[1] = classes.Length.ToString();
                                }
                            }
                            else
                            {
                                flag = false;
                                row.Cells[3].Value = valueArray[j].getValue();
                                if (i == classes.Length - 1)
                                {
                                    dataGridViewAnalys.Rows[j - 1].Cells[2].Style.BackColor = System.Drawing.Color.LightBlue;
                                    DAO.getInstance().updateClassToNullForStorage(idRaw);
                                }
                                j = valueArray.Length;
                                res[0] = "";
                                //DAO.getInstance().updateClassToNullForStorage(idRaw);
                                res[1] = i.ToString();
                            }
                        }
                        else
                        {
                            if (Convert.ToDouble(row.Cells[2].Value) <= Convert.ToDouble(valueArray[j].getValue()))
                            {
                                row.Cells[3].Value = valueArray[j].getValue();
                                dataGridViewAnalys.Rows[j - 1].Cells[2].Style.BackColor = System.Drawing.Color.White;
                                if (flag && j == count)
                                {
                                    res = findClassGrain(i, classes, idRaw, dataGridViewAnalys);
                                    if (res[0] != "" && res[0] != null)
                                        res = findClassWeed(Convert.ToInt16(res[2]), classes, idRaw, dataGridViewAnalys);
                                    if (res[0] != "" && res[0] != null)
                                        res = findClassHurmful(Convert.ToInt16(res[2]), classes, idRaw, dataGridViewAnalys);
                                    if (res[0] != "" && res[0] != null)
                                    {
                                        LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(idRaw,
                                            res[0], GeneralLevelOfQualityNorm.NormAttr, GeneralLevelOfQualityNorm.NameTable,
                                             GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr);
                                        FormValue<string, string>[] valueResult = value.ToArray<FormValue<string, string>>();
                                        DAO.getInstance().updateNote("Storage", new FormValue<string, string>("id_raw", idRaw), new FormValue<string, string>("id_class", valueResult[0].getValue()));
                                        getValue(valueResult, dataGridViewAnalys);
                                        break;
                                    }
                                    else
                                    {
                                        for (int k = 1; k < valueArray.Length; k++)
                                        {
                                            row = dataGridViewAnalys.Rows[k - 1];
                                            if (row.Cells[1].Value.ToString() == valueArray[k].getKey())
                                            {
                                                row.Cells[3].Value = valueArray[k].getValue();
                                                dataGridViewAnalys.Rows[k - 1].Cells[2].Style.BackColor = System.Drawing.Color.White;
                                            }
                                        }
                                        DAO.getInstance().updateClassToNullForStorage(idRaw);
                                    }
                                    res[1] = classes.Length.ToString();
                                }
                            }
                            else
                            {
                                flag = false;
                                row.Cells[3].Value = valueArray[j].getValue();
                                if (i == classes.Length - 1)
                                    dataGridViewAnalys.Rows[j - 1].Cells[2].Style.BackColor = System.Drawing.Color.LightBlue;
                                j = valueArray.Length;
                                res[0] = "";
                                DAO.getInstance().updateClassToNullForStorage(idRaw);
                                res[1] = i.ToString();
                            }
                        }
                    }
                    else { j++; }
                }
                catch { j++; }
            }
            return res;
        }

        private string[] findClassGrain(int c, string[] classes, string idRaw, DataGridView dataGridViewAnalys)
        {
            string[] res = new string[2];
            for (int i = c; i < classes.Length; i++)
            {
                LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(idRaw,
                    classes[i], GrainLevelOfQualityNorm.NormAttr, GrainLevelOfQualityNorm.NameTable,
                    GrainLevelOfQualityNorm.TypeOfLevelQualityAttr);
                FormValue<string, string>[] valueArray = value.ToArray<FormValue<string, string>>();

               
                LinkedList<FormValue<string, string>> values = DAO.getInstance().selectAnalysQualityForDefineClass(TypeGrainLevelOfQuality.NameTable,
                    TypeGrainLevelOfQuality.NameAttr, GrainLevelOfQuality.NameTable,
                    GrainLevelOfQuality.ValueAttr, idRaw);
                FormValue<string, string>[] valueRes = values.ToArray<FormValue<string, string>>();
                if (valueArray.Length != 0)
                {
                    res = find(classes, valueRes, i, idRaw, dataGridViewAnalys, valueArray);
                    i = Convert.ToInt16(res[1]);
                }
                else
                {
                    for (int j = 0; j < dataGridViewAnalys.Rows.Count; j++)
                        dataGridViewAnalys.Rows[j].Cells[3].Value = "";
                    MessageBox.Show("Установите нормы для всех классов данного сырья!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }                
            }
            return res;
        }

        private string[] findClassWeed(int c, string[] classes, string idRaw, DataGridView dataGridViewAnalys)
        {
            string[] res = new string[3];
            for (int i = c; i < classes.Length; i++)
            {
                LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(idRaw,
                    classes[i], WeedLevelOfQualityNorm.NormAttr, WeedLevelOfQualityNorm.NameTable,
                   WeedLevelOfQualityNorm.TypeOfLevelQualityAttr);
                FormValue<string, string>[] valueArray = value.ToArray<FormValue<string, string>>();
             
               
                LinkedList<FormValue<string, string>> values = DAO.getInstance().selectAnalysQualityForDefineClass(TypeWeedLevelOfQuality.NameTable,
                    TypeWeedLevelOfQuality.NameAttr, WeedLevelOfQuality.NameTable,
                    WeedLevelOfQuality.ValueAttr, idRaw);
                FormValue<string, string>[] valueRes = values.ToArray<FormValue<string, string>>();
                if (valueArray.Length != 0)
                {
                    res = find(classes, valueRes, i, idRaw, dataGridViewAnalys, valueArray);
                    i = Convert.ToInt16(res[1]);
                }
                else
                {
                    for (int j = 0; j < dataGridViewAnalys.Rows.Count; j++)
                        dataGridViewAnalys.Rows[j].Cells[3].Value = "";
                    MessageBox.Show("Установите нормы для всех классов данного сырья!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
            return res;
        }

        private string[] findClassHurmful(int c, string[] classes, string idRaw, DataGridView dataGridViewAnalys)
        {
            string[] res = new string[2];
            for (int i = c; i < classes.Length; i++)
            {
                LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(idRaw,
                    classes[i], HarmfulLevelOfQualityNorm.NormAttr, HarmfulLevelOfQualityNorm.NameTable,
                    HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr);
                FormValue<string, string>[] valueArray = value.ToArray<FormValue<string, string>>();


                LinkedList<FormValue<string, string>> values = DAO.getInstance().selectAnalysQualityForDefineClass(TypeHarmfulLevelOfQuality.NameTable,
                    TypeHarmfulLevelOfQuality.NameAttr, HarmfulLevelOfQuality.NameTable,
                    HarmfulLevelOfQuality.ValueAttr, idRaw);
                FormValue<string, string>[] valueRes = values.ToArray<FormValue<string, string>>();
                if (valueArray.Length != 0)
                {
                    res = find(classes, valueRes, i, idRaw, dataGridViewAnalys, valueArray);
                    i = Convert.ToInt16(res[1]);
                }
                else
                {
                    for (int j = 0; j < dataGridViewAnalys.Rows.Count; j++)
                        dataGridViewAnalys.Rows[j].Cells[3].Value = "";
                    MessageBox.Show("Установите нормы для всех классов данного сырья!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
            return res;
        }

        private string[] findClassGeneral(int c, string[] classes, string idRaw, DataGridView dataGridViewAnalys, string type)
        {
            string[] res = new string[3];
            for (int i = c; i < classes.Length; i++)
            {
                LinkedList<FormValue<string, string>> value = DAO.getInstance().defineStateForClass(idRaw,
                classes[i], GeneralLevelOfQualityNorm.NormAttr, GeneralLevelOfQualityNorm.NameTable,
                GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr);
                FormValue<string, string>[] valueArray = value.ToArray<FormValue<string, string>>();

                LinkedList<FormValue<string, string>> values = DAO.getInstance().selectAnalysQualityForDefineClass(TypeGeneralLevelOfQuality.NameTable,
                    TypeGeneralLevelOfQuality.NameAttr, GeneralLevelOfQuality.NameTable,
                   GeneralLevelOfQuality.ValueAttr, idRaw);
                FormValue<string, string>[] valueRes = values.ToArray<FormValue<string, string>>();
                if (valueArray.Length != 0)
                {
                    res = findGeneral(classes, valueRes, i, idRaw, dataGridViewAnalys, valueArray, type);
                    i = Convert.ToInt16(res[1]);
                }
                else
                {
                    for (int j = 0; j < dataGridViewAnalys.Rows.Count; j++)
                        dataGridViewAnalys.Rows[j].Cells[3].Value = "";
                    MessageBox.Show("Установите нормы для всех классов данного сырья!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }            
            return res;
        }

        private string[] find(string[] classes, FormValue<string, string>[] valuesRes, int i, string idRaw, DataGridView dataGridViewAnalys, FormValue<string, string>[] valueArray)
        {
            string[] res = new string[3];
            bool flag = true;
            string idClass = valueArray[0].getValue();
            int count = 0;
            if (valuesRes.Length > valueArray.Length-1)
                count = valueArray.Length-1;
            else count = valuesRes.Length;
            if (valuesRes.Length != 0 && valueArray.Length != 0)
            {
                for (int j = 1; j <= count; j++)
                {
                    try
                    {
                        if (valuesRes[j - 1].getKey() == valueArray[j].getKey())
                        {
                            double c = Convert.ToDouble(valueArray[j].getValue());
                            if (Convert.ToDouble(valuesRes[j - 1].getValue()) <= Convert.ToDouble(valueArray[j].getValue()))
                            {
                                if (flag && j == count)
                                {
                                    res[0] = classes[i];
                                    res[1] = classes.Length.ToString();
                                    res[2] = i.ToString();
                                }
                            }
                            else
                            {
                                flag = false;
                                j = count;
                                res[0] = "";
                                res[1] = i.ToString();
                            }
                        }
                    }
                    catch { j++; }
                }
            }
            else
            {
                res[0] = classes[i];
                res[1] = classes.Length.ToString();
                res[2] = i.ToString();
            }
            return res;
        }
        private string[] findGeneral(string[] classes, FormValue<string, string>[] valuesRes, int i,
            string idRaw, DataGridView dataGridViewAnalys, FormValue<string, string>[] valueArray, 
            string type)
        {
            string[] res = new string[3];
            bool flag = true;
            string idClass = valueArray[0].getValue();
            int count;
            if (valuesRes.Length > valueArray.Length-1)
                count = valueArray.Length-1;
            else count = valuesRes.Length;
            if (valuesRes.Length != 0 && valueArray.Length != 0)
            {
                for (int j = 1; j <= count; j++)
                {
                    try
                    {
                        if (valuesRes[j - 1].getKey() == valueArray[j].getKey())
                        {
                            bool isMax = DAO.getInstance().isMaximum(idRaw, type, classes[i], valuesRes[j - 1].getKey());
                            if (isMax)
                            {
                                if (Convert.ToDouble(valuesRes[j - 1].getValue()) >= Convert.ToDouble(valueArray[j].getValue()))
                                {
                                    if (flag && j == count)
                                    {
                                        res[0] = classes[i];
                                        res[1] = classes.Length.ToString();
                                        res[2] = i.ToString();
                                    }
                                }
                                else
                                {
                                    flag = false;
                                    j = count;
                                    res[0] = "";
                                    res[1] = i.ToString();
                                }
                            }
                            else
                            {
                                if (Convert.ToDouble(valuesRes[j - 1].getValue()) <= Convert.ToDouble(valueArray[j].getValue()))
                                {
                                    if (flag && j == count)
                                    {
                                        res[0] = classes[i];
                                        res[1] = classes.Length.ToString();
                                        res[2] = i.ToString();
                                    }
                                }
                                else
                                {
                                    flag = false;
                                    j = count;
                                    res[0] = "";
                                    res[1] = i.ToString();
                                }
                            }
                        }
                    }
                    catch { j++; }
                }
            }
            else
            {
                res[0] = classes[i];
                res[1] = classes.Length.ToString();
                res[2] = i.ToString();
            }
            return res;
        }
        private void getValue(FormValue<string, string>[] valueResult, DataGridView dataGridViewAnalys)
        {
            for (int j = 1; j < valueResult.Length; j++)
            {
                DataGridViewRow row = dataGridViewAnalys.Rows[j-1];
                if (row.Cells[1].Value.ToString() == valueResult[j].getKey())
                {
                    row.Cells[3].Value = valueResult[j].getValue();
                    dataGridViewAnalys.Rows[j - 1].Cells[2].Style.BackColor = System.Drawing.Color.White;
                }
            }           
        }
    }
}
