using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        public Form1()
        {
            InitializeComponent();
            /* AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
             string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog = D:\НАСТЯ\ДИПЛОМ\ВКРБ Михеева\База данных\AccountOfGrain.MDF; Integrated Security = True";

             SqlDataAdapter da = new SqlDataAdapter("Select name_contr, subdivision, goal, date_contr From Contractor join Contract on Contractor.id_contractor = Contract.id_contractor ", connectionString);
             da.Fill(ds);
             ReportDocument myReportDocument = new ReportDocument();

             myReportDocument.Load("Reports/CrystalReport1.rpt");
             myReportDocument.Database.Tables[0].SetDataSource(ds);
             crystalReportViewer1.ReportSource = myReportDocument;
            // crystalReportViewer1.DataBind();*/

            /*string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog = D:\НАСТЯ\ДИПЛОМ\ВКРБ Михеева\База данных\AccountOfGrain.MDF; Integrated Security = True";
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
            string commandText = "Select name_contr From Contractor";
            string commandText2 = "SELECT date_contr from Contract ";
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = connect;
            myCommand.CommandText = commandText;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = myCommand;
            dataAdapter.TableMappings.Add("Table", "Contractor");
            ds.EnforceConstraints = false;
            dataAdapter.Fill(ds, "Contractor");
            SqlCommand myCommand2 = new SqlCommand();
            myCommand2.Connection = connect;
            myCommand2.CommandText = commandText2;
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter();
            dataAdapter2.SelectCommand = myCommand2;
            dataAdapter2.TableMappings.Add("Table", "Contract");
            dataAdapter2.Fill(ds, "Contract");
           /* DataRelation dataRelation;
            DataColumn dataColumn1;
            DataColumn dataColumn2;
            dataColumn1 = ds.Tables["Contractor"].Columns["id_contractor"];
            dataColumn2 = ds.Tables["Contract"].Columns["id_contractor"];
            dataRelation = new DataRelation("r", dataColumn1, dataColumn2);
            ds.Relations.Add(dataRelation);*/

            string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog = D:\НАСТЯ\ДИПЛОМ\ВКРБ Михеева\База данных\AccountOfGrain.MDF; Integrated Security = True";
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
           string s = "select * From Contractor c join Contract t on c.id_contractor = t.id_contractor";
            //SqlDataReader da = sql.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(s, connect);
             AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
            ds.EnforceConstraints = false;
            da.Fill(ds, "Contractor");
            da.Fill(ds, "Contract");
            //da.Fill(ds, "Contract");
            //ds.EnforceConstraints = false;

            /*string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog = D:\НАСТЯ\ДИПЛОМ\ВКРБ Михеева\База данных\AccountOfGrain.MDF; Integrated Security = True";
            SqlConnection connect = new SqlConnection(connectionString);

            ConnectionInfo cr = new ConnectionInfo();
            cr.IntegratedSecurity = true;
            cr.LogonProperties.Add(new NameValuePair2("Data Source", @".\SQLEXPRESS"));
            cr.LogonProperties.Add(new NameValuePair2("Initial Catalog", @"D:\НАСТЯ\ДИПЛОМ\ВКРБ Михеева\База данных\AccountOfGrain.MDF"));

            connect.Open();
            string sql = "Select name_contr, date_contr From Contractor c join Contract t on c.id_contractor = t.id_contractor ";
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            dt.Load(sdr);*/
            //AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
            //da.Fill(ds);
            //DataTable dt = new DataTable();
            // dt.Load(da);
            ReportDocument doc = new ReportDocument();
            doc.Load("Reports/CrystalReport1.rpt");
            doc.SetDataSource(ds);
            /**ReportDocument doc = new ReportDocument();
            doc.Load("Reports/CrystalReport1.rpt");*/
            crystalReportViewer1.ReportSource = doc;
             crystalReportViewer1.Refresh();
        }
    }
}
