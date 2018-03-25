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
    public partial class LevelOfQualityForm : Form
    {
        private LevelOfQualityController controller;
        public LevelOfQualityForm()
        {
            InitializeComponent();
            controller = new LevelOfQualityController();
            groupComboBox.SelectedIndexChanged += groupComboBox_SelectedIndexChanged;
            groupComboBox.Text = groupComboBox.Items[0].ToString();
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            addButton.BackColor = Color.LightGray;
            deleteButton.Enabled = false;
            deleteButton.BackColor = Color.LightGray;
        }

        private FormValue<string, string> changeComboBox(string nameTable)
        {
            if (nameTable == "Общие показатели")
                return new FormValue<string, string>(TypeGeneralLevelOfQuality.NameTable, TypeGeneralLevelOfQuality.NameAttr);
            else if (nameTable == "Вредные примеси")
                return new FormValue<string, string>(TypeHarmfulLevelOfQuality.NameTable, TypeHarmfulLevelOfQuality.NameAttr);
            else if (nameTable == "Зерновые примеси")
                return new FormValue<string, string>(TypeGrainLevelOfQuality.NameTable, TypeGrainLevelOfQuality.NameAttr); 
            else return new FormValue<string, string>(TypeWeedLevelOfQuality.NameTable, TypeWeedLevelOfQuality.NameAttr); 
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            addButton.BackColor = Color.DarkOrange;
            deleteButton.Enabled = true;
            deleteButton.BackColor = Color.DarkOrange;

            dataGridViewImpurityQuality.Rows.Clear();
            DAO.getInstance().selectImpurityTable(changeComboBox(groupComboBox.Text).getKey(), dataGridViewImpurityQuality);
            dataGridViewImpurityQuality.ClearSelection();
        }                 

        private void addButton_Click(object sender, EventArgs e)
        {
            FormValue<string, string> formValue = changeComboBox(groupComboBox.Text);
            controller.addButtonClick(formValue);

            dataGridViewImpurityQuality.Rows.Clear();
            DAO.getInstance().selectImpurityTable(formValue.getKey(), dataGridViewImpurityQuality);
            dataGridViewImpurityQuality.ClearSelection();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewImpurityQuality.SelectedRows[0];
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    FormValue<string, string> formValue = changeComboBox(groupComboBox.Text);
                    controller.deleteButtonClick(formValue, dataGridViewImpurityQuality.CurrentRow.Cells[0].Value.ToString());

                    dataGridViewImpurityQuality.Rows.Clear();
                    DAO.getInstance().selectImpurityTable(changeComboBox(groupComboBox.Text).getKey(), dataGridViewImpurityQuality);
                    dataGridViewImpurityQuality.ClearSelection();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите показатель!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
