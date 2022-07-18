﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.Classes;
using Restaurant.UserControls;
using FontAwesome.Sharp;
using Zeroit.Framework.Metro;
using Restaurant.Forms;

namespace Restaurant.Forms
{
    public partial class FormPanelOrderFoods : Form
    {
        DataTable dataTable = new DataTable();
        ConnectDataBase connectDataBase = new ConnectDataBase();
        bool isNewUserControlFood = true;
        int sum = 0;
        public TabPage tabPageTT = new TabPage();
        public TabPage tabPageChose = new TabPage();
        private bool isLoading=false;
        private int resizeImageWidth = 600;
        private int resizeImageHeight= 400;
        FormTable formTable = new FormTable();
        private bool isSaveBill=false;
        private AutoCompleteStringCollection mySource = new AutoCompleteStringCollection();
        private bool isLoad = false;
        public FormPanelOrderFoods()
        {
            InitializeComponent();
            tabPageTT = tabTTMonAn;
            tabPageChose = tabChonMon;
        }

        public void FormPanelOrderFoods_Load(object sender, EventArgs e)
        {
            textTenNV.Text = FormLogin.tenNV;
            textTenNV.Name= FormLogin.maNV;
            dataTable = connectDataBase.readData("select * from ThongTinMonAn");
            for (int i=0;i<dataTable.Rows.Count;++i)
            {
                panelChooseFoods.Controls.Add(userControlFood(i,(string)dataTable.Rows[i].ItemArray[0], (string)dataTable.Rows[i].ItemArray[1], (int)dataTable.Rows[i].ItemArray[2], (string)dataTable.Rows[i].ItemArray[3],"Thêm món ăn",IconChar.Plus));
                panelInforFoods.Controls.Add(userControlFood(i, (string)dataTable.Rows[i].ItemArray[0], (string)dataTable.Rows[i].ItemArray[1], (int)dataTable.Rows[i].ItemArray[2], (string)dataTable.Rows[i].ItemArray[3], "Xem thông tin", IconChar.Exclamation));
            }
            if (dataTable.Rows.Count / 2 * 250 > panelChooseFoods.Height)
            {
                panelChooseFoods.AutoScroll = false;
                panelChooseFoods.VerticalScroll.Enabled = false;
                panelChooseFoods.VerticalScroll.Visible = false;
                panelChooseFoods.VerticalScroll.Maximum = 0;
                panelChooseFoods.AutoScroll = true;
                panelInforFoods.AutoScroll = false;
                panelInforFoods.VerticalScroll.Enabled = false;
                panelInforFoods.VerticalScroll.Visible = false;
                panelInforFoods.VerticalScroll.Maximum = 0;
                panelInforFoods.AutoScroll = true;
            }
            buttonAll_Click(sender, e);
          //  fillComboBox(comboBoxTenNV, "MaNV", "HoTenNV", "select HoTenNV,MaNV from NhanVien where Tinhtrang=N'Đang làm'", "HoTenNV");
            fillComboBox(comboBoxKM, "MaKM", "TenKM", "select MaKM,TenKM from KhuyenMai where "+labelSum.Text+" between GiaTriBatDau and GiaTriKetThuc and cast('"+DateTime.Now.ToString("yyyy-MM-dd") +"' as date) between NgayBatDau and NgayKetThuc","TenKM");
            fillComboBox(comboBoxSDT, "MaKH", "SDT", "select MaKH,SDT from KhachHang","SDT");
           // fillComboBox(comboBoxEmployee, "MaNV", "MaNV", "select MaNV,HoTenNV from NhanVien where Tinhtrang=N'Đang làm'", "MaNV");
           // AutoId.getID("HDB", 7, "select * from PhieuDatBan");
            //textMaHDB.Text = connectDataBase.readData("select dbo.AutoIDPhieuDatBan()").Rows[0][0].ToString();
        }

        private UserControlFood userControlFood(int nameID,string id,string title,int price,string link,string textButton,IconChar iconChar)
        {
            UserControlFood userControlFood = new UserControlFood();
            userControlFood.Name = id;
                //"userControlFood" + nameID;
            userControlFood.labelTenMonAn.Text = title;
            userControlFood.labelMaMonAn.Text = id;
            userControlFood.labelDonGia.Text = "Giá: " + price;
            userControlFood.pictureMonAn.Image = Image.FromFile(Application.StartupPath +"\\Images\\Foods\\"+ link);
            userControlFood.buttonAdd.Text = textButton;
            userControlFood.buttonAdd.IconChar = iconChar;
            userControlFood.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            return userControlFood;
        }

