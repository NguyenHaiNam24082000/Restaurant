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
using System.Text.RegularExpressions;

namespace Restaurant.Forms
{
    public partial class FormPanelAdNCC : Form
    {
        ConnectDataBase cnDB = new ConnectDataBase();
        public FormPanelAdNCC()
        {
            InitializeComponent();
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "" || txtSoDienThoai.Text == "" || txtDiaChi.Text == "" || txtThue.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                string s = @"((09|03|07|08|05|849|843|847|848|845)+([0-9]{8})\b)";
                Regex rg = new Regex(s);
                if (!rg.IsMatch(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại : 09xx , 08xx , 07xx , 05xx , 03xx , 849xx , 848xx , 847xx , 845xx , 843xx");
                }
                else
                {
                    cnDB.dataChange($"insert into NhaCungCap values ('{AutoId.getID("NCC", 8, "select * from NhaCungCap")}' , N'{txtTenNCC.Text}' , N'{txtDiaChi.Text}' , '{txtSoDienThoai.Text}' , '{txtThue.Text}')");
                    MessageBox.Show("Thêm Thành Công");
                }
            }

        }

        private void btnAddExit_Click(object sender, EventArgs e)
        {

        }

        private void txtThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void fillNumber(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
