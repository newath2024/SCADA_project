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
   
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlConn = "Server = HUNG\\WINCC;Database=CSDL_SCADA;User Id = iot2022a;pwd=888888888";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        string matkhau;
        string quyentruycap;
        string str1 = "Admin";
        string str2 = "Operator";
        private void btnLogin_Click(object sender, EventArgs e)
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
            command.CommandText = "Select * from Login where ID = @id" ;
            command.Connection = conn;
            SqlParameter parID = new SqlParameter("@ID", SqlDbType.NVarChar);
            parID.Value = txtUsername.Text;
            command.Parameters.Add(parID);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                matkhau = reader.GetString(1);
                quyentruycap = reader.GetString(2);
            }
            if (txtPassword.Text == matkhau) 
            {

                if (quyentruycap == str1)
                {
                    MessageBox.Show("Chào mừng admin");
                    DialogResult = DialogResult.OK;
                    check.is_admin = true;

                }
                if (quyentruycap == str2)
                {
                    MessageBox.Show("Chào mừng Operator");
                    DialogResult = DialogResult.OK;
                    check.is_admin = false;
                    
                    


                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu, vui lòng thử lại");
            }
            conn.Close();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