        private UserControlOrderedFood userControlOrderedFood(string id, string name, int price,int soluong, Image img)
        {
            UserControlOrderedFood userControlOrderedFood = new UserControlOrderedFood();
            userControlOrderedFood.Name = id;
            userControlOrderedFood.labelNameFood.Text = name;
            userControlOrderedFood.labelPrice.Text = ""+price;
            userControlOrderedFood.Dock = DockStyle.Top;
            userControlOrderedFood.textNumber.Name += id;
            userControlOrderedFood.textNumber.Text = soluong + "";
            userControlOrderedFood.number= soluong ;
            userControlOrderedFood.buttonIncrease.Name += id;
            userControlOrderedFood.buttonReduce.Name += id;
            userControlOrderedFood.buttonDelete.Name += id;
            userControlOrderedFood.toolTip.SetToolTipImage(userControlOrderedFood.labelNameFood, (Image)new Bitmap(img, new Size(resizeImageWidth,resizeImageHeight)));
            userControlOrderedFood.toolTip.CustomLocation = new Point(userControlOrderedFood.Location.X - resizeImageWidth - 10, userControlOrderedFood.Location.Y);
            userControlOrderedFood.textNumber.TextChanged += new System.EventHandler(this.textNumber_TextChanged);
            userControlOrderedFood.buttonIncrease.Click += new System.EventHandler(this.buttonIncrease_Click);
            userControlOrderedFood.buttonReduce.Click += new System.EventHandler(this.buttonReduce_Click);
            userControlOrderedFood.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            return userControlOrderedFood;
        }

        private void buttonAdd_Click(object sender,EventArgs e)
        {
            isSaveBill = false;
            if (panelOrderFoods.SelectedTab.Name == tabChonMon.Name)
            {
                isNewUserControlFood = true;
                foreach (UserControlFood userControlFood in panelChooseFoods.Controls)
                {
                    if (userControlFood.Name == ((IconButton)sender).Parent.Name)
                    {
                        foreach (UserControlOrderedFood userControlOrderedFood in panelOrderedFoodsList.Controls)
                        {
                            if (userControlOrderedFood.Name == userControlFood.labelMaMonAn.Text)
                            {
                                userControlOrderedFood.number++;
                                userControlOrderedFood.UserControlOrderedFood_Load(sender, e);
                                isNewUserControlFood = false;
                                break;
                            }
                        }
                        if (isNewUserControlFood == true)
                        {
                            UserControlOrderedFood userControlOrdered = userControlOrderedFood(userControlFood.labelMaMonAn.Text, userControlFood.labelTenMonAn.Text, Convert.ToInt32(userControlFood.labelDonGia.Text.Substring(5)), 1, userControlFood.pictureMonAn.Image);
                            panelOrderedFoodsList.Controls.Add(userControlOrdered);
                        }
                        break;
                    }
                }
                setLabelSum();
            }
            else
            {
                dataGridView1.DataSource = connectDataBase.readData("select * from MonAn where MaMonAn= '" + ((IconButton)sender).Parent.Name + "'");
            }
        }

        private void panelOrderedFoodsList_ControlAdded(object sender, ControlEventArgs e)
        {
            sum = 0;
            if (panelOrderedFoodsList.Controls.Count * 40 > panelOrderedFoodsList.Height)
            {
                panelOrderedFoodsList.AutoScroll = false;
                panelOrderedFoodsList.VerticalScroll.Enabled = false;
                panelOrderedFoodsList.VerticalScroll.Visible = false;
                panelOrderedFoodsList.VerticalScroll.Maximum = 0;
                panelOrderedFoodsList.AutoScroll = true;
            }
        }

        private void panelOrderedFoodsList_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (panelOrderedFoodsList.Controls.Count * 40 < panelOrderedFoodsList.Height)
            {
                //panelOrderedFoodsList.AutoScroll = false;
                //panelOrderedFoodsList.VerticalScroll.Enabled = false;
                //panelOrderedFoodsList.VerticalScroll.Visible = false;
                //panelOrderedFoodsList.VerticalScroll.Maximum = 0;
                panelOrderedFoodsList.AutoScroll = false;
            }
        }

        private void buttonBreadAndNoodle_Click(object sender, EventArgs e)
        {
            setActiveButtonClick(buttonBreadAndNoodle);
            setPanelChooseFoods(buttonBreadAndNoodle.Text);
        }

