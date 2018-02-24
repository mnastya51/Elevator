using Elevator.Controllers;
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
    public partial class ImpurityQualityForm : Form
    {
        private ImpurityQualityController controller;
        public ImpurityQualityForm()
        {
            InitializeComponent();
            controller = new ImpurityQualityController();
        }

        private string changeComboBox(string nameTable)
        {
            if (nameTable == "Общие показатели")
                return "Type_general_impurities";
            else if (nameTable == "Вредные примеси")
                return "Type_harmful_impurities";
            else if (nameTable == "Зерновые примеси")
                return "Type_grain_impurities";
            else return "Type_weed_impurities";
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            if (groupComboBox.Text == "")
                MessageBox.Show("Выберите группу!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                addButton.Enabled = true;
                addButton.BackColor = Color.DarkOrange;
                deleteButton.Enabled = true;
                deleteButton.BackColor = Color.DarkOrange;

                dataGridViewImpurityQuality.Rows.Clear();
                DAO.getInstance().selectImputityTable(changeComboBox(groupComboBox.Text), dataGridViewImpurityQuality);
                dataGridViewImpurityQuality.ClearSelection();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
