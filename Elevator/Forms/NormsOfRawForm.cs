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
    public partial class NormsOfRawForm : Form
    {
        private NormOfRawController controller;
        public NormsOfRawForm()
        {
            InitializeComponent();
            controller = new NormOfRawController();
            groupComboBox.Text = groupComboBox.Items[0].ToString();
        }

        private FormValue<string, string> changeComboBox(string nameTable)
        {
            if (nameTable == "Общие показатели")
                return new FormValue<string, string>("Norm_general_impurities", "norm_imp");
            else if (nameTable == "Вредные примеси")
                return new FormValue<string, string>("Norm_harmful_impurities", "norm_harm_imp ");
            else if (nameTable == "Зерновые примеси")
                return new FormValue<string, string>("Norm_grain_impurities", "norm_grain_imp");
            else return new FormValue<string, string>("Norm_weed_impurities", "norm_weed_imp");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            addButton.BackColor = Color.DarkOrange;
            deleteButton.Enabled = true;
            deleteButton.BackColor = Color.DarkOrange;

            FormValue<string, string> formValue = changeComboBox(groupComboBox.Text);

            dataGridViewNorms.Rows.Clear();
           // DAO.getInstance().selectNormsTable(formValue.getKey(),
           //      new FormValue<string, string>(formValue.getValue(), rawComboBox), 
           //       dataGridViewNorms);
            dataGridViewNorms.ClearSelection();
        }

        private void NormsOfRawForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountOfGrainDataSet.Raw". При необходимости она может быть перемещена или удалена.
            this.rawTableAdapter.Fill(this.accountOfGrainDataSet.Raw);          
        }
    }
}
