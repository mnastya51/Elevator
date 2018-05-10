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
        public ReportForm(string type, string dateS, string datePo)
        {
            InitializeComponent();
            this.type = type;
            this.dateS = dateS;
            this.datePo = datePo;
            this.Text = "Отчет " + type;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            if (dateS == "" && datePo == "")
            {
                switch (type)
                {
                    case "\'Объем зерна\'":
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

                            break;
                        }
                    case "\'Проведенная обработка\'":
                        {
                            SqlDataAdapter da = DAO.getInstance().selectProcessing(dateS, datePo);
                            AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
                            da.Fill(ds, "ProcessReportContractor");
                            //ds.EnforceConstraints = false;
                            //try
                            //{*/
                            // da.Fill(ds, "Contractor");
                            // da.Fill(ds, "ProcessReport");
                            // da.Fill(ds, "Storage");
                            // da.Fill(ds, "Raw");
                            // da.Fill(ds, "Clearing");
                            //da.Fill(ds, "Drying");
                            /*     }
                                 catch(Exception exc)
                                 {
                                     String s = "sdfsfs";
                                 }
                                 ReportDocument doc = new ReportDocument();*/
                            // doc.Load("Reports/ProcessingReport.rpt");
                            /* doc.Load("Reports/CrystalReport4.rpt");
                             doc.SetDataSource(ds);
                             crystalReportViewer1.ReportSource = doc;
                             //ds.EnforceConstraints = false;*/
                            /*  DAO.getInstance().selectProcessing1(dateS, datePo, da);
                              try
                              {
                                  //da.Fill(ds, "Contractor");
                                  da.Fill(ds, "Delivery");
                                  da.Fill(ds, "Storage");
                                  da.Fill(ds, "Raw");
                                  da.Fill(ds, "Drying");
                              }
                              catch (Exception exc)
                              {
                                  String s = "sdfsfs";
                              }*/
                            /*da.Fill(ds, "Clearing");
                            da.Fill(ds, "Drying");
                            da.Fill(ds, "Contractor");
                            da.Fill(ds, "Delivery");
                            da.Fill(ds, "Storage");   */
                             ReportDocument doc = new ReportDocument();
                             doc.Load("Reports/CrystalReport1.rpt");
                           // doc.Load("Reports/CrystalReport4.rpt");
                            doc.SetDataSource(ds);
                            crystalReportViewer1.ReportSource = doc;
                            break;
                        }
                }
            }
        }
    }  
}
