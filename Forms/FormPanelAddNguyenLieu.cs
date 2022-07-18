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
    public partial class FormPanelAddNguyenLieu : Form
    {
        ConnectDataBase cnDB = new ConnectDataBase();
        public FormPanelAddNguyenLieu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void fillNumber(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddDonVi.Text == "" || txtAddName.Text == "" || cbAddType.SelectedIndex < 0) { MessageBox.Show("lỗi"); return; }
                else
                {
                    cnDB.dataChange($"insert into NguyenLieu values('{AutoId.getID("NL", 6, "select * from NguyenLieu")}' , '{txtAddName.Text}' , '{txtAddDonVi.Text}', '{cbAddType.SelectedValue.ToString()}' , N'{txtAddGhiChu.Text}' , '{txtQuantity.Text}')");
                    MessageBox.Show("ok");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }

        private void cbAddType_Click(object sender, EventArgs e)
        {
            cbAddType.DataSource = cnDB.readData("Select * from LoaiNguyenLieu");
            cbAddType.ValueMember = "MaLoai"; //Giá trị của phần tử
            cbAddType.DisplayMember = "TenLoai";//Chuỗi hiển thị của phần tử
        }



        string tusinh()
        {
            DataTable dtChatLieu = cnDB.readData("select MaNguyenLieu , TenNguyenLieu from resNguyenLieu");
            int num = Convert.ToInt32(dtChatLieu.Rows.Count.ToString());
            string oldNum = dtChatLieu.Rows[num - 1]["MaNguyenLieu"].ToString().Substring(2);
            int NumberNum = Convert.ToInt32(oldNum);

            return "NL" + ++NumberNum;
        }

        private void btnAddExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want quit the program ?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void FormPanelAddNguyenLieu_Load(object sender, EventArgs e)
        {

        }
    }
}