        private void buttonSeafood_Click(object sender, EventArgs e)
        {
            setActiveButtonClick(buttonSeafood);
            setPanelChooseFoods(buttonSeafood.Text);
        }

        private void buttonVegetable_Click(object sender, EventArgs e)
        {
            setActiveButtonClick(buttonVegetable);
            setPanelChooseFoods(buttonVegetable.Text);
        }

        private void buttonDrinks_Click(object sender, EventArgs e)
        {
            setActiveButtonClick(buttonDrinks);
            setPanelChooseFoods(buttonDrinks.Text);
        }

        private void buttonMeat_Click(object sender, EventArgs e)
        {
            setActiveButtonClick(buttonMeat);
            setPanelChooseFoods(buttonMeat.Text);
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            setActiveButtonClick(buttonAll);
            setPanelChooseFoods("");
        }

        void setActiveButtonClick(IconButton iconButton)
        {
            foreach(Control control in panelFoodsList.Controls)
            {
                if(control is IconButton)
                {
                    control.BackColor = panelFoodsList.BackColor;
                    control.ForeColor = panelFoodsList.ForeColor;
                    ((IconButton)control).IconColor = control.ForeColor;
                }    
            }
            iconButton.BackColor = panelFoodsList.ForeColor;
            iconButton.ForeColor = panelFoodsList.BackColor;
            iconButton.IconColor = iconButton.ForeColor;
        }

        private void textNumber_TextChanged(object sender, EventArgs e)
        {
            foreach (UserControlOrderedFood userControlOrderedFood in panelOrderedFoodsList.Controls)
            {
                if (userControlOrderedFood.textNumber.Name == ((ZeroitMetroTextbox)sender).Name)
                {
                    if (userControlOrderedFood.textNumber.Text != "")
                    {
                        userControlOrderedFood.number = Convert.ToInt32(userControlOrderedFood.textNumber.Text);
                    }
                    else userControlOrderedFood.number = 1;
                    userControlOrderedFood.UserControlOrderedFood_Load(sender, e);
                    break;
                }
            }
            setLabelSum();
        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            isSaveBill = false;
            foreach (UserControlOrderedFood userControlOrderedFood in panelOrderedFoodsList.Controls)
            {
                if (userControlOrderedFood.buttonIncrease.Name == ((IconButton)sender).Name)
                {
                    if (userControlOrderedFood.number < 99)
                    {
                        userControlOrderedFood.number++;
                    }
                   // DataTable dt = connectDataBase.readData("select * from PhieuCheBien where MaMonAn='" + "'");
                    //if()
                    userControlOrderedFood.UserControlOrderedFood_Load(sender, e);
                    break;
                }
            }
            setLabelSum();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            isSaveBill = false;
            sum = Convert.ToInt32(labelSum.Text);
            foreach (UserControlOrderedFood userControlOrderedFood in panelOrderedFoodsList.Controls)
            {
                if (userControlOrderedFood.buttonDelete.Name == ((IconButton)sender).Name)
                {
                    sum -= Convert.ToInt32(userControlOrderedFood.labelSum.Text);
                    labelSum.Text = "" + sum;
                    userControlOrderedFood.Dispose();
                    break;
                }
            }
        }

        private void buttonReduce_Click(object sender, EventArgs e)
        {
            isSaveBill = false;
            foreach (UserControlOrderedFood userControlOrderedFood in panelOrderedFoodsList.Controls)
            {
                if (userControlOrderedFood.buttonReduce.Name == ((IconButton)sender).Name)
                {
                    if (userControlOrderedFood.number > 1)
                    {
                        userControlOrderedFood.number--;
                    }
                    userControlOrderedFood.UserControlOrderedFood_Load(sender, e);
                    break;
                }
            }
            setLabelSum();
        }

        private void setLabelSum()
        {
            sum = 0;
            foreach (UserControlOrderedFood userControlOrderedFood in panelOrderedFoodsList.Controls)
            {
                sum += Convert.ToInt32(userControlOrderedFood.labelSum.Text);
            }
            labelSum.Text = "" + sum;
        }

