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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            string[] contractor = DAO.getInstance().getNoteToComboBox("name_contr", "Contractor");
            contractorComboBox.Items.AddRange(contractor);
        }

        private void contractorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subdivisionComboBox.Items.Clear();
            string[] subdivisions = DAO.getInstance().getSubdivisionToComboBox(contractorComboBox.Text);
            subdivisionComboBox.Items.AddRange(subdivisions);
            if (subdivisions.Length > 0)
                subdivisionComboBox.Text = subdivisionComboBox.Items[0].ToString();
        }

        private void formReportButton_Click(object sender, EventArgs e)
        {
            if (volumeRawRadioButton.Checked)
            {
                if (new ReportController().hasRawInPeriod(fromTextBox.Text, toTextBox.Text))
                {
                    new ReportForm("\'Объем зерна\'", fromTextBox.Text, toTextBox.Text, contractorComboBox.Text, subdivisionComboBox.Text).ShowDialog();
                }
                else
                {
                    MessageBox.Show("За выбранный период сырья нет!", "Формирование отчета", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (processingRadioButton.Checked)
            {
                if (new ReportController().hasRawInPeriod(fromTextBox.Text, toTextBox.Text))
                {
                     new ReportForm("\'Проведенная обработка\'", fromTextBox.Text, toTextBox.Text, contractorComboBox.Text, subdivisionComboBox.Text).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Обработка сырья еще не проводилась!", "Формирование отчета", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void fromTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != '.' && (l < '0' || l > '9'))
                e.Handled = true;
        }

        private void toTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != '.' && (l < '0' || l > '9'))
                e.Handled = true;
        }
    }
}
