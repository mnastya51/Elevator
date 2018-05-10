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
    public partial class ReportAnalysisCardForm : Form
    {
        public ReportAnalysisCardForm(string id_raw)
        {
            InitializeComponent();
            string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog = D:\НАСТЯ\ДИПЛОМ\ВКРБ Михеева\База данных\AccountOfGrain.MDF; Integrated Security = True";
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            // string s = "Select name_contr, subdivision From Contractor";
            /*string sqlCommand = string.Format("Select * From Contractor c join Delivery d " +
 "on c.id_contractor = d.id_contractor " +
 "where d.id_raw = {0}", id_raw);*/
            string sqlCommand;
            sqlCommand = string.Format("Select * From Contractor c join Delivery d " +
           "on c.id_contractor = d.id_contractor join Storage st on st.id_raw = d.id_raw " +
           "join Raw r on st.id_NameRaw = r.id_NameRaw "+
           "left join Subtype_raw s on s.id_subtype = st.id_subtype " +
           "left join Type_raw t on s.id_type = t.id_type " +
           //"left join Class cl on st.id_class = cl.id_class " +
           //"join Raw q on q.id_NameRaw = t.id_NameRaw " +
           "where d.id_raw = {0}", id_raw);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, connect);

            // SqlDataAdapter da = DAO.getInstance().selectAnalysisCard2(id_raw);
            /*AccountOfGrainDataSet ds = new AccountOfGrainDataSet();
            ds.EnforceConstraints = false;
            da.Fill(ds, "Contractor");
            da.Fill(ds, "Delivery");
            da.Fill(ds, "Storage");
            da.Fill(ds, "Raw");
           da.Fill(ds, "Subtype_raw");
            da.Fill(ds, "Type_raw");
          //  da.Fill(ds, "Class");
           // da.Fill(ds, "PlaceStorage");
           // da.Fill(ds, "Store_raw");
           // da.Fill(ds, "Silage_raw");
          ///  da.Fill(ds, "General_impurities");
         //   da.Fill(ds, "Harmful_impurities");
         //   da.Fill(ds, "Weed_impurities");
         //   da.Fill(ds, "Grain_impurities");
            ReportDocument doc = new ReportDocument();
            doc.Load("Reports/CrystalReport2.rpt");
            //doc.Load("Reports/CardAnalysis.rpt");
            doc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = doc;*/
        }
    }
}
