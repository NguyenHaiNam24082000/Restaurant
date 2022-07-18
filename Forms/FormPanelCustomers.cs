using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Restaurant.Classes;

namespace Restaurant.Forms
{
    public partial class FormPanelCustomers : Form
    {
        ConnectDataBase connect = new ConnectDataBase();
        public FormPanelCustomers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtkhachhang = connect.readData("select *from KhachHang");
            dgvdanhsach.DataSource = dtkhachhang;
            txbmakhachhang.Enabled = false;
            txbgioitinh.Enabled = false;
            txbtenkhachhang.Enabled = false;
            txbloaikhachhang.Enabled = false;
            txbsodienthoaikhachhang.Enabled = false;

            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void dgvdanhsach_Click(object sender, EventArgs e)
        {
            txbmakhachhang.Text = dgvdanhsach.CurrentRow.Cells[0].Value.ToString();
            txbtenkhachhang.Text = dgvdanhsach.CurrentRow.Cells[1].Value.ToString();
            txbgioitinh.Text = dgvdanhsach.CurrentRow.Cells[2].Value.ToString();
            txbsodienthoaikhachhang.Text = dgvdanhsach.CurrentRow.Cells[3].Value.ToString();
            txbloaikhachhang.Text = dgvdanhsach.CurrentRow.Cells[4].Value.ToString();

            txbnhapmakhachhang.Text = dgvdanhsach.CurrentRow.Cells[0].Value.ToString();
            txbnhaptenkhachhang.Text = dgvdanhsach.CurrentRow.Cells[1].Value.ToString();
            cmbgioitinhkhachhang.Text = dgvdanhsach.CurrentRow.Cells[2].Value.ToString();
            txbnhapsodienthoai.Text = dgvdanhsach.CurrentRow.Cells[3].Value.ToString();
            txbnhaploaikhachhang.Text = dgvdanhsach.CurrentRow.Cells[4].Value.ToString();

            btnxoa.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txbnhapmakhachhang.Text == "" || txbnhaptenkhachhang.Text == "" || txbnhapsodienthoai.Text == "" || txbnhaploaikhachhang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin khách hàng");
            }
            else
            {
                string s = @"((09|03|07|08|05|849|843|847|848|845)+([0-9]{8})\b)";
                Regex rg = new Regex(s);
                DataTable dtkhachhang = connect.readData("select *from KhachHang where " + "MaKH='" + (txbnhapmakhachhang.Text).Trim() + "'");
                if (dtkhachhang.Rows.Count > 0)
                {
                    MessageBox.Show("Mã khách hàng này đã có rồi!");
                    return;
                }
                if (!rg.IsMatch(txbnhapsodienthoai.Text))
                {
                    MessageBox.Show("Xin nhập lại đúng số điện thoại");
                }
                else
                {
                    connect.dataChange($"insert into KhachHang values ( N'{txbnhapmakhachhang.Text}',N'{txbnhaptenkhachhang.Text}',N'{cmbgioitinhkhachhang.Text}','{txbnhapsodienthoai.Text}','{txbnhaploaikhachhang.Text}')");
                    dgvdanhsach.DataSource = connect.readData("select *from KhachHang");
                }
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chất liệu  không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                  System.Windows.Forms.DialogResult.Yes)
            {
                connect.dataChange("delete KhachHang where MaKH = '" + txbnhapmakhachhang.Text + "'");
                dgvdanhsach.DataSource = connect.readData("select *from KhachHang");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txbnhapmakhachhang.Text == "" || txbnhaptenkhachhang.Text == "" || txbnhapsodienthoai.Text == "" || txbnhaploaikhachhang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin khách hàng");
            }
            else
            {
                connect.dataChange($"update KhachHang set HoTenKH=N'{txbnhaptenkhachhang.Text}',GioiTinh=N'{cmbgioitinhkhachhang.Text}',SDT='{txbnhapsodienthoai.Text}',QuanHe = '{txbnhaploaikhachhang.Text}' where MaKH = '{txbnhapmakhachhang.Text}'");
                dgvdanhsach.DataSource = connect.readData("select *from KhachHang");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thôngbáo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == System.Windows.Forms.DialogResult.Yes)
            {

                this.Close();
            }

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = "select *from KhachHang where MaKH is not null ";
            if (txbnhapmakhachhang.Text != "")
            {
                timkiem += $"and MaKH = '{txbnhapmakhachhang.Text}' ";
            }
            if (txbnhaptenkhachhang.Text != "")
            {
                timkiem += $"and HoTenKH = N'{txbnhaptenkhachhang.Text}' ";
            }
            if (txbnhapsodienthoai.Text != "")
            {
                timkiem += $"and SDT = '{txbnhapsodienthoai.Text}' ";
            }
            if (txbnhaploaikhachhang.Text != "")
            {
                timkiem += $"and QuanHe = '{txbnhaploaikhachhang.Text}' ";
            }

            dgvdanhsach.DataSource = connect.readData(timkiem);
        }
    }
}
