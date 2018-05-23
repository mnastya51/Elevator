using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ReportForm : Form
    {
        private string type;
        private string dateS;
        private string datePo;
        private string contractor;
        private string subdivision;

        public ReportForm(string type, string dateS, string datePo, string contractor, string subdivision)
        {
            InitializeComponent();
            this.type = type;
            this.dateS = dateS;
            this.datePo = datePo;
            this.contractor = contractor;
            this.subdivision = subdivision;
            this.Text = "Отчет " + type;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            if (type == "\'Объем зерна\'")
            {
                if (dateS == "" && datePo == "")
                {
                    if (contractor == "")
                    {
                        SqlDataAdapter da = DAO.getInstance().selectReport("ReportWeight");
                        AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
                        da.Fill(ds, "ReportWeight");
                        ReportDocument doc = new ReportDocument();
                        doc.Load("Reports/ReportWeight.rpt");
                        doc.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = doc;
                    }
                    else
                    {
                        SqlDataAdapter da = DAO.getInstance().selectReportContractor(contractor,
                            subdivision, "ReportWeightWithContractor");
                        AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
                        da.Fill(ds, "ReportWeightWithContractor");
                        ReportDocument doc = new ReportDocument();
                        doc.Load("Reports/ReportWeightWithContractor.rpt");
                        doc.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = doc;
                    }
                }
                else
                {
                    if (contractor == "")
                    {
                        SqlDataAdapter da = DAO.getInstance().selectReportWithPeriod(dateS, 
                            datePo, "ReportWeightWithPeriod");
                        AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
                        da.Fill(ds, "ReportWeightWithPeriod");
                        ReportDocument doc = new ReportDocument();
                        doc.Load("Reports/ReportWeightWithPeriod.rpt");
                        doc.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = doc;
                    }
                    else
                    {
                        SqlDataAdapter da = DAO.getInstance().selectReportContractorWithPeriod(contractor, 
                            subdivision, dateS, datePo, "ReportWeightWithContractorPeriod");
                        AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
                        da.Fill(ds, "ReportWeightWithContractorPeriod");
                        ReportDocument doc = new ReportDocument();
                        doc.Load("Reports/ReportWeightWithContractorPeriod.rpt");
                        doc.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = doc;
                    }
                }
            }
            else if (type == "\'Проведенная обработка\'")
            {
                if (dateS == "" && datePo == "")
                {
                    if (contractor == "")
                    {
                       SqlDataAdapter da = DAO.getInstance().selectReport("ProcessReport");
                        AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
                        da.Fill(ds, "ProcessReport");
                        ReportDocument doc = new ReportDocument();
                        doc.Load("Reports/ReportProcess.rpt");
                        doc.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = doc;
                    }
                    else
                    {                       
                        SqlDataAdapter da = DAO.getInstance().selectReportContractor(contractor, 
                            subdivision, "ProcessReportContractor");
                        AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
                        da.Fill(ds, "ProcessReportContractor");
                        ReportDocument doc = new ReportDocument();
                        doc.Load("Reports/ProcessReportContractor.rpt");
                        doc.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = doc;
                    }
                }
                else
                {
                    if (contractor == "")
                    {
                       SqlDataAdapter da = DAO.getInstance().selectReportWithPeriod(dateS, datePo,
                          "ProcessReportWithPeriod");
                        AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
                        da.Fill(ds, "ProcessReportWithPeriod");
                        ReportDocument doc = new ReportDocument();
                        doc.Load("Reports/ProcessReportWithPeriod.rpt");
                        doc.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = doc;
                    }
                    else
                    {
                        SqlDataAdapter da = DAO.getInstance().selectReportContractorWithPeriod(contractor,
                            subdivision, dateS, datePo, "ProcessReportContractorWithPeriod");
                        AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
                        da.Fill(ds, "ProcessReportContractorWithPeriod");
                        ReportDocument doc = new ReportDocument();
                        doc.Load("Reports/ProcessReportContractorWithPeriod.rpt");
                        doc.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = doc;
                    }
                }
            }                         
        }
    }  
}
