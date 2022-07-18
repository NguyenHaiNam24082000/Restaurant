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
    public partial class FormPanelChart : Form
    {
        ConnectDataBase connect = new ConnectDataBase();
        public FormPanelChart()
        {
            InitializeComponent();
        }

        private void FormPanelChart_Load(object sender, EventArgs e)
        {   
            //  dataGridView1.DataSource = connect.readData("select * from  dbo.ThongKeMonAn(2020)");
            comboBoxNam.Enabled = false;
            comboBoxThang.Enabled = false;
        }

        private void checkChiTiet_Click(object sender, EventArgs e)
        {
            if(checkNam.Checked==true)
            {
                comboBoxNam.Enabled = true;
            }
            else
            {
                comboBoxNam.Enabled = false;
                comboBoxNam.Text = "";
            }
            if (checkThang.Checked == true)
            {
                comboBoxThang.Enabled = true;
            }
            else
            {
                comboBoxThang.Enabled = false;
                comboBoxThang.Text = "";
            }
        }

        private void comboBoxNam_TextChanged(object sender, EventArgs e)
        {
            if (checkNam.Checked == true && comboBoxNam.Text != "")
            {
                dataGridView1.DataSource = connect.readData("select * from  dbo.ThongKeMonAn(" + Convert.ToInt32(comboBoxNam.Text) + ")");
            }
        }

        private void comboBoxThang_TextChanged(object sender, EventArgs e)
        {
            if (checkNam.Checked == true && checkThang.Checked == true && comboBoxNam.Text != "" && comboBoxThang.Text != "")
            {
                string sql = "select ChiTietPhieuDB.MaMonAn , TenMonAn, ";
                for (int i = 0; i < DateTime.DaysInMonth(Convert.ToInt32(comboBoxNam.Text), Convert.ToInt32(comboBoxThang.Text)); ++i)
                {
                    sql += " SUM(IIF(Day(NgayKetThuc) = " + (i + 1) + ", ChiTietPhieuDB.Soluong, 0)) as '" + (i + 1) + "' , ";
                }
                sql += " SUM(ChiTietPhieuDB.Soluong) as N'Thang" + comboBoxThang.Text + "' ";
                sql += " from PhieuDatBan ";
                sql += " join ChiTietPhieuDB on PhieuDatBan.MaPhieu = ChiTietPhieuDB.MaPhieu ";
                sql += " join MonAn on MonAn.MaMonAn = ChiTietPhieuDB.MaMonAn ";
                sql += " where Month(NgayKetThuc) = " + comboBoxThang.Text + " ";
                sql += " group by ChiTietPhieuDB.MaMonAn , TenMonAn ";
                dataGridView1.DataSource = connect.readData(sql);
            }
        }

        private void comboBoxMonAn_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = null;
            comboBoxNam.Enabled = false;
            comboBoxThang.Enabled = false;
            comboBoxNam.Text = "";
            comboBoxThang.Text = "";
            checkNam.Checked = false;
            checkThang.Checked = false;
        }
    }
}
