using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Picturebox
{
    public partial class FrmPrint : Form
    {
        public FrmPrint()
        {
            InitializeComponent();
        }

        private void FrmPrint_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server = HUNG\\WINCC;Database=CSDL_SCADA;User Id = iot2022a;pwd=888888888");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from HoatDong", conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "HoatDong");
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Picturebox.ReportDuLieu.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
