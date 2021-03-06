﻿using Elevator.Controllers;
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
        private Employee employee;
        bool find = false;
        public ProcessingForm(Employee employee)
        {
            InitializeComponent();
            controller = new ProcessingController();
            dataGridViewRaw.SelectionChanged += dataGridViewRaw_CellClick;
            select();
            this.employee = employee;
            if (employee.Post.Equals("Бухгалтер") || employee.Post.Equals("Главный бухгалтер"))
            {
                addClearButton.Enabled = false;
                changeClearButton.BackColor = Color.LightGray;
                addDryButton.Enabled = false;
                changeDryButton.BackColor = Color.LightGray;
            }
        }

        private void select()
        {
            dataGridViewRaw.Rows.Clear();
            //DAO.getInstance().selectRaw(dataGridViewRaw);
            DAO.getInstance().selectRawForStorage(dataGridViewRaw);
            dataGridViewRaw.ClearSelection();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            find = true;
            dataGridViewRaw.Rows.Clear();
            FilterUtils.FilterFormatter filterFormatter = new FilterUtils.FilterFormatter();
            filterFormatter.addValueWithRegisters("name_raw", rawTextBox.Text);
            filterFormatter.addValueWithRegisters("name_contr", contractorTextBox.Text);
            string command = filterFormatter.getFormattedRequestForFindRawStorage();
            DAO.getInstance().findRawForStorage(command, dataGridViewRaw);
            dataGridViewRaw.ClearSelection();
            find = false;
        }

        private void dataGridViewRaw_CellClick(object sender, EventArgs e)
        {
            if (!find)
            {
                if ((employee.Post.Equals("Бухгалтер") || employee.Post.Equals("Главный бухгалтер")))
                {
                    addClearButton.BackColor = Color.LightGray;
                    changeClearButton.BackColor = Color.LightGray;
                    addDryButton.BackColor = Color.LightGray;
                    changeDryButton.BackColor = Color.LightGray;
                    addClearButton.Enabled = false;
                    changeClearButton.Enabled = false;
                    changeDryButton.Enabled = false;
                    addDryButton.Enabled = false;
                }
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
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            find = true;
            contractorTextBox.Text = "";
            rawTextBox.Text = "";
            select();
            find = false;
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
            if (labelDate.Text != "" || labelWeightAfter.Text != "" ||
            labelWetBefore.Text != "" || labelWetAfter.Text != "")
            {
                MessageBox.Show("Данные о сушке уже добавлены!", "Сушка!", MessageBoxButtons.OK, MessageBoxIcon.Information);        
            }
            else
            {
                controller.addButtonClick(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value),
                    Convert.ToString(dataGridViewRaw.CurrentRow.Cells[8].Value), 
                    Convert.ToString(dataGridViewRaw.CurrentRow.Cells[2].Value),
                    Convert.ToString(dataGridViewRaw.CurrentRow.Cells[7].Value));
                selectDry();
            }
        }

        private void changeDryButton_Click(object sender, EventArgs e)
        {
            if (labelDate.Text != "")
            {
                Drying drying = new Drying(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value),
                    Convert.ToString(dataGridViewRaw.CurrentRow.Cells[8].Value),
                    labelDate.Text, Convert.ToString(dataGridViewRaw.CurrentRow.Cells[7].Value), labelWeightAfter.Text, labelWetBefore.Text, labelWetAfter.Text);
                controller.changeButtonClick(drying);
                selectDry();
            }
            else
            {
                MessageBox.Show("Добавьте запись!", "Сушка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeClearButton_Click(object sender, EventArgs e)
        {
            if (labelDateClear.Text != "")
            {
                Clearing clearing = new Clearing(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value),
                    Convert.ToString(dataGridViewRaw.CurrentRow.Cells[8].Value),
                    labelDateClear.Text, Convert.ToString(dataGridViewRaw.CurrentRow.Cells[7].Value), labelWeightAfterClear.Text);
                controller.changeButtonClearClick(clearing);
                selectClear();
            }
            else
            {
                MessageBox.Show("Добавьте запись!", "Очистка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addClearButton_Click(object sender, EventArgs e)
        {
            if (labelDateClear.Text != "" || labelWeightAfterClear.Text != "")
            {
                MessageBox.Show("Данные об очистке уже добавлены!", "Очистка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                controller.addButtonClearClick(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value),
                    Convert.ToString(dataGridViewRaw.CurrentRow.Cells[8].Value),
                    Convert.ToString(dataGridViewRaw.CurrentRow.Cells[2].Value),
                    Convert.ToString(dataGridViewRaw.CurrentRow.Cells[7].Value));
                selectClear();
            }
        }
    }
}
