using Elevator.Forms;
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
    public partial class MainForm : Form
    {
        public Employee employee;
        public MainForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            labelEmp.Text = employee.Surname + " " + employee.Name;
            if (employee.Post.Equals("Лаборант"))
            {
                employeeToolStripMenuItem.Enabled = false;
                contractorToolStripMenuItem.Enabled = false;
                contractToolStripMenuItem.Enabled = false;
                reportToolStripMenuItem.Enabled = false;
            }
            else if (employee.Post.Equals("Бухгалтер"))
            {
                rawToolStripMenuItem.Enabled = false;
                storageToolStripMenuItem.Enabled = false;
                impurityToolStripMenuItem.Enabled = false;
                normsImpurityToolStripMenuItem.Enabled = false;
                analysisQualityToolStripMenuItem.Enabled = false;
                dataAnalysToolStripMenuItem.Enabled = false;
                analysisCardToolStripMenuItem.Enabled = false;
                employeeToolStripMenuItem.Enabled = false;
            }
            else if (employee.Post.Equals("Главный бухгалтер"))
            {
                rawToolStripMenuItem.Enabled = false;
                storageToolStripMenuItem.Enabled = false;
                impurityToolStripMenuItem.Enabled = false;
                normsImpurityToolStripMenuItem.Enabled = false;
                analysisQualityToolStripMenuItem.Enabled = false;
                dataAnalysToolStripMenuItem.Enabled = false;
                analysisCardToolStripMenuItem.Enabled = false;
            }
            else if (employee.Post.Equals("Заведующий лабораторией"))
            {
                employeeToolStripMenuItem.Enabled = false;
                contractorToolStripMenuItem.Enabled = false;
                contractToolStripMenuItem.Enabled = false;
            }
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
            new TransportationForm(employee).ShowDialog();
        }

        private void отгрузкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TransportationForm("Отгрузка", employee).ShowDialog();
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
            new ProcessingForm(employee).ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StorageForm(employee).ShowDialog();
        }

        private void analysisCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AnalysisCardForm().ShowDialog();
             //new Form1().ShowDialog();        
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportsForm().ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }   
}

