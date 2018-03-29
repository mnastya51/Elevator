using Elevator.Controllers;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Forms
{
    public partial class AnalysQualityRawForm : Form
    {
        private AnalysQualityRawController controller;
        public AnalysQualityRawForm()
        {
            InitializeComponent();
            controller = new AnalysQualityRawController();
            dataGridViewRaw.CellClick += dataGridViewRaw_CellClick;
            select();
        }
        private void select()
        {
            dataGridViewRaw.Rows.Clear();
            DAO.getInstance().selectRaw(dataGridViewRaw);
            dataGridViewRaw.ClearSelection();
        }

        private void dataGridViewRaw_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            groupBox3.Enabled = true;           
        }

        private string[] changeComboBox(string nameTable)
        {
            if (nameTable == "Общие показатели")
                return new string[] { GeneralLevelOfQualityNorm.NameTable, GeneralLevelOfQualityNorm.NormAttr, GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr };
            else if (nameTable == "Вредные примеси")
                return new string[] { HarmfulLevelOfQualityNorm.NameTable, HarmfulLevelOfQualityNorm.NormAttr, HarmfulLevelOfQualityNorm.TypeOfLevelQualityAttr };
            else if (nameTable == "Зерновые примеси")
                return new string[] { GrainLevelOfQualityNorm.NameTable, GrainLevelOfQualityNorm.NormAttr, GrainLevelOfQualityNorm.TypeOfLevelQualityAttr };
            else return new string[] { WeedLevelOfQualityNorm.NameTable, WeedLevelOfQualityNorm.NormAttr, WeedLevelOfQualityNorm.TypeOfLevelQualityAttr };
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] change = changeComboBox(groupComboBox.Text);
            addButton.BackColor = Color.DarkOrange;
            changeButton.BackColor = Color.DarkOrange;
            defineClassButton.BackColor = Color.DarkOrange;
            selectAnalys(change);
        }
        private void selectAnalys(string[] change)
        {
            dataGridViewAnalys.Rows.Clear();
            dataGridViewAnalys.DataSource = DAO.getInstance().selectAnalysQuality(RawClass.NameTable, RawClass.RawIdAttr, Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value), RawClass.ClassNameAttr);
            dataGridViewAnalys.ClearSelection();
        }
    }
}
