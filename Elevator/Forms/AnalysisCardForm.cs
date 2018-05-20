using Elevator.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Elevator.Model;

namespace Elevator.Forms
{
    public partial class AnalysisCardForm : Form
    {
        private Employee employee;
        public AnalysisCardForm(Employee employee)
        {
            InitializeComponent();
            dataGridViewRaw.Rows.Clear();
            DAO.getInstance().selectRawForStorage(dataGridViewRaw);
            this.employee = employee;
            dataGridViewRaw.ClearSelection();
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewRaw.SelectedRows[0];
                //new ReportAnalysisCardForm(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value), employee).ShowDialog();
                new Form1(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value), employee).ShowDialog();
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите запись!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dataGridViewRaw_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewRaw.ClearSelection();
        }
    }
}

