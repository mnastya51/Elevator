using Elevator.Controllers;
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
    public partial class StorageForm : Form
    {
        private StorageController controller;
        public StorageForm()
        {
            InitializeComponent();
            controller = new StorageController();
            dataGridViewRaw.CellClick += dataGridViewRaw_CellClick;
            select();
        }

        private void select()
        {
            dataGridViewRaw.Rows.Clear();
            DAO.getInstance().selectRawForStorage(dataGridViewRaw);
            dataGridViewRaw.ClearSelection();
        }

        private void dataGridViewRaw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addButton.BackColor = Color.DarkOrange;
            changeButton.BackColor = Color.DarkOrange;
            addButton.Enabled = true;
            changeButton.Enabled = true;
            //selectClear();
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

        private void btnAllList_Click(object sender, EventArgs e)
        {
            contractorTextBox.Text = "";
            rawTextBox.Text = "";
            select();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            controller.addButtonClick(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value));
            //selectDry();
        }
    }
}
