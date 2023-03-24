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
namespace Picturebox
{
    public partial class FrmDuLieu : Form
    {
        public FrmDuLieu()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmDuLieu_Load(object sender, EventArgs e)
        {
           // HienThiDuLieu();
        }
        SqlConnection conn = null; // kết nối sql sever
        string sqlConn = "Server = HUNG\\WINCC;Database=CSDL_SCADA;User Id = iot2022a;pwd=888888888";
        private void HienThiDuLieu()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from HoatDong";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            lvDuLieu.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetDateTime(0)+"");
                lvi.SubItems.Add(reader.GetInt32(1) + "");
                lvi.SubItems.Add(reader.GetString(2));
                lvi.SubItems.Add(reader.GetInt32(3) + "");
                lvi.SubItems.Add(reader.GetInt32(4) + "");
                lvi.SubItems.Add(reader.GetInt32(5) + "");
                lvi.SubItems.Add(reader.GetInt32(6) + "");
                lvi.SubItems.Add(reader.GetInt32(7) + "");
                lvi.SubItems.Add(reader.GetInt32(8) + "");


                lvDuLieu.Items.Add(lvi);

            }
            reader.Close();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from HoatDong where ThoiGian >= @StartDate and ThoiGian <= @EndDate";
            command.Connection = conn;
            SqlParameter parStart = new SqlParameter("@StartDate", SqlDbType.Date);
            SqlParameter parEnd = new SqlParameter("@EndDate", SqlDbType.Date);
            parStart.Value = dtpStart.Value.Date;
            parEnd.Value = dtpEnd.Value.Date;

            command.Parameters.Add(parStart);
            command.Parameters.Add(parEnd);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetDateTime(0) + "");
                lvi.SubItems.Add(reader.GetInt32(1) + "");
                lvi.SubItems.Add(reader.GetString(2));
                lvi.SubItems.Add(reader.GetInt32(3) + "");
                lvi.SubItems.Add(reader.GetInt32(4) + "");
                lvi.SubItems.Add(reader.GetInt32(5) + "");
                lvi.SubItems.Add(reader.GetInt32(6) + "");
                lvi.SubItems.Add(reader.GetInt32(7) + "");
                lvi.SubItems.Add(reader.GetInt32(8) + "");




                lvDuLieu.Items.Add(lvi);

            }
            reader.Close();
            
        }
    }
}
