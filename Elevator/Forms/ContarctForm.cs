
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
    public partial class ContarctForm : Form
    {
        private ContractController controller;
        public ContarctForm()
        {
            InitializeComponent();
            controller = new ContractController();
            select();
        }
        private void select()
        {
            dataGridViewContract.Rows.Clear();
            DAO.getInstance().selectContract(dataGridViewContract);
            dataGridViewContract.ClearSelection();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            controller.addButtonClick();
            select();          
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewContract.SelectedRows[0];
                Contract contract = new Contract(Convert.ToString(dataGridViewContract.CurrentRow.Cells[0].Value),
                    Convert.ToString(dataGridViewContract.CurrentRow.Cells[1].Value),
                    Convert.ToString(dataGridViewContract.CurrentRow.Cells[2].Value),
                    Convert.ToString(dataGridViewContract.CurrentRow.Cells[3].Value));              
                controller.changeButtonClick(contract);
                select();
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите запись!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewContract.SelectedRows[0];
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    controller.deleteButtonClick(dataGridViewContract.CurrentRow.Cells[0].Value.ToString(), dataGridViewContract.CurrentRow.Cells[1].Value.ToString());
                    select();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите запись!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void findButton_Click(object sender, EventArgs e)
        {
            dataGridViewContract.Rows.Clear();
            controller.findButtonClick(nameContractortextBox.Text, dataGridViewContract);
            dataGridViewContract.ClearSelection();
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            dataGridViewContract.Rows.Clear();
            select();
            nameContractortextBox.Text = string.Empty;
        }
    }
}
