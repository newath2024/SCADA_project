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
    public partial class FrmMAC : Form
    {
        public FrmMAC()
        {
            InitializeComponent();
        }

        private void FrmMAC_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
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
            command.CommandText = "select * from MAC";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            lvMAC.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0));
                lvi.SubItems.Add(reader.GetInt32(1) + "");
                lvi.SubItems.Add(reader.GetInt32(2) + "");
                lvi.SubItems.Add(reader.GetInt32(3) + "");
                lvi.SubItems.Add(reader.GetInt32(4) + "");
                lvi.SubItems.Add(reader.GetInt32(5) + "");

                lvMAC.Items.Add(lvi);

            }
            reader.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection conn = null; // kết nối sql sever
        string sqlConn = "Server = HUNG\\WINCC;Database=CSDL_SCADA;User Id = iot2022a;pwd=888888888";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
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
                string sql = "Insert into MAC(MaDonHang,TroKhoang,CatKho,PhuGia1,PhuGia2,XiMang) values (@MaDonHang,@TroKhoang,@CatKho,@PhuGia1,@PhuGia2,@XiMang)";

                command.CommandText = sql;
                command.Connection = conn;
                //Check điều kiện 
                int a = int.Parse(txtTroKhoang.Text);
                int b = int.Parse(txtCatKho.Text);
                int c = int.Parse(txtPhuGia1.Text);
                int d = int.Parse(txtPhuGia2.Text);
                int f = int.Parse(txtXiMang.Text);

                if (a > 0 && b > 0 && c > 0 && d > 0 && f > 0 && a < 300 && b < 300 && c < 300 && d < 300 && f < 300)
                {
                    //Thêm giá trị vào bảng
                    command.Parameters.Add("@MaDonHang", SqlDbType.NVarChar).Value = txtMAC.Text;
                    command.Parameters.Add("@TroKhoang", SqlDbType.Int).Value = txtTroKhoang.Text;
                    command.Parameters.Add("@CatKho", SqlDbType.Int).Value = txtCatKho.Text;
                    command.Parameters.Add("@PhuGia1", SqlDbType.Int).Value = txtPhuGia1.Text;
                    command.Parameters.Add("@PhuGia2", SqlDbType.Int).Value = txtPhuGia2.Text;
                    command.Parameters.Add("@XiMang", SqlDbType.Int).Value = txtXiMang.Text;
                }
                else
                {
                    MessageBox.Show("Giá trị nhập vào cần nhỏ hơn 300");
                }




                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("false");
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Lỗi :\n" + ex.Message);
            }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
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
            string sql = "delete from MAC where MaDonHang = @MaDonHang";
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@MaDonHang", SqlDbType.NVarChar).Value = txtMAC.Text;
            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Xóa thành công");
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Xóa chưa thành công");

            }
        }
    }
}
