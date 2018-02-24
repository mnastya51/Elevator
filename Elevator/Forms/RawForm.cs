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
    public partial class RawForm : Form
    {
        private RawController controller;
        public RawForm()
        {
            InitializeComponent();
            controller = new RawController();
            dataGridViewRaw.CellClick += dataGridViewRaw_CellClick;
            dataGridViewType.CellClick += dataGridViewType_CellClick;
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

        private void dataGridViewRaw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBoxClass.Enabled = true;
            addButtonClass.BackColor = Color.DarkOrange;
            deleteButtonClass.BackColor = Color.DarkOrange;
            dataGridViewClass.DataSource = DAO.getInstance().selectTableNote("Class", "id_NameRaw", Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value));
            dataGridViewClass.ClearSelection();

            groupBoxType.Enabled = true;
            addTypeButton.BackColor = Color.DarkOrange;
            deleteTypeButton.BackColor = Color.DarkOrange;
            dataGridViewType.DataSource = DAO.getInstance().selectTableNote("Type_raw", "id_NameRaw", Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value));
            dataGridViewType.ClearSelection();

            addSubtypeButton.Enabled = false;
            deleteSubtypeButton.Enabled = false;
            addSubtypeButton.BackColor = Color.LightGray;
            deleteSubtypeButton.BackColor = Color.LightGray;
            if (dataGridViewSubtype.Rows.Count != 0)
                dataGridViewSubtype.DataSource = null;                
        }

        private void addButtonClass_Click(object sender, EventArgs e)
        {
            controller.addNoteButtonClick("Класс:", Convert.ToInt32(dataGridViewRaw.CurrentRow.Cells[0].Value), "Class", "number_class", "id_NameRaw");
            dataGridViewClass.DataSource = DAO.getInstance().selectTableNote("Class", "id_NameRaw ", Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value));
            dataGridViewClass.ClearSelection();
        }

        private void deleteButtonClass_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewClass.SelectedRows[0];
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    controller.deleteNoteButtonClick("Class", "id_class", dataGridViewClass.CurrentRow.Cells[0].Value.ToString());
                    dataGridViewClass.DataSource = DAO.getInstance().selectTableNote("Class", "id_NameRaw", Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value));
                    dataGridViewClass.ClearSelection();
                }
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите класс!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error); }        
        }

        private void addTypeButton_Click(object sender, EventArgs e)
        {
            controller.addNoteButtonClick("Тип:", Convert.ToInt32(dataGridViewRaw.CurrentRow.Cells[0].Value), "Type_raw", "name_type_raw", "id_NameRaw");
            dataGridViewType.DataSource = DAO.getInstance().selectTableNote("Type_raw", "id_NameRaw", Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value));
            dataGridViewType.ClearSelection();
        }

        private void deleteTypeButton_Click(object sender, EventArgs e)
        {
              try
              {
                  DataGridViewRow row = dataGridViewType.SelectedRows[0];
                  DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись?",
                  "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                  if (dr == DialogResult.OK)
                  {
                      controller.deleteNoteButtonClick("Type_raw", "id_type", dataGridViewType.CurrentRow.Cells[0].Value.ToString());
                      dataGridViewType.DataSource = DAO.getInstance().selectTableNote("Type_raw", "id_NameRaw", Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value));
                      dataGridViewType.ClearSelection();
                  }
              }
              catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите тип!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error); }
              
        }

        private void addSubtypeButton_Click(object sender, EventArgs e)
        {
            controller.addNoteButtonClick("Подтип:", Convert.ToInt32(dataGridViewType.CurrentRow.Cells[0].Value), "Subtype_raw", "name_subtype", "id_type");
            dataGridViewSubtype.DataSource = DAO.getInstance().selectTableNote("Subtype_raw", "id_type", Convert.ToString(dataGridViewType.CurrentRow.Cells[0].Value));
            dataGridViewSubtype.ClearSelection();
        }

        private void deleteSubtypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewType.SelectedRows[0];
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    controller.deleteNoteButtonClick("Subtype_raw", "id_subtype", dataGridViewSubtype.CurrentRow.Cells[0].Value.ToString());
                    dataGridViewSubtype.DataSource = DAO.getInstance().selectTableNote("Subtype_raw", "id_type", Convert.ToString(dataGridViewType.CurrentRow.Cells[0].Value));
                    dataGridViewSubtype.ClearSelection();
                }
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите подтип!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void dataGridViewType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addSubtypeButton.Enabled = true;
            deleteSubtypeButton.Enabled = true;
            addSubtypeButton.BackColor = Color.DarkOrange;
            deleteSubtypeButton.BackColor = Color.DarkOrange;
            dataGridViewSubtype.DataSource = DAO.getInstance().selectTableNote("Subtype_raw", "id_type", Convert.ToString(dataGridViewType.CurrentRow.Cells[0].Value));
            dataGridViewSubtype.ClearSelection();
        }
    }
}
