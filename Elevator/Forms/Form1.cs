using CrystalDecisions.CrystalReports.Engine;
using Elevator.Model;
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

namespace Elevator.Forms
{
    public partial class Form1 : Form
    {
        public Form1(string idRaw, Employee employee)
        {
            InitializeComponent();
            SqlDataAdapter da = DAO.getInstance().selectReportAnalysisCard(idRaw, employee.Id);
            AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
            da.Fill(ds, "ReportAnalysisCard");
            ReportDocument doc = new ReportDocument();
            doc.Load("Reports/CrystalReport3.rpt");
            doc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = doc;
        }
    }
}
