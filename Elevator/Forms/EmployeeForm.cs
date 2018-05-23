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
    public partial class EmployeeForm : Form
    {
        private EmployeeController controller;
        private Employee employee;
        public EmployeeForm(Employee employee)
        {
            InitializeComponent();
            controller = new EmployeeController();
            this.employee = employee;
            dataGridViewEmployee.CellClick += dataGridViewEmployee_CellClick;
            if (!(employee.Post.Equals("Главный бухгалтер") || employee.Post.Equals("admin")))
            {
                addButton.Enabled = false;
                addButton.BackColor = Color.LightGray;
                deleteButton.Enabled = false;
                deleteButton.BackColor = Color.LightGray;
                changeButton.Enabled = false;
                changeButton.BackColor = Color.LightGray;
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountOfGrainDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.accountOfGrainDataSet.Employee);
            dataGridViewEmployee.DataSource = DAO.getInstance().selectTable("Employee");
            dataGridViewEmployee.ClearSelection();
        }

        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employee.Login == Convert.ToString(dataGridViewEmployee.CurrentRow.Cells[5].Value))
            {
                changeButton.Enabled = true;
                changeButton.BackColor = Color.DarkOrange;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewEmployee.SelectedRows[0];
                Employee selectEmployee = new Employee(Convert.ToInt32(dataGridViewEmployee.CurrentRow.Cells[0].Value),
                    Convert.ToString(dataGridViewEmployee.CurrentRow.Cells[1].Value),
                    Convert.ToString(dataGridViewEmployee.CurrentRow.Cells[2].Value),
                    Convert.ToString(dataGridViewEmployee.CurrentRow.Cells[3].Value),
                    Convert.ToString(dataGridViewEmployee.CurrentRow.Cells[4].Value),
                    Convert.ToString(dataGridViewEmployee.CurrentRow.Cells[5].Value),
                    Convert.ToString(dataGridViewEmployee.CurrentRow.Cells[6].Value));
                controller.changeButtonClick(employee, selectEmployee);
                dataGridViewEmployee.DataSource = DAO.getInstance().selectTable("Employee");
                dataGridViewEmployee.ClearSelection();
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите сотрудника!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        private void findButton_Click(object sender, EventArgs e)
        {
            dataGridViewEmployee.DataSource = controller.findButtonClick(surnameTextBox.Text);
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            dataGridViewEmployee.DataSource = DAO.getInstance().selectTable("Employee");
            surnameTextBox.Text = string.Empty;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            controller.addButtonClick();
            dataGridViewEmployee.DataSource = DAO.getInstance().selectTable("Employee");
            dataGridViewEmployee.ClearSelection();
        }
    }
}
