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
    public partial class RawForm : Form
    {
        private RawController controller;
        public RawForm()
        {
            InitializeComponent();
            controller = new RawController();
        }

        private void RawForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountOfGrainDataSet.Class". При необходимости она может быть перемещена или удалена.
            this.classTableAdapter.Fill(this.accountOfGrainDataSet.Class);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountOfGrainDataSet.Raw". При необходимости она может быть перемещена или удалена.
            this.rawTableAdapter.Fill(this.accountOfGrainDataSet.Raw);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountOfGrainDataSet.Raw". При необходимости она может быть перемещена или удалена.
            this.rawTableAdapter.Fill(this.accountOfGrainDataSet.Raw);
            dataGridViewRaw.DataSource = DAO.getInstance().selectTable("Raw");
            dataGridViewRaw.ClearSelection();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            controller.addButtonClick();
            dataGridViewRaw.DataSource = DAO.getInstance().selectTable("Raw");
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewRaw.SelectedRows[0];
                Raw raw = new Raw(Convert.ToInt32(dataGridViewRaw.CurrentRow.Cells[0].Value), 
                    Convert.ToString(dataGridViewRaw.CurrentRow.Cells[1].Value),
                    Convert.ToString(dataGridViewRaw.CurrentRow.Cells[2].Value));
                controller.changeButtonClick(raw);
                dataGridViewRaw.DataSource = DAO.getInstance().selectTable("Raw");
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите сырье!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewRaw.SelectedRows[0];
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    controller.deleteButtonClick(dataGridViewRaw.CurrentRow.Cells[0].Value.ToString());
                    dataGridViewRaw.DataSource = DAO.getInstance().selectTable("Raw");
                }
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите сырье!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
