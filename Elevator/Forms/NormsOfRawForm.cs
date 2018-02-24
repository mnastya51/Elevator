﻿using Elevator.Controllers;
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
    public partial class NormsOfRawForm : Form
    {
        private NormOfRawController controller;
        private LinkedList<string> impurities;
        public NormsOfRawForm()
        {
            InitializeComponent();
            impurities = new LinkedList<string>();
            controller = new NormOfRawController();
            groupComboBox.Text = groupComboBox.Items[0].ToString();
        }

        private string[] changeComboBox(string nameTable)
        {
            if (nameTable == "Общие показатели")
                return new string[] {"Norm_general_impurities", "norm_imp", "name_imp"};
            else if (nameTable == "Вредные примеси")
                return new string[] {"Norm_harmful_impurities", "norm_harm_imp", "name_harm_imp" };
            else if (nameTable == "Зерновые примеси")
                return new string[] {"Norm_grain_impurities", "norm_grain_imp", "name_grain_imp " };
            else return new string[] {"Norm_weed_impurities", "norm_weed_imp", "name_weed_imp" };
        }

        private string[] changeTypeImpComboBox(string nameTable)
        {
            switch (nameTable)
            {
                case "Общие показатели":
                    return new string[] { "Type_general_impurities", "name_imp"};
                case "Вредные примеси":
                    return new string[] { "Type_harmful_impurities", "name_harm_imp" }; 
                case "Зерновые примеси":
                    return new string[] { "Type_grain_impurities", "name_grain_imp " };
                case "Сорные примеси":
                    return new string[] { "Type_weed_impurities", "name_weed_imp" };
            }
            return new string[] { "", ""};
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            addButton.BackColor = Color.DarkOrange;
            changeButton.Enabled = true;
            changeButton.BackColor = Color.DarkOrange;
            deleteButton.Enabled = true;
            deleteButton.BackColor = Color.DarkOrange;

            string[] change = changeComboBox(groupComboBox.Text);

            dataGridViewNorms.Rows.Clear();
            impurities = DAO.getInstance().selectNormsTable(change[0], //название таблицы
                 change[1], change[2], rawComboBox.Text, //поле для заполнение нормы, наим показателя, имя сырья
                  dataGridViewNorms);
            dataGridViewNorms.ClearSelection();
        }

        private void NormsOfRawForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountOfGrainDataSet.Raw". При необходимости она может быть перемещена или удалена.
            this.rawTableAdapter.Fill(this.accountOfGrainDataSet.Raw);          
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string[] change = changeComboBox(groupComboBox.Text);
            string[] changeForClick = changeTypeImpComboBox(groupComboBox.Text);
            controller.addButtonClick(changeForClick[0], changeForClick[1], impurities, change[1], rawComboBox.Text, change[0]);
           
            dataGridViewNorms.Rows.Clear();
            impurities = DAO.getInstance().selectNormsTable(change[0], //название таблицы
                 change[1], change[2], rawComboBox.Text, //поле для заполнение нормы, наим показателя, имя сырья
                  dataGridViewNorms);
            dataGridViewNorms.ClearSelection();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            string[] change = changeComboBox(groupComboBox.Text);
            try
            {
                DataGridViewRow row = dataGridViewNorms.SelectedRows[0];
                controller.changeButtonClick(Convert.ToString(dataGridViewNorms.CurrentRow.Cells[0].Value),
                    Convert.ToString(dataGridViewNorms.CurrentRow.Cells[1].Value), change[0], 
                    rawComboBox.Text, change[2], change[1]);

                dataGridViewNorms.Rows.Clear();
                impurities = DAO.getInstance().selectNormsTable(change[0], //название таблицы
                     change[1], change[2], rawComboBox.Text, //поле для заполнение нормы, наим показателя, имя сырья
                      dataGridViewNorms);
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите запись!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewNorms.SelectedRows[0];
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    string[] change = changeComboBox(groupComboBox.Text);
                    controller.deleteButtonClick(change[0], change[2], dataGridViewNorms.CurrentRow.Cells[0].Value.ToString(), rawComboBox.Text);

                   
                    dataGridViewNorms.Rows.Clear();
                    impurities = DAO.getInstance().selectNormsTable(change[0], //название таблицы
                         change[1], change[2], rawComboBox.Text, //поле для заполнение нормы, наим показателя, имя сырья
                          dataGridViewNorms);
                }
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите запись!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
