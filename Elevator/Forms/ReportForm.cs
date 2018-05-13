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
                /*SqlDataAdapter da = DAO.getInstance().selectVolume();
                AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
                ds.EnforceConstraints = false;
                da.Fill(ds, "Contractor");
                da.Fill(ds, "Delivery");
                da.Fill(ds, "Storage");
                da.Fill(ds, "Raw");
                da.Fill(ds, "Subtype_raw");
                da.Fill(ds, "Type_raw");
                ReportDocument doc = new ReportDocument();
                doc.Load("Reports/CrystalReport2.rpt");
                doc.SetDataSource(ds);
                crystalReportViewer1.ReportSource = doc;*/
            }
            else if (type == "\'Проведенная обработка\'")
            {
                if (dateS == "" && datePo == "")
                {
                    if (contractor == "")
                    {
                        SqlDataAdapter da = DAO.getInstance().selectProcessing();
                        AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
                        da.Fill(ds, "ProcessReport");
                        ReportDocument doc = new ReportDocument();
                        doc.Load("Reports/ReportProcess.rpt");
                        doc.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = doc;
                    }
                    else
                    {                       
                        SqlDataAdapter da = DAO.getInstance().selectProcessReportContractor(contractor, subdivision);
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
                        SqlDataAdapter da = DAO.getInstance().selectProcessReportWithPeriod(dateS, datePo);
                        AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
                        da.Fill(ds, "ProcessReportWithPeriod");
                        ReportDocument doc = new ReportDocument();
                        doc.Load("Reports/ProcessReportWithPeriod.rpt");
                        doc.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = doc;
                    }
                    else
                    {
                        SqlDataAdapter da = DAO.getInstance().selectProcessReportContractorWithPeriod(contractor, subdivision, dateS, datePo);
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
