using Elevator.Controllers;
using Elevator.Model;
using Elevator.Utils;
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
        private LinkedList<string> impurities;
        private AnalysQualityRawController controller;
        private string[] change;
        public AnalysQualityRawForm()
        {
            InitializeComponent();
            impurities = new LinkedList<string>();
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
            string[] typeAndSubtype = DAO.getInstance().selectTypeAndSubtype(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value));
            typeLabel.Text = typeAndSubtype[0];
            subtypeLabel.Text = typeAndSubtype[1];
            groupComboBox.Enabled = true;
            groupComboBox.SelectedIndex = -1;
            addButton.BackColor = Color.LightGray;
            changeButton.BackColor = Color.LightGray;
            defineClassButton.BackColor = Color.LightGray;
            addButton.Enabled = false;
            changeButton.Enabled = false;
            defineClassButton.Enabled = false;
            dataGridViewAnalys.Rows.Clear();
        }

        private string[] changeComboBox(string nameTable)
        {
            if (nameTable == "Общие показатели")
                return new string[] { TypeGeneralLevelOfQuality.NameTable, TypeGeneralLevelOfQuality.NameAttr, GeneralLevelOfQuality.NameTable, GeneralLevelOfQuality.ValueAttr };
            else if (nameTable == "Вредные примеси")
                return new string[] { TypeHarmfulLevelOfQuality.NameTable, TypeHarmfulLevelOfQuality.NameAttr, HarmfulLevelOfQuality.NameTable, HarmfulLevelOfQuality.ValueAttr };
            else if (nameTable == "Зерновые примеси")
                return new string[] { TypeGrainLevelOfQuality.NameTable, TypeGrainLevelOfQuality.NameAttr, GrainLevelOfQuality.NameTable, GrainLevelOfQuality.ValueAttr };
            else return new string[] { TypeWeedLevelOfQuality.NameTable, TypeWeedLevelOfQuality.NameAttr, WeedLevelOfQuality.NameTable, WeedLevelOfQuality.ValueAttr };
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            change = changeComboBox(groupComboBox.Text);
            groupBox3.Enabled = true;
            addButton.BackColor = Color.DarkOrange;
            changeButton.BackColor = Color.DarkOrange;
            defineClassButton.BackColor = Color.DarkOrange;
            addButton.Enabled = true;
            changeButton.Enabled = true;
            defineClassButton.Enabled = true;
            selectAnalys(change);
        }
        private void selectAnalys(string[] change)
        {
            dataGridViewAnalys.Rows.Clear();
            impurities = DAO.getInstance().selectAnalysQuality(change[0], change[1], change[2], change[3], Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value), dataGridViewAnalys);
            dataGridViewAnalys.ClearSelection();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            switch (groupComboBox.Text)
            {
                case "Общие показатели":
                    controller.addButtonClick(new GeneralLevelOfQuality(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value)), change, impurities);
                    break;
                case "Вредные примеси":
                    controller.addButtonClick(new HarmfulLevelOfQuality(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value)), change, impurities);
                    break;
                case "Зерновые примеси":
                    controller.addButtonClick(new GrainLevelOfQuality(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value)), change, impurities);
                    break;
                case "Сорные примеси":
                    controller.addButtonClick(new WeedLevelOfQuality(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value)), change, impurities);
                    break;
            }
            selectAnalys(change);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewAnalys.SelectedRows[0];
                switch (groupComboBox.Text)
                {
                    case "Общие показатели":
                        GeneralLevelOfQuality generalLevelOfQualityNorm = new GeneralLevelOfQuality(Convert.ToString(dataGridViewAnalys.CurrentRow.Cells[1].Value),
                            Convert.ToString(dataGridViewAnalys.CurrentRow.Cells[0].Value), Convert.ToString(dataGridViewAnalys.CurrentRow.Cells[2].Value));
                        controller.changeButtonClick(generalLevelOfQualityNorm, true);
                        break;
                    case "Вредные примеси":
                        HarmfulLevelOfQuality harmfulLevelOfQuality = new HarmfulLevelOfQuality(Convert.ToString(dataGridViewAnalys.CurrentRow.Cells[1].Value),
                            Convert.ToString(dataGridViewAnalys.CurrentRow.Cells[0].Value), Convert.ToString(dataGridViewAnalys.CurrentRow.Cells[2].Value));
                        controller.changeButtonClick(harmfulLevelOfQuality, true);
                        break;
                    case "Сорные примеси":
                        WeedLevelOfQuality weedLevelOfQuality = new WeedLevelOfQuality(Convert.ToString(dataGridViewAnalys.CurrentRow.Cells[1].Value),
                            Convert.ToString(dataGridViewAnalys.CurrentRow.Cells[0].Value), Convert.ToString(dataGridViewAnalys.CurrentRow.Cells[2].Value));
                        controller.changeButtonClick(weedLevelOfQuality, true);
                        break;
                    case "Зерновые примеси":
                        GrainLevelOfQuality grainLevelOfQuality = new GrainLevelOfQuality(Convert.ToString(dataGridViewAnalys.CurrentRow.Cells[1].Value),
                            Convert.ToString(dataGridViewAnalys.CurrentRow.Cells[0].Value), Convert.ToString(dataGridViewAnalys.CurrentRow.Cells[2].Value));
                        controller.changeButtonClick(grainLevelOfQuality, true);
                        break;
                }
                selectAnalys(changeComboBox(groupComboBox.Text));
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите запись!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            dataGridViewRaw.Rows.Clear();
            FilterUtils.FilterFormatter filterFormatter = new FilterUtils.FilterFormatter();
            filterFormatter.addValue("date_delivery", dateTimePicker.Text);
            filterFormatter.addValueWithRegisters("name_raw", rawTextBox.Text);
            filterFormatter.addValueWithRegisters("name_contr", contractorTextBox.Text);         
            string command = filterFormatter.getFormattedRequestForFindRaw();           
            DAO.getInstance().findRaw(command, dataGridViewRaw);
            dataGridViewRaw.ClearSelection();
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            select();
        }
    }
}
