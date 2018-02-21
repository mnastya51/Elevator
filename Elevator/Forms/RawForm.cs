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
            dataGridViewRaw.CellClick += dataGridViewRawe_CellClick;
        }

        private void RawForm_Load(object sender, EventArgs e)
        {          
            dataGridViewRaw.DataSource = DAO.getInstance().selectTable("Raw");
            dataGridViewRaw.ClearSelection();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            controller.addButtonClick();
            dataGridViewRaw.DataSource = DAO.getInstance().selectTable("Raw");
            dataGridViewRaw.ClearSelection();
            groupBoxClass.Enabled = false;
            addButtonClass.BackColor = Color.LightGray;
            deleteButtonClass.BackColor = Color.LightGray;
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
                dataGridViewRaw.ClearSelection();
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите сырье!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            groupBoxClass.Enabled = false;
            addButtonClass.BackColor = Color.LightGray;
            deleteButtonClass.BackColor = Color.LightGray;
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
                    dataGridViewRaw.ClearSelection();
                }
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите сырье!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            groupBoxClass.Enabled = false;
            addButtonClass.BackColor = Color.LightGray;
            deleteButtonClass.BackColor = Color.LightGray;
        }

        private void dataGridViewRawe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBoxClass.Enabled = true;
            addButtonClass.BackColor = Color.DarkOrange;
            deleteButtonClass.BackColor = Color.DarkOrange;
        }

        private void addButtonClass_Click(object sender, EventArgs e)
        {
            controller.addClassButtonClick("Класс:");
          //  dataGridViewRaw.DataSource = DAO.getInstance().selectTable("Class");
            dataGridViewRaw.ClearSelection();
        }
    }
}