        private void buttonChooseTable_Click(object sender, EventArgs e)
        {
            formTable = new FormTable();
            formTable.isPlusVisible = false;
            formTable.ShowDialog();
            if (textRoom.Text != formTable.textPhong.Trim() || textNumberTable.Text != formTable.textBan.Trim())
            {
                textNumberTable.Text = formTable.textBan;
                textRoom.Text = formTable.textPhong;
                textNumberTable.Name = formTable.textMaBan;
                panelOrderedFoodsList.Controls.Clear();
                DataTable dataT = connectDataBase.readData(" select ChiTietPhieuDB.MaPhieu,MonAn.MaMonAn,TenMonAn,ChiTietPhieuDB.DonGia,SoLuong,AnhMonAn from PhieuDatBan join ChiTietPhieuDB on PhieuDatBan.MaPhieu=ChiTietPhieuDB.MaPhieu" +
                        " join MonAn on MonAn.MaMonAn=ChiTietPhieuDB.MaMonAn  where MaBan=N'" + formTable.textMaBan + "' and NgayDung <= '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' and NgayKetThuc is null");
                if (dataT.Rows.Count >= 1)
                {
                    labelSum.Text = "0";
                    textMaHDB.Text = dataT.Rows[0].ItemArray[0].ToString();
                    for (int i = 0; i < dataT.Rows.Count; ++i)
                    {
                        UserControlOrderedFood userControlOrdered = userControlOrderedFood(dataT.Rows[i].ItemArray[1].ToString(), dataT.Rows[i].ItemArray[2].ToString(), Convert.ToInt32(dataT.Rows[i].ItemArray[3].ToString()), Convert.ToInt32(dataT.Rows[i].ItemArray[4].ToString()), Image.FromFile(Application.StartupPath + "\\Images\\Foods\\" + dataT.Rows[i].ItemArray[5].ToString()));
                        panelOrderedFoodsList.Controls.Add(userControlOrdered);
                    }
                }
                else
                {
                    textMaHDB.Text = connectDataBase.readData("select dbo.AuToIDPhieuDatBan()").Rows[0][0].ToString();
                }    
                setLabelSum();
            }
        }

