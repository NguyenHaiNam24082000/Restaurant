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

namespace Restaurant.Forms
{
    public partial class FormPanelNguyenLieu : Form
    {
        ConnectDataBase cnDB = new ConnectDataBase();
        public FormPanelNguyenLieu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Form2 a = new Form2();
            a.ShowDialog();
            DataTable dtChatLieu = cnDB.readData("select MaNguyenLieu , TenNguyenLieu from resNguyenLieu");
            dgvNgLieu.DataSource = dtChatLieu;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtChatLieu = cnDB.readData("select MaNguyenLieu , TenNguyenLieu from NguyenLieu");
            dgvNgLieu.DataSource = dtChatLieu;

        }

        private void fillNumber(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDonVi.Text == "" || txtNameDetail.Text == "" || cbTypeDetail.SelectedIndex < 0) { MessageBox.Show("Lỗi"); }
                else
                {
                    cnDB.dataChange($"update NguyenLieu set TenNguyenLieu = N'{txtNameDetail.Text}' , MaLoai = '{cbTypeDetail.SelectedValue}' , DVT = '{txtDonVi.Text}' , SoLuong  = '{txtConLai.Text}' , GhiChu = '{txtGhiChu.Text}'  where MaNguyenLieu = '{txtCode.Text}'");
                    DataTable dtChatLieu = cnDB.readData("select MaNguyenLieu , TenNguyenLieu from NguyenLieu");
                    dgvNgLieu.DataSource = dtChatLieu;

                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void change(object sender, EventArgs e)
        {
            /*cbDoiTac.DataSource = cnDB.readData("Select * from DoiTac");
            cbDoiTac.ValueMember = "MaDT"; //Giá trị của phần tử
            cbDoiTac.DisplayMember = "TenDT";//Chuỗi hiển thị của phần tử*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want quit the program ?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void searchType(object sender, EventArgs e)
        {
            cbType.DataSource = cnDB.readData("Select * from LoaiNguyenLieu");
            cbType.ValueMember = "MaLoai"; //Giá trị của phần tử
            cbType.DisplayMember = "TenLoai";//Chuỗi hiển thị của phần tử
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            string query = "select MaNguyenLieu , TenNguyenLieu from resNguyenLieu where MaNguyenLieu is not null";
            try
            {
                if (cbType.SelectedIndex >= 0) query += $" and Loai = '{cbType.SelectedValue.ToString().Trim()}'";
                if (txtName.Text != "") query += $" and TenNguyenLieu = '{txtName.Text}'";
                {

                    DataTable dtChatLieu = cnDB.readData(query);
                    dgvNgLieu.DataSource = dtChatLieu;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FormPanelDoiTac DT = new FormPanelDoiTac();
            DT.ShowDialog();
        }

        private void HienThi(object sender, EventArgs e)
        {
            DataTable dtChatLieu = cnDB.readData("select * from NguyenLieu where MaNguyenLieu = '" + dgvNgLieu.CurrentRow.Cells[0].Value.ToString() + "'");
            txtCode.Text = dgvNgLieu.CurrentRow.Cells[0].Value.ToString();
            txtNameDetail.Text = dgvNgLieu.CurrentRow.Cells[1].Value.ToString();
            txtDonVi.Text = dtChatLieu.Rows[0][2].ToString();
            txtConLai.Text = dtChatLieu.Rows[0][5].ToString();
            txtGhiChu.Text = dtChatLieu.Rows[0][4].ToString();

            cbTypeDetail.DataSource = cnDB.readData("Select * from LoaiNguyenLieu where MaLoai = '" + dtChatLieu.Rows[0]["MaLoai"].ToString() + "'");
            cbTypeDetail.ValueMember = "MaLoai"; //Giá trị của phần tử
            cbTypeDetail.DisplayMember = "TenLoai";//Chuỗi hiển thị của phần tử


            /*cbDoiTac.DataSource = cnDB.readData("Select * from NhaCungCap where MaNCC = '" + dtChatLieu.Rows[0]["DoiTac"].ToString() + "'");
            cbDoiTac.ValueMember = "MaDT"; //Giá trị của phần tử
            cbDoiTac.DisplayMember = "TenDT";//Chuỗi hiển thị của phần tử*/

            txtCode.Enabled = false;
        }

        private void fillType(object sender, EventArgs e)
        {
            cbTypeDetail.DataSource = cnDB.readData("Select * from LoaiNguyenLieu");
            cbTypeDetail.ValueMember = "MaLoai"; //Giá trị của phần tử
            cbTypeDetail.DisplayMember = "TenLoai";//Chuỗi hiển thị của phần tử
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormPanelAdNCC().ShowDialog();
        }
    }
}
