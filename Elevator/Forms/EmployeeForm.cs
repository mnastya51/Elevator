using Elevator.Controllers;
using Elevator.Entity;
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
    public partial class EmployeeForm : Form
    {
        private EmployeeController controller;
        public EmployeeForm()
        {
            InitializeComponent();
            controller = new EmployeeController();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            dataGridViewEmployee.DataSource = DAO.getInstance().selectTable("Employee");
            dataGridViewEmployee.ClearSelection();

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewEmployee.SelectedRows[0];
                Employee Employee = new Employee(Convert.ToInt32(dataGridViewEmployee.CurrentRow.Cells[0].Value),
                    Convert.ToString(dataGridViewEmployee.CurrentRow.Cells[1].Value),
                    Convert.ToString(dataGridViewEmployee.CurrentRow.Cells[2].Value),
                    Convert.ToString(dataGridViewEmployee.CurrentRow.Cells[3].Value),
                    Convert.ToString(dataGridViewEmployee.CurrentRow.Cells[4].Value));
                controller.changeButtonClick(Employee);
                dataGridViewEmployee.DataSource = DAO.getInstance().selectTable("Employee");
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите сотрудника!", "Измнение", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewEmployee.SelectedRows[0];
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    controller.deleteButtonClick(dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString());
                    dataGridViewEmployee.DataSource = DAO.getInstance().selectTable("Employee");
                }
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите контрагента!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