        private void buttonPrintBill_Click(object sender, EventArgs e)
        {
            if(isSaveBill == false)
            {
                if(MessageBox.Show("Bạn có muốn lưu dữ liệu?" ,"Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    buttonSave_Click(sender, e);
                    buttonPrintBill_Click(sender, e);
                }    
            }
            else
            {
                // new FormPanelHDB().ShowDialog();
                connectDataBase.dataChange("update PhieuDatBan set NgayKetThuc= cast('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' as DateTime) where MaPhieu = '" + textMaHDB.Text + "'");
                buttonNew_Click(sender, e);
                //connectDataBase.dataChange("update PhieuDatBan set NgayKetThuc= cast('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' as DateTime) where MaPhieu=" + textMaHDB.Text);
            }    
        }

        private void panelOrderedFoodsList_MouseHover(object sender, EventArgs e)
        {
            //label1.Text = sender.ToString();
        }

        private void comboBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') || Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9')) && Convert.ToInt16(e.KeyChar) != 8)
            {
                FormAlert formAlert = new FormAlert();
                formAlert.showAlert("Bạn chỉ được nhập số!", IconChar.ExclamationCircle, Color.Red);
                e.Handled = true;
            }
        }

        private void buttonEggs_Click(object sender, EventArgs e)
        {
            setActiveButtonClick(buttonEggs);
            setPanelChooseFoods(buttonEggs.Text);
        }

        void setPanelChooseFoods(string loai)
        {
            panelChooseFoods.Controls.Clear();
            if (loai != "")
            {
                dataTable = connectDataBase.readData("select * from dbo.XuatTheoLoai(N'" + loai + "')");
                for (int i = 0; i < dataTable.Rows.Count; ++i)
                {
                    panelChooseFoods.Controls.Add(userControlFood(i, (string)dataTable.Rows[i].ItemArray[0], (string)dataTable.Rows[i].ItemArray[1], (int)dataTable.Rows[i].ItemArray[2], (string)dataTable.Rows[i].ItemArray[3], "Thêm món ăn", IconChar.Plus));
                }
            }
            else
            {
                dataTable = connectDataBase.readData("select * from ThongTinMonAn");
                for (int i = 0; i < dataTable.Rows.Count; ++i)
                {
                    panelChooseFoods.Controls.Add(userControlFood(i, (string)dataTable.Rows[i].ItemArray[0], (string)dataTable.Rows[i].ItemArray[1], (int)dataTable.Rows[i].ItemArray[2], (string)dataTable.Rows[i].ItemArray[3], "Thêm món ăn", IconChar.Plus));
                }
            }
        }

        private void fillComboBox(ComboBox comboBox,string textValue,string textDisplay,string sql,string textMySource)
        {
            comboBox.DataSource = connectDataBase.readData(sql);            
            comboBox.ValueMember = textValue;
            comboBox.DisplayMember = textDisplay;
            dataTable.Clear();
            dataTable = connectDataBase.readData(sql);
            for (int i = 0; i < dataTable.Rows.Count; ++i)
            {
                mySource.Add(dataTable.Rows[i][textMySource].ToString());
            }
            comboBox.AutoCompleteCustomSource = mySource;                       
        }

        private void labelSum_TextChanged(object sender, EventArgs e)
        {
            labelThanhTien.Text = labelSum.Text;
            fillComboBox(comboBoxKM, "MaKM", "TenKM", "select MaKM,TenKM from KhuyenMai where " + labelSum.Text + " between GiaTriBatDau and GiaTriKetThuc and cast('" + DateTime.Now.ToString("yyyy-MM-dd") + "' as date) between NgayBatDau and NgayKetThuc", "TenKM");
        }

        private void comboBoxKM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = comboBoxKM.SelectedValue.ToString();
            dataTable = connectDataBase.readData("select GiaTriKM,DVKM from KhuyenMai where MaKM = N'" + text + "'");
            if (dataTable.Rows.Count >= 1)
            {                
                if ("%".Equals(dataTable.Rows[0].ItemArray[1].ToString()))
                {
                    double giamgia = (double)(1.0 - ((Convert.ToInt32(dataTable.Rows[0].ItemArray[0])) / 100.0));
                    labelThanhTien.Text = (Convert.ToInt32(labelSum.Text) * giamgia *1.0).ToString();
                }
                else if ("VND".Equals(dataTable.Rows[0].ItemArray[1].ToString()))
                {
                    labelThanhTien.Text = (Convert.ToInt32(labelSum.Text) - Convert.ToInt32(dataTable.Rows[0].ItemArray[0])) + "";
                }
            }
            else
            {
                return;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            isSaveBill = true;
            if (comboBoxSDT.Text.Length < 10)
            {
                FormAlert formAlert = new FormAlert();
                formAlert.showAlert("Bạn chưa nhập đúng định dạng của số điện thoại!", IconChar.ExclamationCircle, Color.Red);
            }
            else
            {
                if (textRoom.Text != "" && textNumberTable.Text != "" && textTenNV.Text != "" && textMaHDB.Text != "" && comboBoxSDT.Text != "" && textKhachHang.Text != "")
                {
                    dataTable = connectDataBase.readData("select * from KhachHang where SDT=N'" + comboBoxSDT.Text + "'");
                    if (dataTable.Rows.Count == 0)
                    {
                        connectDataBase.dataChange("insert into KhachHang (MaKH,HoTenKH,SDT) values ((select dbo.AutoIDKhachHang()),N'" + textKhachHang.Text + "','" + comboBoxSDT.Text + "')");
                        FormAlert formAlert = new FormAlert();
                        formAlert.showAlert("Đã lưu thành công!", IconChar.CheckCircle, Color.Green);
                        fillComboBox(comboBoxSDT, "MaKH", "SDT", "select MaKH,SDT from KhachHang", "SDT");
                    }
                    dataTable = connectDataBase.readData("select * from KhachHang where SDT=N'" + comboBoxSDT.Text + "'");
                    DataTable dt = connectDataBase.readData("select * from PhieuDatBan where MaPhieu=N'" + textMaHDB.Name + "'");
                    if (dt.Rows.Count == 0)
                    {
                        try
                        {
                            connectDataBase.dataChange("insert into PhieuDatBan (MaPhieu,MaKH,MaNV,MaBan,HoTenNV,NgayDat,NgayDung) values ('" +
                            textMaHDB.Text + "','" + dataTable.Rows[0]["MaKH"] + "','" + textTenNV.Name + "',N'" + textNumberTable.Name + "',N'" + textTenNV.Text + "',cast('" + DateTime.Now.ToString("yyyy-MM-dd") + "' as DateTime),cast('" + DateTime.Now.ToString("yyyy-MM-dd") + "' as DateTime))");
                        }
                        catch (Exception)
                        {

                        }
                            FormAlert formAlert = new FormAlert();
                        formAlert.showAlert("Đã lưu thành công!", IconChar.CheckCircle, Color.Green);
                    }
                        foreach (Control control in panelOrderedFoodsList.Controls)
                        {
                            DataTable dt1 = connectDataBase.readData("select * from ChiTietPhieuDB where MaPhieu=N'" + textMaHDB.Text + "' and MaMonAn = N'"+ ((UserControlOrderedFood)control).Name + "'");
                            if (dt1.Rows.Count == 0)
                            {
                                connectDataBase.dataChange("insert into ChiTietPhieuDB (MaPhieu,MaMonAn,SoLuong,TongTien,DonGia) values (N'" + textMaHDB.Text + "','" + ((UserControlOrderedFood)control).Name + "'," + Convert.ToInt32(((UserControlOrderedFood)control).textNumber.Text) + "" +
                                    ", " + Convert.ToInt32(((UserControlOrderedFood)control).labelSum.Text) + "," + Convert.ToInt32(((UserControlOrderedFood)control).labelPrice.Text) + ")");
                            }
                            else
                            {
                                if(Convert.ToInt32(dt1.Rows[0]["SoLuong"].ToString())!= Convert.ToInt32(((UserControlOrderedFood)control).textNumber.Text))
                                {
                                    connectDataBase.dataChange("update ChiTietPhieuDB set SoLuong = " + Convert.ToInt32(((UserControlOrderedFood)control).textNumber.Text) + " where MaPhieu= N'" + textMaHDB.Text + "' and MaMonAn= '"+ ((UserControlOrderedFood)control).Name + "'");
                                }
                                if (Convert.ToInt32(dt1.Rows[0]["TongTien"].ToString()) != Convert.ToInt32(((UserControlOrderedFood)control).labelSum.Text))
                                {
                                    connectDataBase.dataChange("update ChiTietPhieuDB set TongTien = " + Convert.ToInt32(((UserControlOrderedFood)control).labelSum.Text) + " where MaPhieu= N'" + textMaHDB.Text + "' and MaMonAn= '" + ((UserControlOrderedFood)control).Name + "'");
                            }
                                if (Convert.ToInt32(dt1.Rows[0]["DonGia"].ToString()) != Convert.ToInt32(((UserControlOrderedFood)control).labelPrice.Text))
                                {
                                    connectDataBase.dataChange("update ChiTietPhieuDB set DonGia = " + Convert.ToInt32(((UserControlOrderedFood)control).labelPrice.Text) + " where MaPhieu= N'" + textMaHDB.Text + "' and MaMonAn= '" + ((UserControlOrderedFood)control).Name + "'");
                            }
                        }
                        }
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin");
                }    
            }
        }

        private void comboBoxSDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataTable = connectDataBase.readData("select HoTenKH from KhachHang where MaKH=N'" + comboBoxSDT.SelectedValue.ToString() + "'");
            if (dataTable.Rows.Count >= 1)
            {
                textKhachHang.Text = dataTable.Rows[0].ItemArray[0].ToString();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            labelSum.Text = "0";
            panelOrderedFoodsList.Controls.Clear();
            textRoom.Text = "";
            textNumberTable.Text = "";
            textMaHDB.Text = connectDataBase.readData("select dbo.AutoIDPhieuDatBan()").Rows[0][0].ToString();
        }

        private void comboBoxSDT_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            textMaMon.Text = "";
            textMaMon.Text = AutoId.getID("MonAn", 9, "select * from MonAn");
            textMaMon.Enabled = false;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void buttonThemNL_Click(object sender, EventArgs e)
        {
            foreach(Control control in groupBoxNguyenLieu.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }    
            }    
        }

        private void comboBoxNL_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxNL_Click(object sender, EventArgs e)
        {
            comboBoxNL.DataSource = connectDataBase.readData("select * from NguyenLieu");
            comboBoxNL.DisplayMember = "MaNguyenLieu";
            comboBoxNL.ValueMember = "MaNguyenLieu";
        }

        private void comboBoxNL_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = connectDataBase.readData("select * from NguyenLieu join LoaiNguyenLieu on NguyenLieu.MaLoai=LoaiNguyenLieu.MaLoai where MaNguyenLieu= N'" + comboBoxNL.SelectedValue + "'");
            if (dt.Rows.Count >= 1)
            {
                textTenNL.Text = dt.Rows[0]["TenNguyenLieu"].ToString();
                textDVT.Text = dt.Rows[0]["DVT"].ToString();
                textLoai.Text = dt.Rows[0]["TenLoai"].ToString();
            }
        }
    }
}
