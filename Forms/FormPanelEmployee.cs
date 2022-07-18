using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.LollipopControls.Controls;
using Restaurant.Classes;
using FontAwesome.Sharp;

namespace Restaurant.Forms
{
    public partial class FormPanelEmployee : Form
    {
        ConnectDataBase connectDataBase = new ConnectDataBase();
        DataTable dataTable = null;
        bool isPlus = false;
        string linkAnh = "";
        public FormPanelEmployee()
        {
            InitializeComponent();
        }

        private void FormPanelEmployee_Load(object sender, EventArgs e)
        {
            addCardEmployee("select MaNV,HoTenNV,AnhNV,TinhTrang from NhanVien");
        }

        private void addCardEmployee(string selectSQL)
        {
            panelDisplayEmployee.Controls.Clear();
            dataTable = connectDataBase.readData(selectSQL);
            for (int i = 0; i < dataTable.Rows.Count; ++i)
            {
                panelDisplayEmployee.Controls.Add(cardEmployee(dataTable.Rows[i].ItemArray[0].ToString(), dataTable.Rows[i].ItemArray[1].ToString(), dataTable.Rows[i].ItemArray[2].ToString(), dataTable.Rows[i].ItemArray[3].ToString()));
            }
            if (dataTable.Rows.Count * 50 > panelDisplayEmployee.Height)
            {
                panelDisplayEmployee.AutoScroll = false;
                panelDisplayEmployee.VerticalScroll.Enabled = false;
                panelDisplayEmployee.VerticalScroll.Visible = false;
                panelDisplayEmployee.VerticalScroll.Maximum = 0;
                panelDisplayEmployee.HorizontalScroll.Visible = false;
                panelDisplayEmployee.AutoScroll = true;
            }
            this.toolTip.SetToolTipTitle(buttonAvatar, "Chọn ảnh nhân viên");
        }
        private ZeroitLollipopSmallCard cardEmployee(string maNV,string tenNV,string link,string tt)
        {
            ZeroitLollipopSmallCard card = new ZeroitLollipopSmallCard();
            card.AllowTransparency = true;
            card.ForeColor = System.Drawing.Color.Black;
            card.Image = Image.FromFile(Application.StartupPath+ "\\Images\\Employee\\"+link);
            this.toolTip.SetToolTipImage(card, card.Image);
            card.Info = tt;  
            card.Name = maNV;
            card.Size = new System.Drawing.Size(215, 50);
            card.Text = tenNV;
            card.ThumbnailColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            card.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            card.Cursor = System.Windows.Forms.Cursors.Hand;
            card.Click += new System.EventHandler(this.card_Click);
            return card; 
        }
        private void card_Click(object sender, EventArgs e)
        {
            buttonAvatar.IconChar = IconChar.None;
            buttonSave.Enabled = true;
            buttonDelete.Enabled = true;
            buttonFind.Enabled = false;
            DataTable dt = connectDataBase.readData("select * from NhanVien where MaNV=N'"+ ((ZeroitLollipopSmallCard)sender).Name + "'");
            buttonAvatar.ImageLocation = Application.StartupPath + "\\Images\\Employee\\" + dt.Rows[0]["AnhNV"].ToString();
            buttonAvatar.Visible = true;
            if (buttonAvatar.ImageLocation != "")
            {
                this.toolTip.SetToolTipImage(buttonAvatar, Image.FromFile(buttonAvatar.ImageLocation));
            }
            labelHoTen.Text = dt.Rows[0]["HoTenNV"].ToString();
            labelHoTen.Visible = true;
            labelMaNV.Text = dt.Rows[0]["MaNV"].ToString();
            labelMaNV.Visible = true;
            textMaNV.Text = dt.Rows[0]["MaNV"].ToString();
            textTenNV.Text = dt.Rows[0]["HoTenNV"].ToString();
            textMaNV.Text = dt.Rows[0]["MaNV"].ToString();
            textCMT.Text = dt.Rows[0]["CMT"].ToString();
            textSDT.Text = dt.Rows[0]["SDT"].ToString();
            textDC.Text = dt.Rows[0]["DiaChi"].ToString();
            textQQ.Text = dt.Rows[0]["QueQuan"].ToString();
            if (Convert.ToBoolean(dt.Rows[0]["GioiTinh"].ToString()) == false)
            {
                comboBoxGT.Text = "Nam";
            }
            else comboBoxGT.Text = "Nữ";
            comboBoxTT.Text = dt.Rows[0]["TinhTrang"].ToString();
            if (dt.Rows[0]["TinhTrang"].ToString().ToUpper().Equals("Thôi việc".ToUpper()))
            {
                labelNgayKetThuc.Visible = true;
                dateTimeNgayKT.Visible = true;
                dateTimeNgayKT.Value = Convert.ToDateTime(dt.Rows[0]["NgayKetThuc"].ToString());
            }
            else
            {
                labelNgayKetThuc.Visible = false;
                dateTimeNgayKT.Visible = false;
            }    
            dateTimeNS.Value= Convert.ToDateTime(dt.Rows[0]["NgaySinh"].ToString());
            dateTimeNgayBatDau.Value = Convert.ToDateTime(dt.Rows[0]["NgayBatDau"].ToString());
        }

