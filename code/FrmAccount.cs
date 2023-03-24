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
    public partial class FrmAccount : Form
    {
        public FrmAccount()
        {
            InitializeComponent();
        }
        private void FrmAccount_Load(object sender, EventArgs e)
        {
            string[] items = { "Admin", "Operator" };
            cbQuyenTruyCap.Items.AddRange(items);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection conn = null; // kết nối sql sever
        string sqlConn = "Server = HUNG\\WINCC;Database=CSDL_SCADA;User Id = iot2022a;pwd=888888888";
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPass.Text != txtPass2.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
            }
            else
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
                string sql = "Insert into Login(ID,Password,QuyenTruyCap,Name,Sdt,Email,ChucVu) values (@ID,@Password,@QuyenTruyCap,@Name,@Sdt,@Email,@ChucVu)";

                command.CommandText = sql;
                command.Connection = conn;
                //Thêm giá trị vào bảng

                command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtID.Text;
                command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtPass.Text;
                command.Parameters.Add("@QuyenTruyCap", SqlDbType.NVarChar).Value = cbQuyenTruyCap.Text;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtName.Text;
                command.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = txtSdt.Text;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtMail.Text;
                command.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = txtChucVu.Text;


                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("false");
                }
            }
        }
    }
}
