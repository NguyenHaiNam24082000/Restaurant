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
using Restaurant.UserControls;
using Excel = Microsoft.Office.Interop.Excel;

namespace Restaurant.Forms
{
    public partial class FormPanelBill : Form
    {
        public TabPage tabPage = new TabPage();
        ConnectDataBase connectDataBase = new ConnectDataBase();
        FormPanelHDB formPanelHDB = new FormPanelHDB();
        public FormPanelBill()
        {
            InitializeComponent();
            tabPage = tabHDNhap;
            tabBill.TabPages.Remove(tabHDNhap);
        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
           // printPreviewDialog.ShowDialog();
        }

        private void FormPanelBill_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = connectDataBase.readData("select * from PhieuDatBan");
            formPanelHDB.buttonCancel.Enabled = false;
            load_bang();
            btninhoadon.Enabled = false;
        }


        private void buttonTK_Click(object sender, EventArgs e)
        {
            if (textTenNV.Text == "" && textMaPhieu.Text == "" && textMaKH.Text == "" && textMaNV.Text == "" && textTenNV.Text == "" && textBoxTTTu.Text == "" && textBoxTTDen.Text == "" && comboBoxThang.Text == "" && comboBoxNam.Text == "")
            {
                dataGridView.DataSource = connectDataBase.readData("select * from PhieuDatBan");
                //dataGridView.DataSource = connectDataBase.readData("select MaPhieu, HoTenKH, NV.HoTenNV, TenKM, KM.GiaTriKM, KM.Chitiet, MaBan, NgayDat, NgayDung, PDB.NgayKetThuc, ThanhTien from PhieuDatBan as PDB join NhanVien as NV on NV.MaNV = PDB.MaNV join KhuyenMai as KM on KM.MaKM = PDB.MaKM join KhachHang as KH on KH.MaKH = PDB.MaKH");
            }
            else
            {
                string a = "";
                string sql = $"select MaPhieu, HoTenKH, PDB.HoTenNV, TenKM, KM.GiaTriKM, KM.Chitiet, MaBan, NgayDat, NgayDung, PDB.NgayKetThuc, ThanhTien from PhieuDatBan as PDB join NhanVien as NV on NV.MaNV = PDB.MaNV join KhuyenMai as KM on KM.MaKM = PDB.MaKM join KhachHang as KH on KH.MaKH = PDB.MaKH where MaPhieu is not null";
                if (textMaPhieu.Text != "")
                {
                    sql += " and MaPhieu like N'%" + textMaPhieu.Text + "%' ";
                }
                if (textMaKH.Text != "") sql += $"and KH.MaKH like '%{textMaKH.Text}%' ";
                if (textMaNV.Text != "") sql += $"and NV.MaNV like '%{textMaNV.Text}%' ";
                if (textTenNV.Text != "") sql += $"and PDB.HoTenNV like N'%{textTenNV.Text}%' ";

                if (textBoxTTTu.Text != "") sql += $" and ThanhTien >= '{textBoxTTTu.Text}' ";
                if (textBoxTTDen.Text != "") sql += $" and ThanhTien <= '{textBoxTTDen.Text}' ";
                if (comboBoxNam.SelectedIndex >= 0) sql += $" and YEAR(NgayDung) = '{comboBoxNam.SelectedItem.ToString()}' ";
                if (comboBoxThang.SelectedIndex >= 0) sql += $" and MONTH(NgayDung) = '{comboBoxThang.SelectedItem.ToString()}' ";
                //sql += $" and NgayDat = CAST('{dateTimePickerNgDat.Value.ToString("yyyy-MM-dd")}') as NgayDat and NgayDung = CAST('{dateTimePickerNgDung.Value.ToString("yyyy-MM-dd")}') as NgayDung";
                dataGridView.DataSource = connectDataBase.readData(sql);

            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label12.Visible = true;
            textBoxTTDen.Visible = true;
            textBoxTTTu.Visible = true;
            comboBoxNam.Visible = true;
            comboBoxNam.SelectedIndex = -1;
            comboBoxThang.Visible = true;
            comboBoxThang.SelectedIndex = -1;
            textMaPhieu.Text = "";
            textMaKH.Text = "";
            textMaNV.Text = "";
            textTenNV.Text = "";
            dateTimePickerNgDat.Value = DateTime.Now;
            dateTimePickerNgDung.Value = DateTime.Now;

            dataGridView.DataSource =connectDataBase.readData("select * from PhieuDatBan");
        }

        private void panelBillPreview_Paint(object sender, PaintEventArgs e)
        {
            //new PrintPreviewDialog().Show();
        }

        private void FillToAll(object sender, EventArgs e)
        {
            try
            {
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label12.Visible = false;
                textBoxTTDen.Visible = false;
                textBoxTTTu.Visible = false;
                comboBoxNam.Visible = false;
                comboBoxThang.Visible = false;

                DataTable phieudatban = connectDataBase.readData($"select * from PhieuDatBan where MaPhieu = '{dataGridView.CurrentRow.Cells[0].Value.ToString()}'");
                textMaPhieu.Text = phieudatban.Rows[0][0].ToString();
                textMaKH.Text = phieudatban.Rows[0][1].ToString();
                textMaNV.Text = phieudatban.Rows[0][2].ToString();
                textTenNV.Text = phieudatban.Rows[0][3].ToString() != null ? phieudatban.Rows[0][3].ToString() : "";
                dateTimePickerNgDat.Value = Convert.ToDateTime(phieudatban.Rows[0][9].ToString());
                dateTimePickerNgDung.Value = Convert.ToDateTime(phieudatban.Rows[0][10].ToString());
                DataTable dt= connectDataBase.readData($"select * from ChiTietPhieuDB join PhieuDatBan on PhieuDatBan.MaPhieu=ChiTietPhieuDB.MaPhieu join ThongTinBan on ThongTinBan.MaBan = PhieuDatBan.MaBan join Phong on Phong.MaPhong=ThongTinBan.MaPhong join MonAn on ChiTietPhieuDB.MaMonAn=MonAn.MaMonAn  where MaPhieu= '{dataGridView.CurrentRow.Cells[0].Value.ToString()}' ");



            }
            catch(Exception)
            {

            }
        }

        private void fillNumber(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        
        private void dgvdanhsach_Click(object sender, EventArgs e)
        {
            txbmahoadon.Text = dgvdanhsach.CurrentRow.Cells[0].Value.ToString();
            cmbmanhanvien.Text = dgvdanhsach.CurrentRow.Cells[1].Value.ToString();
            txbtennhanvien.Text = dgvdanhsach.CurrentRow.Cells[2].Value.ToString();
            txbmanhacungcap.Text = dgvdanhsach.CurrentRow.Cells[3].Value.ToString();
            dtgngaynhap.Text = dgvdanhsach.CurrentRow.Cells[4].Value.ToString();
            txbkhuyenmai.Text = dgvdanhsach.CurrentRow.Cells[5].Value.ToString();
            txbthanhtien.Text = dgvdanhsach.CurrentRow.Cells[7].Value.ToString();
            txbtennguyenlieu.Text = dgvdanhsach.CurrentRow.Cells[14].Value.ToString();
            cmbnguyenlieu.Text = dgvdanhsach.CurrentRow.Cells[9].Value.ToString();
            txbsoluong.Text = dgvdanhsach.CurrentRow.Cells[10].Value.ToString();
            txbdongia.Text = dgvdanhsach.CurrentRow.Cells[11].Value.ToString();

            btninhoadon.Enabled = true;


        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = "select * from ChiTietHDN,HoaDonNhap where ChiTietHDN.MaHDN is not null and ChiTietHDN.MaHDN = HoaDonNhap.MaHDN";
            if (txbmahoadon.Text != "")
            {
                timkiem += $" and ChiTietHDN.MaHDN ='{txbmahoadon.Text}'";
            }
            dgvdanhsach.DataSource =connectDataBase.readData(timkiem);
        }

        private void btnthemhoadon_Click(object sender, EventArgs e)
        {


            DataTable dtdanhsach =connectDataBase.readData("select *from HoaDonNhap where " + "MaHDN='" + (txbmahoadon.Text).Trim() + "'");
            if (dtdanhsach.Rows.Count > 0)
            {
                connectDataBase.dataChange($"insert into ChiTietHDN values('{txbmahoadon.Text}', '{cmbnguyenlieu.Text}', '{txbsoluong.Text}', '{txbdongia.Text}', '{txbthanhtien.Text}')");
                load_bang();
                MessageBox.Show("Mã hóa đơn này có rồi");
            }
            else
            {
                connectDataBase.dataChange($"insert into HoaDonNhap values ('{txbmahoadon.Text}','{cmbmanhanvien.Text}',N'{txbtennhanvien.Text}','{txbmanhacungcap.Text}','{dtgngaynhap.Value.Date.ToString() }','{txbkhuyenmai.Text}','{txbdnkm.Text}','{txbthanhtien.Text}')");
                connectDataBase.dataChange($"insert into ChiTietHDN values('{txbmahoadon.Text}', '{cmbnguyenlieu.Text}', '{txbsoluong.Text}', '{txbdongia.Text}', '{txbthanhtien.Text}')");

                load_bang();
            }

        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            //Form dữ nguyên

            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1]; //Đưa con trỏ vào ô A1
            tenTruong.Font.Size = 11; //Đặt cỡ chữ là 10

            //Thiết kế

            tenTruong.Font.Name = "Times new roman"; //Chọn font Times new roman

            tenTruong.Font.Bold = true; //Định dạng kiểu font chữ là in đậm

            tenTruong.Font.Color = Color.Blue;  //Màu xanh da trời hoặc
            exSheet.Range["A1"].Font.Color = Color.Blue;
            tenTruong.ColumnWidth = 7;
            exSheet.Range["D1:F1"].Merge(true);     //Nhóm cột C tới E tại hàng 8 thành 1 hàng
            exSheet.Range["B2:H2"].Merge(true);
            exSheet.Range["D3:F3"].Merge(true);
            exSheet.Range["D4:F4"].Merge(true);
            exSheet.Range["D6:F6"].Merge(true);
            exSheet.Range["D8:E8"].Merge(true);
            exSheet.Range["F8:G8"].Merge(true);
            exSheet.Range["A8:B8"].Merge(true);
            for (int i = 1; i <= 10; i++)
                exSheet.Range["C" + i + ":E" + i].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //exSheet.get_Range("A7").Value = "STT";

            exSheet.Range["D1:F1"].Font.Bold = true;
            exSheet.Range["D1:F1"].Value = "NHà HÀNG BA ANH EM";
            exSheet.Range["B2:H2"].Value = "Đc: 1194 ĐƯỜNG LÁNG - LÁNG THƯỢNG - ĐỐNG ĐA - HÀ NỘI";
            exSheet.Range["D3:F3"].Value = "HOTLINE : 0987654321";
            exSheet.Range["D6:F6"].Value = "HÓA ĐƠN NHẬP HÀNG";
            exSheet.Range["A8:B8"].Value = "Ngày";
            exSheet.Range["C8"].Value = "Mã HĐN";
            exSheet.Range["D8:E8"].Value = "Tên NV";
            exSheet.Range["F8:G8"].Value = "Tên Món Ăn";
            exSheet.Range["H8"].Value = "SL";
            exSheet.Range["I8"].Value = "Đơn Giá";
            exSheet.Range["J8"].Value = "Thành Tiền";

            DataTable dt =connectDataBase.readData("select NgayDat , PDB.MaPhieu, HoTenNV , TenMonAn , SoLuong , DonGia , SUM(SoLuong * DonGia) as ThanhTien  from PhieuDatBan as PDB join ChiTietPhieuDB as CT on PDB.MaPhieu = CT.MaPhieu join MonAn as M on M.MaMonAn = CT.MaMonAn group by NgayDat, PDB.MaPhieu, HoTenNV, TenMonAn, SoLuong, DonGia"+
                "where CT.MaHDN = '" + txbmahoadon.Text + "'");

            int dong = dt.Rows.Count;
            for (int i = 1; i <= dong; i++)
            {
                exSheet.Range["A" + (i + 8) + ":B" + (i + 8)].Merge(true);
                exSheet.Range["D" + (i + 8) + ":E" + (i + 8)].Merge(true);
                exSheet.Range["F" + (i + 8) + ":G" + (i + 8)].Merge(true);

                exSheet.Range["A" + (i + 8) + ":B" + (i + 8)].Value = dt.Rows[i - 1]["NgayNhap"].ToString();
                exSheet.Range["C" + (i + 8)].Value = dt.Rows[i - 1]["MaHDN"].ToString();
                exSheet.Range["D" + (i + 8) + ":E" + (i + 8)].Value = dt.Rows[i - 1]["HoTenNV"].ToString();
                exSheet.Range["F" + (i + 8) + ":G" + (i + 8)].Value = dt.Rows[i - 1]["TenMonAn"].ToString();
                exSheet.Range["H" + (i + 8)].Value = dt.Rows[i - 1]["SoLuong"].ToString();
                exSheet.Range["I" + (i + 8)].Value = dt.Rows[i - 1]["DonGia"].ToString();
                exSheet.Range["J" + (i + 8)].Value = dt.Rows[i - 1]["ThanhTien"].ToString();
            }



            //Mở dialog để lưu
            try
            {
                exBook.Activate();
                dlgSaveFile.ShowDialog();
                exBook.SaveAs(dlgSaveFile.FileName.ToString());
                exApp.Quit();
            }
            catch { }
        }
        void load_bang()
        {
            DataTable dthoadon =connectDataBase.readData("select * from HoaDonNhap as HDN join ChiTietHDN as CTN on HDN.MaHDN = CTN.MaHDN join NguyenLieu as NL on CTN.MaNguyenLieu = NL.MaNguyenLieu ");
            dgvdanhsach.DataSource = dthoadon;
            //dgvdanhsach.Columns[4].Visible = false;
            dgvdanhsach.Columns[8].Visible = false;
            dgvdanhsach.Columns[7].Visible = false;
            dgvdanhsach.Columns[6].Visible = false;
            dgvdanhsach.Columns[13].Visible = false;
            dgvdanhsach.Columns[15].Visible = false;
            dgvdanhsach.Columns[16].Visible = false;
            dgvdanhsach.Columns[17].Visible = false;
            dgvdanhsach.Columns[18].Visible = false;

            dgvdanhsach.Columns[0].HeaderText = "Mã hóa đơn";
            dgvdanhsach.Columns[1].HeaderText = "Mã nhân viên";
            dgvdanhsach.Columns[2].HeaderText = "Tên nhân viên";
            dgvdanhsach.Columns[3].HeaderText = "Mã nhà cung cấp";
            dgvdanhsach.Columns[4].HeaderText = "Ngày nhập";
            dgvdanhsach.Columns[5].HeaderText = "Khuyến mại";
            dgvdanhsach.Columns[9].HeaderText = "Mã nguyên liệu";
            dgvdanhsach.Columns[10].HeaderText = "Số lượng";
            dgvdanhsach.Columns[11].HeaderText = "Đơn giá";
            dgvdanhsach.Columns[12].HeaderText = "Thành tiền";
            dgvdanhsach.Columns[14].HeaderText = "Tên nguyên liệu";

        }

       

        private void cmbmanhanvien_Click(object sender, EventArgs e)
        {
            cmbmanhanvien.DataSource =connectDataBase.readData("select * from NhanVien");
            cmbmanhanvien.ValueMember = "MaNV";
            cmbmanhanvien.DisplayMember = "MaNV";
        }

        private void cmbchatlieu_Click(object sender, EventArgs e)
        {
            cmbnguyenlieu.DataSource =connectDataBase.readData("select * from NguyenLieu");
            cmbnguyenlieu.ValueMember = "MaNguyenLieu";
            cmbnguyenlieu.DisplayMember = "MaNguyenLieu";
        }

        private void txbthanhtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbsoluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txbdongia.Text != "")
                {
                    int dongia = Convert.ToInt32(txbdongia.Text);
                    int soluong = Convert.ToInt32(txbsoluong.Text);
                    if (txbkhuyenmai.Text != "")
                    {

                        int giamgia = Convert.ToInt32(txbkhuyenmai.Text);
                        txbthanhtien.Text = "" + ((dongia * soluong) * 0.01 * (100 - giamgia));
                    }
                    else
                    {
                        txbthanhtien.Text = "" + dongia * soluong;
                    }

                }
            }
            catch
            { }
        }

        private void txbkhuyenmai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txbdongia.Text != "")
                {
                    int dongia = Convert.ToInt32(txbdongia.Text);
                    int soluong = Convert.ToInt32(txbsoluong.Text);
                    if (txbkhuyenmai.Text != "")
                    {
                        int giamgia = Convert.ToInt32(txbkhuyenmai.Text);
                        txbthanhtien.Text = "" + ((dongia * soluong) * 0.01 * (100 - giamgia));
                    }
                    else
                    {
                        txbthanhtien.Text = "" + dongia * soluong;
                    }

                }
            }
            catch
            { }
        }

       

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgDung_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1]; //Đưa con trỏ vào ô A1
            tenTruong.Font.Size = 11; //Đặt cỡ chữ là 10

            tenTruong.Font.Name = "Times new roman";

            tenTruong.Font.Bold = true; //Định dạng kiểu font chữ là in đậm

            tenTruong.Font.Color = Color.Blue;  //Màu xanh da trời hoặc
            exSheet.Range["A1"].Font.Color = Color.Blue;
            tenTruong.ColumnWidth = 7;
            exSheet.Range["D1:F1"].Merge(true);     //Nhóm cột C tới E tại hàng 8 thành 1 hàng
            exSheet.Range["B2:H2"].Merge(true);
            exSheet.Range["D3:F3"].Merge(true);
            exSheet.Range["D4:F4"].Merge(true);
            exSheet.Range["D6:F6"].Merge(true);
            exSheet.Range["D8:E8"].Merge(true);
            exSheet.Range["F8:G8"].Merge(true);
            exSheet.Range["A8:B8"].Merge(true);
            for (int i = 1; i <= 10; i++)
                exSheet.Range["C" + i + ":E" + i].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //exSheet.get_Range("A7").Value = "STT";

            exSheet.Range["D1:F1"].Font.Bold = true;
            exSheet.Range["D1:F1"].Value = "NHà HÀNG BA ANH EM";
            exSheet.Range["B2:H2"].Value = "Đc: 1194 ĐƯỜNG LÁNG - LÁNG THƯỢNG - ĐỐNG ĐA - HÀ NỘI";
            exSheet.Range["D3:F3"].Value = "HOTLINE : 0987654321";
            exSheet.Range["D6:F6"].Value = "PHIẾU ĐẶT BÀN";
            exSheet.Range["A8:B8"].Value = "Ngày";
            exSheet.Range["C8"].Value = "Mã HĐ";
            exSheet.Range["D8:E8"].Value = "Tên NV";
            exSheet.Range["F8:G8"].Value = "Món ăn";
            exSheet.Range["H8"].Value = "SL";
            exSheet.Range["I8"].Value = "Đơn Giá";
            exSheet.Range["J8"].Value = "Thành Tiền";

            DataTable dt = connectDataBase.readData("select NgayDat , PDB.MaPhieu, HoTenNV , TenMonAn , SoLuong , CT.DonGia , SUM(SoLuong * CT.DonGia) as ThanhTien  from PhieuDatBan as PDB join ChiTietPhieuDB as CT on PDB.MaPhieu = CT.MaPhieu join MonAn as M on M.MaMonAn = CT.MaMonAn group by NgayDat, PDB.MaPhieu, HoTenNV, TenMonAn, SoLuong, CT.DonGia");

            int dong = dt.Rows.Count;
            for (int i = 1; i <= dong; i++)
            {
                exSheet.Range["A" + (i + 8) + ":B" + (i + 8)].Merge(true);
                exSheet.Range["D" + (i + 8) + ":E" + (i + 8)].Merge(true);
                exSheet.Range["F" + (i + 8) + ":G" + (i + 8)].Merge(true);

                exSheet.Range["A" + (i + 8) + ":B" + (i + 8)].Value = dt.Rows[i - 1]["NgayDat"].ToString();
                exSheet.Range["C" + (i + 8)].Value = dt.Rows[i - 1]["MaPhieu"].ToString();
                exSheet.Range["D" + (i + 8) + ":E" + (i + 8)].Value = dt.Rows[i - 1]["HoTenNV"].ToString();
                exSheet.Range["F" + (i + 8) + ":G" + (i + 8)].Value = dt.Rows[i - 1]["TenMonAn"].ToString();
                exSheet.Range["H" + (i + 8)].Value = dt.Rows[i - 1]["SoLuong"].ToString();
                exSheet.Range["I" + (i + 8)].Value = dt.Rows[i - 1]["DonGia"].ToString();
                exSheet.Range["J" + (i + 8)].Value = dt.Rows[i - 1]["ThanhTien"].ToString();
            }

            try
            {
                exBook.Activate();
                saveFileDialog1.ShowDialog();
                exBook.SaveAs(saveFileDialog1.FileName.ToString());
                exApp.Quit();
            }
            catch { }
        }

        private void tabHDNhap_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
