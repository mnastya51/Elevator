using Elevator.AddAndEditForms;
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
    public partial class DateAnalysForm : Form
    {
        private DateAnalysController controller;
        public DateAnalysForm()
        {
            InitializeComponent();
            controller = new DateAnalysController();
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
            addButton.BackColor = Color.DarkOrange;
            changeButton.BackColor = Color.DarkOrange;           
            addButton.Enabled = true;
            changeButton.Enabled = true;
            deleteButton.BackColor = Color.DarkOrange;
            deleteButton.Enabled = true;
            selectDate();
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            rawTextBox.Text = "";
            select();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddDateAnalysForm(new DateAnalys(
                Convert.ToInt32(dataGridViewRaw.CurrentRow.Cells[4].Value),
                Convert.ToInt32(dataGridViewRaw.CurrentRow.Cells[0].Value))).ShowDialog();
            selectDate();
        }
        private void selectDate()
        {
            dataGridViewDate.Rows.Clear();
            DAO.getInstance().selectDateAnalys(dataGridViewDate, Convert.ToInt32(dataGridViewRaw.CurrentRow.Cells[4].Value),
                Convert.ToInt32(dataGridViewRaw.CurrentRow.Cells[0].Value));
            dataGridViewDate.ClearSelection();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewDate.SelectedRows[0];
                DateAnalys dateAnalys = new DateAnalys(Convert.ToString(dataGridViewDate.CurrentRow.Cells[0].Value));
                controller.changeButtonClick(dateAnalys, true);
                selectDate();
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите контрагента!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewDate.SelectedRows[0];
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    controller.deleteButtonClick(dataGridViewDate.CurrentRow.Cells[0].Value.ToString());
                    selectDate();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите контрагента!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Невозможно удалить запись! Она используется в других таблицах!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