        private void buttonAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath + "\\Images\\Employee";
            if (MessageBox.Show("Bạn có muôn thay ảnh?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    linkAnh = "";
                    string link = openFileDialog.FileName;
                    string[] subLink = link.Split('\\');
                    linkAnh = subLink[subLink.Length - 1];
                    buttonAvatar.ImageLocation = Application.StartupPath + "\\Images\\Employee\\" + linkAnh;
                }
            }
        }

        private void textBoxChange_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonAvatar.Visible = true;
            buttonAvatar.ImageLocation = "";
            buttonCancel_Click(sender, e);
            buttonAvatar.IconChar = IconChar.UserAlt;
            buttonAvatar.Visible = true;
            buttonSave.Enabled = true;
            comboBoxTT.Items.Clear();
            comboBoxTT.Text = "Đang làm";
            comboBoxTT.Items.Add("Đang làm");
            buttonFind.Enabled = false;
            labelHoTen.Visible = true;
            labelMaNV.Visible = true;
            textMaNV.Text = AutoId.getID("NV", 6, "select * from NhanVien");
            isPlus = true;
        }

        private void textNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') || Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9')) && Convert.ToInt16(e.KeyChar) != 8)
            {
                FormAlert formAlert = new FormAlert();
                formAlert.showAlert("Bạn chỉ được nhập số!", IconChar.ExclamationCircle, Color.Red);
                e.Handled = true;
            }
        }

        private void dateTimeChange_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connectDataBase.dataChange("Delete from NhanVien where MaNV=N'" + textMaNV.Text + "'");
                buttonCancel_Click(sender, e);
                addCardEmployee("select MaNV,HoTenNV,AnhNV,TinhTrang from NhanVien");
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if(textTenNV.Text=="" && textSDT.Text=="" && textCMT.Text=="" && textDC.Text=="" && textQQ.Text=="" && comboBoxGT.Text=="" && comboBoxTT.Text=="")
            {
                addCardEmployee("select MaNV,HoTenNV,AnhNV,TinhTrang from NhanVien");
            }   
            else
            {
                string sql = "select MaNV,HoTenNV,AnhNV,TinhTrang from NhanVien where MaNV is not null ";
                if (textTenNV.Text != "")
                {
                    sql += " and HoTenNV like N'%" + textTenNV.Text + "%' ";
                }
                if (textSDT.Text != "")
                {
                    sql += " and SDT like N'%" + textSDT.Text + "%' ";
                }
                if (textCMT.Text != "")
                {
                    sql += " and CMT like N'%" + textCMT.Text + "%' ";
                }
                if (textDC.Text != "")
                {
                    sql += " and DiaChi like N'%" + textDC.Text + "%' ";
                }
                if (textQQ.Text != "")
                {
                    sql += " and QueQuan like N'%" + textQQ.Text + "%' ";
                }
                if (comboBoxGT.Text != "")
                {
                    if(comboBoxGT.SelectedItem.ToString()=="Nam")
                    {
                        sql += " and GioiTinh = '" + false + "' ";
                    }   
                    else sql += " and GioiTinh = '" + true + "' ";
                }
                if (comboBoxTT.Text != "")
                {
                    sql += " and TinhTrang = N'" + comboBoxTT.Text + "' ";
                }
                addCardEmployee(sql);
            }    
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            foreach(Control control in tabTT.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }    
                if(control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }    
                
            }
            comboBoxGT.Items.Clear();
            comboBoxGT.Text = "";
            comboBoxGT.Items.Add("Nam");
            comboBoxGT.Items.Add("Nữ");
            comboBoxTT.Items.Clear();
            comboBoxTT.Text = "";
            comboBoxTT.Items.Add("Thôi việc");
            comboBoxTT.Items.Add("Đang làm");
            labelNgayKetThuc.Visible = false;
            dateTimeNgayKT.Visible = false;
            buttonAvatar.Visible = false;
            labelHoTen.Visible = false;
            labelMaNV.Visible = false;
            buttonSave.Enabled = false;
            buttonDelete.Enabled = false;
            buttonFind.Enabled = true;
        }

        private void comboBoxTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTT.Text.ToUpper().ToString().Equals("Thôi Việc".ToUpper()))
            {
                labelNgayKetThuc.Visible = true;
                dateTimeNgayKT.Visible = true;
            }    
            else
            {
                labelNgayKetThuc.Visible = false;
                dateTimeNgayKT.Visible = false;
            }    
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textTenNV.Text == "" || textSDT.Text == "" || textCMT.Text == "" || textDC.Text == "" || textQQ.Text == "" || comboBoxGT.Text == "" || comboBoxTT.Text == "" ||buttonAvatar.ImageLocation == "")
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin");
            }
            else
            {
                if (isPlus == true)
                {                    
                    buttonAvatar.Enabled = true;
                    buttonAvatar.ImageLocation = "";
                    connectDataBase.dataChange("insert into NhanVien(MaNV, HoTenNV, GioiTinh, DiaChi, QueQuan, SDT, CMT, NgayBatDau, NgaySinh, TinhTrang, AnhNV) values(N'" + textMaNV.Text + "'" +
                        ",N'" + textTenNV.Text + "',iif(N'" + comboBoxGT.Text + "'=N'Nam',0,1),N'" + textDC.Text + "',N'" + textQQ.Text + "',N'" + textSDT.Text + "',N'" + textCMT.Text + "',cast(N'" + dateTimeNgayBatDau.Value.ToString("yyyy-MM-dd") + "' as Date)," +
                        "cast(N'" + dateTimeNS.Value.ToString("yyyy-MM-dd") + "' as Date),N'"+comboBoxTT.Text+"',N'"+linkAnh+"')");
                   
                }
                else
                {
                    string link = buttonAvatar.ImageLocation;
                    string[] subLink = link.Split('\\');
                    linkAnh = subLink[subLink.Length - 1];
                    if(dateTimeNgayKT.Visible==true)
                    {
                        connectDataBase.dataChange("update NhanVien set HoTenNV = N'" + textTenNV.Text + "',GioiTinh = iif(N'" + comboBoxGT.Text + "'=N'Nam',0,1),DiaChi = N'" + textDC.Text + "',QueQuan = N'" + textQQ.Text + "',SDT = N'" + textSDT.Text + "',CMT = N'" + textCMT.Text + "',NgayBatDau = cast(N'" + dateTimeNgayBatDau.Value.ToString("yyyy-MM-dd") + "' as Date)," +
                        "NgaySinh = cast(N'" + dateTimeNS.Value.ToString("yyyy-MM-dd") + "' as Date), TinhTrang = N'" + comboBoxTT.Text + "',AnhNV = N'" + linkAnh + "', NgayKetThuc = cast(N'" + dateTimeNgayKT.Value.ToString("yyyy-MM-dd") + "' as Date)  where MaNV=N'" + textMaNV.Text+"'");
                        
                    }
                    else
                    {
                        connectDataBase.dataChange("update NhanVien set HoTenNV = N'" + textTenNV.Text + "',GioiTinh = iif(N'" + comboBoxGT.Text + "'=N'Nam',0,1),DiaChi = N'" + textDC.Text + "',QueQuan = N'" + textQQ.Text + "',SDT = N'" + textSDT.Text + "',CMT = N'" + textCMT.Text + "',NgayBatDau = cast(N'" + dateTimeNgayBatDau.Value.ToString("yyyy-MM-dd") + "' as Date)," +
                       "NgaySinh = cast(N'" + dateTimeNS.Value.ToString("yyyy-MM-dd") + "' as Date), TinhTrang = N'" + comboBoxTT.Text + "',AnhNV = N'" + linkAnh + "',NgayKetThuc = NULL where MaNV=N'" + textMaNV.Text + "'");
                        
                    }
                }
            }
            isPlus = false;
            addCardEmployee("select MaNV,HoTenNV,AnhNV,TinhTrang from NhanVien");
        }

        private void textMaNV_TextChanged(object sender, EventArgs e)
        {
            labelMaNV.Text = textMaNV.Text;
        }

        private void textTenNV_TextChanged(object sender, EventArgs e)
        {
            labelHoTen.Text = textTenNV.Text;
        }
    }
}
