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
    public partial class FrmWarning : Form
    {
        public FrmWarning()
        {
            InitializeComponent();
        }
        SqlConnection conn = null; // kết nối sql sever
        string sqlConn = "Server = HUNG\\WINCC;Database=CSDL_SCADA;User Id = iot2022a;pwd=888888888";
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
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
            command.CommandText = "select * from CanhBao";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            lvCanhBao.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetDateTime(0) + "");
                lvi.SubItems.Add(reader.GetInt32(1) + "");
                lvi.SubItems.Add(reader.GetString(2));
                lvi.SubItems.Add(reader.GetString(3));


                lvCanhBao.Items.Add(lvi);

            }
            reader.Close();
        }
        private void FrmWarning_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
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
            command.CommandText = "select * from CanhBao where NgayThang >= @StartDate and NgayThang <= @EndDate";
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
                lvi.SubItems.Add(reader.GetString(3));


                lvCanhBao.Items.Add(lvi);
                
            }
            reader.Close();

        }
    }
}
