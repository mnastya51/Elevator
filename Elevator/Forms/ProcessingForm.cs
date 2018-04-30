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
    public partial class ProcessingForm : Form
    {
        private ProcessingController controller;
        public ProcessingForm()
        {
            InitializeComponent();
            controller = new ProcessingController();
            dataGridViewRaw.CellClick += dataGridViewRaw_CellClick;
            select();
        }

        private void select()
        {
            dataGridViewRaw.Rows.Clear();
            DAO.getInstance().selectRaw(dataGridViewRaw);
            dataGridViewRaw.ClearSelection();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            dataGridViewRaw.Rows.Clear();
            FilterUtils.FilterFormatter filterFormatter = new FilterUtils.FilterFormatter();
            filterFormatter.addValueWithRegisters("name_raw", rawTextBox.Text);
            filterFormatter.addValueWithRegisters("name_contr", contractorTextBox.Text);
            string command = filterFormatter.getFormattedRequestForFindRaw();
            DAO.getInstance().findRaw(command, dataGridViewRaw);
            dataGridViewRaw.ClearSelection();
        }

        private void dataGridViewRaw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addDryButton.BackColor = Color.DarkOrange;
            changeDryButton.BackColor = Color.DarkOrange;
            addDryButton.Enabled = true;
            changeDryButton.Enabled = true;
            addClearButton.BackColor = Color.DarkOrange;
            changeClearButton.BackColor = Color.DarkOrange;
            addClearButton.Enabled = true;
            changeClearButton.Enabled = true;
            labelDate.Text = "";
            labelWeightBefore.Text = "";
            labelWeightAfter.Text = "";
            labelWetBefore.Text = "";
            labelWetAfter.Text = "";
            labelDateClear.Text = "";
            labelWeightBeforeClear.Text = "";
            labelWeightAfterClear.Text = "";
            selectDry();
            selectClear();
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            contractorTextBox.Text = "";
            rawTextBox.Text = "";
            select();
        }

        private void selectDry()
        {
            string[] values = DAO.getInstance().selectDry(Convert.ToInt32(dataGridViewRaw.CurrentRow.Cells[0].Value));
            if (values.Length != 0)
            {
                labelDate.Text = values[0];
                labelWeightBefore.Text = values[1];
                labelWeightAfter.Text = values[2];
                labelWetBefore.Text = values[3];
                labelWetAfter.Text = values[4];
            }
        }

        private void selectClear()
        {
            string[] values = DAO.getInstance().selectClear(Convert.ToInt32(dataGridViewRaw.CurrentRow.Cells[0].Value));
            if (values.Length != 0)
            {
                labelDateClear.Text = values[0];
                labelWeightBeforeClear.Text = values[1];
                labelWeightAfterClear.Text = values[2];
            }
        }

        private void addDryButton_Click(object sender, EventArgs e)
        {
            if (labelDate.Text != "" || labelWeightBefore.Text != "" || labelWeightAfter.Text != "" ||
            labelWetBefore.Text != "" || labelWetAfter.Text != "")
            {
                MessageBox.Show("Данные о сушке уже добавлены!", "Сушка!", MessageBoxButtons.OK, MessageBoxIcon.Information);        
            }
            else
            {
                controller.addButtonClick(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value));
                selectDry();
            }
        }

        private void changeDryButton_Click(object sender, EventArgs e)
        {
            Drying drying = new Drying(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value),
                labelDate.Text, labelWeightBefore.Text, labelWeightAfter.Text, labelWetBefore.Text, labelWetAfter.Text);
            controller.changeButtonClick(drying);
            selectDry();
        }

        private void changeClearButton_Click(object sender, EventArgs e)
        {
            Clearing clearing = new Clearing(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value),
                labelDateClear.Text, labelWeightBeforeClear.Text, labelWeightAfterClear.Text);
            controller.changeButtonClearClick(clearing);
            selectClear();
        }

        private void addClearButton_Click(object sender, EventArgs e)
        {
            if (labelDateClear.Text != "" || labelWeightBeforeClear.Text != "" || labelWeightAfterClear.Text != "")
            {
                MessageBox.Show("Данные об очистке уже добавлены!", "Очистка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                controller.addButtonClearClick(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value));
                selectClear();
            }
        }
    }
}
