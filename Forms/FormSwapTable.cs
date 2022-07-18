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
    public partial class FormSwapTable : Form
    {
        ConnectDataBase connect = new ConnectDataBase();
        public FormSwapTable()
        {
            InitializeComponent();
        }

        private void comboBoxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxBan.Enabled = true;
            DataTable dt= connect.readData("select * from ThongTinBan where MaPhong = N'" + comboBoxPhong.SelectedValue.ToString() + "'");
            comboBoxBan.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                comboBoxBan.Items.Add(dt.Rows[i]["SoBan"].ToString());
            }
        }

        private void comboBoxPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxPhong_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FormSwapTable_Load(object sender, EventArgs e)
        {
            comboBoxPhong.DataSource = connect.readData("select * from Phong");
            comboBoxPhong.DisplayMember = "TenPhong";
            comboBoxPhong.ValueMember = "MaPhong";
            comboBoxBan.Enabled = true;
            DataTable dt = connect.readData("select * from ThongTinBan where MaPhong = N'" + comboBoxPhong.SelectedValue.ToString() + "'");
            comboBoxBan.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                comboBoxBan.Items.Add(dt.Rows[i]["SoBan"].ToString());
            }
        }
    }
}
