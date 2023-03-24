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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            
        }

        private void mACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMAC frmMAC = new FrmMAC();
            frmMAC.MdiParent = this;
            frmMAC.Show();
        }

        private void cảnhBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWarning frmWarning = new FrmWarning();
            frmWarning.MdiParent = this;
            frmWarning.Show();
        }

        private void dữLiệuSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDuLieu frmDuLieu = new FrmDuLieu();
            frmDuLieu.MdiParent = this;
            frmDuLieu.Show();
        }
        
     

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int calamviec;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (picHdOff.Visible == true)
            {
                picHdOn.Visible = true;
                picHdOff.Visible = false;
                picAutoOff.Visible = true;
                picAutoOn.Visible = false;
                picWarnOff.Visible = true;
                picWarnOn.Visible = false;
            }
            
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (picAutoOff.Visible == true)
            {
                picAutoOn.Visible = true;
                picAutoOff.Visible = false;
                picHdOff.Visible = true;
                picHdOn.Visible = false;
                picWarnOff.Visible = true;
                picWarnOn.Visible = false;
            }
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
            string sql = "Insert into HoatDong(ThoiGian,CaSX,MAC,TroKhoang,CatKho,PhuGia1,PhuGia2,XiMang,MeTron) values (@ThoiGian,@CaSX,@MAC,@TroKhoang,@CatKho,@PhuGia1,@PhuGia2,@XiMang,@MeTron)";


            if (dtpTime.Value.Hour < 8)
            {
                calamviec = 1;
            }
            if (dtpTime.Value.Hour >= 8 && dtpTime.Value.Hour < 16)
            {
                calamviec = 2;
            }
            if (dtpTime.Value.Hour >= 16)
            {
                calamviec = 3;
            }
            int casx1 = calamviec;
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@ThoiGian", SqlDbType.Date).Value = dtpDate.Text;
            command.Parameters.Add("@CaSX", SqlDbType.Int).Value = casx1;
            command.Parameters.Add("@MAC", SqlDbType.NVarChar).Value = cbMAC.Text;
            command.Parameters.Add("@TroKhoang", SqlDbType.Int).Value = txtTroKhoang.Text;
            command.Parameters.Add("@CatKho", SqlDbType.Int).Value = txtCatKho.Text;
            command.Parameters.Add("@PhuGia1", SqlDbType.Int).Value = txtPhuGia1.Text;
            command.Parameters.Add("@PhuGia2", SqlDbType.Int).Value = txtPhuGia2.Text;
            command.Parameters.Add("@XiMang", SqlDbType.Int).Value = txtXiMang.Text;
            command.Parameters.Add("@MeTron", SqlDbType.Int).Value = txtSoMe.Text;

            int ret = command.ExecuteNonQuery();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (picWarnOff.Visible == true)
            {
                picWarnOn.Visible = true;
                picWarnOff.Visible = false;
                picAutoOff.Visible = true;
                picAutoOn.Visible = false;
                picHdOn.Visible = false;
                picHdOff.Visible = true;
            }
            MessageBox.Show("Tạm dừng hệ thống");
        }

        private void cbMAC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }
        SqlConnection conn = null; // kết nối sql sever
        string sqlConn = "Server = HUNG\\WINCC;Database=CSDL_SCADA;User Id = iot2022a;pwd=888888888";
        private void FrmMenu_Load(object sender, EventArgs e)
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
            command.CommandText = "select MaDonHang from MAC";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string item = reader.GetString(0);
                cbMAC.Items.Add(item);
            }
            reader.Close();

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
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
            command.CommandText = "Select * from MAC where MaDonHang= @madonhang" ;
            command.Connection = conn;
            SqlParameter parma = new SqlParameter("madonhang", SqlDbType.NVarChar);
            parma.Value = cbMAC.Text;
            command.Parameters.Add(parma);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtTroKhoang.Text = reader.GetInt32(1) + "";
                txtCatKho.Text = reader.GetInt32(2) + "";
                txtPhuGia1.Text = reader.GetInt32(3) + "";
                txtPhuGia2.Text = reader.GetInt32(4) + "";
                txtXiMang.Text = reader.GetInt32(5) + "";
            }
            reader.Close();
        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrint frmPrint = new FrmPrint();
            frmPrint.MdiParent = this;
            frmPrint.Show();
        }

        private void txtPhuGia1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount();
            frmAccount.MdiParent = this;
            frmAccount.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void thongtintool_Click(object sender, EventArgs e)
        {
            FrmIn4 frmIn4 = new FrmIn4();
            frmIn4.MdiParent = this;
            frmIn4.Show();
        }
    }
}
