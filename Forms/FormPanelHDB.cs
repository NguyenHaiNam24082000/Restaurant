using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.UserControls;

namespace Restaurant.Forms
{
    public partial class FormPanelHDB : Form
    {
        public int count;
        public FormCode formCode = new FormCode();
        public FormPanelHDB()
        {
            InitializeComponent();
        }
        //string hdb,phong,ban,gvao,gra,tennv,tenkh,sdtkh,name,sl,dongia,tongtien,
        public void FormPanelHDB_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            formCode.ShowDialog();
        }

        public void addUserControlBillHeader(string hdb,string phong,string ban,string gvao,string gra,string tennv,string tenkh,string sdtkh)
        {
            UserControlBillHeader userControlBillHeader = new UserControlBillHeader();
            userControlBillHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            userControlBillHeader.Dock = System.Windows.Forms.DockStyle.Top;
            userControlBillHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            userControlBillHeader.Name = "userControlBillHeader";
            userControlBillHeader.QRCodeText = "Restaurant";
            userControlBillHeader.Size = new System.Drawing.Size(360, 325);
            userControlBillHeader.labelBillNumber.Text = "Số HĐ: " + hdb;
            userControlBillHeader.labelRoomNumber.Text = "Phòng: " + phong;
            userControlBillHeader.labelTableNumber.Text = "Bàn: " + ban;
            userControlBillHeader.labelTimeIn.Text = "G.vào: " + gvao;
            userControlBillHeader.labelTimeOut.Text = "Giờ ra: " + gra;
            userControlBillHeader.labelNameEmployee.Text = "Tên NV: " + tennv;
            userControlBillHeader.labelNameCustomer.Text = "Tên KH: " + tenkh;
            userControlBillHeader.labelPhoneCustomer.Text = "SĐT KH: " + sdtkh;
            panelHDBPreview.Controls.Add(userControlBillHeader);
        }

        public void addUserControlListFood(string name,string sl,string dongia,string tongtien)
        {
            UserControlListFoodHDB userControlListFood = new UserControlListFoodHDB();
            userControlListFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            userControlListFood.Dock = System.Windows.Forms.DockStyle.Top;
            userControlListFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            userControlListFood.Name = "userControlBillFooter";
            userControlListFood.Size = new System.Drawing.Size(360, 40);
            userControlListFood.labelTenMonAn.Text = name;
            userControlListFood.labelSoLuong.Text = sl;
            userControlListFood.labelDonGia.Text = dongia;
            userControlListFood.labelTongTien.Text = tongtien;
            panelHDBPreview.Controls.Add(userControlListFood);
        }

        public void addUserControlBillFooter(string tong,string km,string thanhtien)
        {
            UserControlBillFooter userControlBillFooter = new UserControlBillFooter();
            userControlBillFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            userControlBillFooter.BarcodeText = "8934602001078";
            userControlBillFooter.Dock = System.Windows.Forms.DockStyle.Top;
            userControlBillFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            userControlBillFooter.Name = "userControlBillFooter";
            userControlBillFooter.Size = new System.Drawing.Size(360, 223);
            userControlBillFooter.label2.Text = tong;
            userControlBillFooter.label6.Text = km;
            userControlBillFooter.label8.Text = thanhtien;
            panelHDBPreview.Controls.Add(userControlBillFooter);
        }

        private void userControlBillHeader_Load(object sender, EventArgs e)
        {
                    }
    }
}
