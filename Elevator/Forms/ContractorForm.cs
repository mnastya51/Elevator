using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elevator.Entity;
using Elevator.Controllers;

namespace Elevator.Forms
{
    public partial class ContractorForm : Form
    {

        private ContractorController controller;
        public ContractorForm()
        {
            InitializeComponent();
            controller = new ContractorController();
        }

        private void ContractorForm_Load(object sender, EventArgs e)
        {
            dataGridViewContractor.DataSource = DAO.getInstance().selectTable("Contractor");
            dataGridViewContractor.ClearSelection();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            controller.addButtonClick();
            dataGridViewContractor.DataSource = DAO.getInstance().selectTable("Contractor");
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewContractor.SelectedRows[0];
                Contractor contractor = new Contractor(Convert.ToInt32(dataGridViewContractor.CurrentRow.Cells[0].Value), 
                    Convert.ToString(dataGridViewContractor.CurrentRow.Cells[1].Value), 
                    Convert.ToString(dataGridViewContractor.CurrentRow.Cells[2].Value), 
                    Convert.ToString(dataGridViewContractor.CurrentRow.Cells[3].Value), 
                    Convert.ToString(dataGridViewContractor.CurrentRow.Cells[4].Value),
                    dataGridViewContractor.CurrentRow.Cells[5].Value.ToString().Trim() == string.Empty ? 0 : Convert.ToInt32(dataGridViewContractor.CurrentRow.Cells[5].Value), 
                    Convert.ToString(dataGridViewContractor.CurrentRow.Cells[6].Value), 
                    Convert.ToString(dataGridViewContractor.CurrentRow.Cells[7].Value));
                controller.changeButtonClick(contractor);
                dataGridViewContractor.DataSource = DAO.getInstance().selectTable("Contractor");
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите контрагента!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewContractor.SelectedRows[0];
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    controller.deleteButtonClick(dataGridViewContractor.CurrentRow.Cells[0].Value.ToString());
                    dataGridViewContractor.DataSource = DAO.getInstance().selectTable("Contractor");
                }
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите контрагента!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            dataGridViewContractor.DataSource = controller.findButtonClick(nameContractortextBox.Text);
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            dataGridViewContractor.DataSource = DAO.getInstance().selectTable("Contractor");
            nameContractortextBox.Text = string.Empty;
        }

    }
}
