using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.Classes;
using System.Data.SqlClient;

namespace Restaurant
{
    public partial class FormLogin : Form
    {
        public bool quyen = false;
        public bool isSuccess ;
        private int success;
        ConnectDataBase connect=new ConnectDataBase();
        public static string tenNV;
        public static string maNV;
        public string anh = "";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            if(textPassword.UseSystemPasswordChar==true)
            {
                textPassword.UseSystemPasswordChar = false;
                buttonShowPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                buttonShowPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /*SqlConnection connection = new SqlConnection("Data Source=MAYTINH;Initial Catalog=Restaurant;Integrated Security=True");
            connection.Open();
            var cmd = new SqlCommand("KiemTraDangNhap", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = textUser.Text;
            cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = textPassword.Text;
            success = Convert.ToInt32(cmd.Parameters.Add("@ISTRUE", SqlDbType.Int).Value);
            cmd.ExecuteNonQuery();
            connection.Close()*/
            DataTable data = connect.readData("select * from NhanVien where MaNV = '" + textUser.Text + "' and MatKhau like (SELECT CONVERT(NVARCHAR(32),HashBytes('MD5', '" + textPassword.Text + "'),2))");
            if (data.Rows.Count==0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai!", "Thông báo");
            }    
            else
            {
                
                anh = data.Rows[0]["anhNV"].ToString();
                isSuccess = true;
                quyen = Convert.ToBoolean(data.Rows[0]["quyen"].ToString());
                tenNV = data.Rows[0]["HoTenNV"].ToString();
                maNV = data.Rows[0]["MaNV"].ToString();
                this.Hide();
                new FormLoading().ShowDialog();
                this.Dispose();
            }    
        }
    }
}
