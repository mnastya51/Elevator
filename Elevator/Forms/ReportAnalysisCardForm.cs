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
    public partial class ReportAnalysisCardForm : Form
    {
        public ReportAnalysisCardForm(string idRaw, Employee employee)
        {
            InitializeComponent();
            SqlDataAdapter da = DAO.getInstance().selectReportAnalysisCardGeneral(idRaw, employee.Id);
            AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
            da.Fill(ds, "ReportAnalysisCardGeneral");
            ReportDocument doc = new ReportDocument();
            
            SqlDataAdapter da1 = DAO.getInstance().selectReportAnalysisCardGrain(idRaw);
            da1.Fill(ds, "ReportAnalysisCardGrain");

            SqlDataAdapter da2 = DAO.getInstance().selectReportAnalysisCardHarmful(idRaw);
            da2.Fill(ds, "ReportAnalysisCardHarmful");

            SqlDataAdapter da3 = DAO.getInstance().selectReportAnalysisCardWeed(idRaw);
            da3.Fill(ds, "ReportAnalysisCardWeed");

            doc.Load("Reports/ReportAnalysisCardWeed.rpt");
            doc.Load("Reports/ReportAnalysisCardHarmful.rpt");
            doc.Load("Reports/ReportAnalysisCardGrain.rpt");
            doc.Load("Reports/ReportAnalysisCardGeneral.rpt");
            doc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = doc;
        }
    }
}
