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
            new StorageForm().ShowDialog();
        }

        private void impurityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ImpurityQualityForm().ShowDialog();
        }

        private void normsImpurityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NormsOfRawForm().ShowDialog();
        }
    }
}
