using Elevator.Forms;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeForm().ShowDialog();
        }

        private void contractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ContractorForm().ShowDialog();
        }

        private void rawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RawForm().ShowDialog();
        }

        private void storageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StoragePlac1Form().ShowDialog();
        }

        private void impurityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LevelOfQualityForm().ShowDialog();
        }

        private void normsImpurityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NormsOfRawForm().ShowDialog();
        }

        private void contractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ContarctForm().ShowDialog();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TransportationForm().ShowDialog();
        }

        private void отгрузкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TransportationForm("Отгрузка").ShowDialog();
        }

        private void analysisQualityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AnalysQualityRawForm().ShowDialog();
        }

        private void dataAnalysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DateAnalysForm().ShowDialog();
        }

        private void processingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProcessingForm().ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StorageForm().ShowDialog();
        }
    }
}

