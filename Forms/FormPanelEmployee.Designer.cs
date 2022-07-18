﻿namespace Restaurant.Forms
{
    partial class FormPanelEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDisplayEmployee = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSearch = new FontAwesome.Sharp.IconButton();
            this.comboBoxTK = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelInforEmployee = new XanderUI.XUIFlatTab();
            this.tabTT = new System.Windows.Forms.TabPage();
            this.comboBoxTT = new System.Windows.Forms.ComboBox();
            this.comboBoxGT = new System.Windows.Forms.ComboBox();
            this.dateTimeNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNS = new System.Windows.Forms.DateTimePicker();
            this.textQQ = new System.Windows.Forms.TextBox();
            this.textDC = new System.Windows.Forms.TextBox();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.textCMT = new System.Windows.Forms.TextBox();
            this.textTenNV = new System.Windows.Forms.TextBox();
            this.textMaNV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelNgayKetThuc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.xuiCustomGroupbox3 = new XanderUI.XUICustomGroupbox();
            this.buttonCancel = new FontAwesome.Sharp.IconButton();
            this.buttonFind = new FontAwesome.Sharp.IconButton();
            this.buttonDelete = new FontAwesome.Sharp.IconButton();
            this.buttonSave = new FontAwesome.Sharp.IconButton();
            this.buttonAdd = new FontAwesome.Sharp.IconButton();
            this.toolTip = new Zeroit.Framework.Tooltip.ZeroitTetraToolTip();
            this.buttonAvatar = new Restaurant.CustomControls.RadiusIconPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelInforEmployee.SuspendLayout();
            this.tabTT.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.xuiCustomGroupbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelDisplayEmployee);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(794, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 611);
            this.panel1.TabIndex = 0;
            // 
            // panelDisplayEmployee
            // 
            this.panelDisplayEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplayEmployee.Location = new System.Drawing.Point(0, 25);
            this.panelDisplayEmployee.Name = "panelDisplayEmployee";
            this.panelDisplayEmployee.Size = new System.Drawing.Size(220, 586);
            this.panelDisplayEmployee.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.comboBoxTK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 25);
            this.panel2.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.buttonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSearch.IconSize = 24;
            this.buttonSearch.Location = new System.Drawing.Point(195, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Rotation = 0D;
            this.buttonSearch.Size = new System.Drawing.Size(25, 25);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxTK
            // 
            this.comboBoxTK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxTK.DisplayMember = "MaKM";
            this.comboBoxTK.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.comboBoxTK.Location = new System.Drawing.Point(0, 0);
            this.comboBoxTK.Name = "comboBoxTK";
            this.comboBoxTK.Size = new System.Drawing.Size(195, 24);
            this.comboBoxTK.TabIndex = 20;
            this.comboBoxTK.ValueMember = "MaKM";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.panelInforEmployee);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.xuiCustomGroupbox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(794, 611);
            this.panel4.TabIndex = 1;
            // 
            // panelInforEmployee
            // 
            this.panelInforEmployee.ActiveHeaderColor = System.Drawing.Color.Transparent;
            this.panelInforEmployee.ActiveTextColor = System.Drawing.Color.BlueViolet;
            this.panelInforEmployee.BorderColor = System.Drawing.Color.Transparent;
            this.panelInforEmployee.Controls.Add(this.tabTT);
            this.panelInforEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInforEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInforEmployee.HeaderBackgroundColor = System.Drawing.Color.White;
            this.panelInforEmployee.InActiveHeaderColor = System.Drawing.Color.Transparent;
            this.panelInforEmployee.InActiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.panelInforEmployee.ItemSize = new System.Drawing.Size(240, 20);
            this.panelInforEmployee.Location = new System.Drawing.Point(0, 247);
            this.panelInforEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.panelInforEmployee.Multiline = true;
            this.panelInforEmployee.Name = "panelInforEmployee";
            this.panelInforEmployee.OnlyTopLine = true;
            this.panelInforEmployee.Padding = new System.Drawing.Point(0, 0);
            this.panelInforEmployee.PageColor = System.Drawing.Color.White;
            this.panelInforEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelInforEmployee.SelectedIndex = 0;
            this.panelInforEmployee.ShowToolTips = true;
            this.panelInforEmployee.Size = new System.Drawing.Size(794, 277);
            this.panelInforEmployee.TabIndex = 28;
            // 
            // tabTT
            // 
            this.tabTT.BackColor = System.Drawing.Color.White;
            this.tabTT.Controls.Add(this.comboBoxTT);
            this.tabTT.Controls.Add(this.comboBoxGT);
            this.tabTT.Controls.Add(this.dateTimeNgayKT);
            this.tabTT.Controls.Add(this.dateTimeNgayBatDau);
            this.tabTT.Controls.Add(this.dateTimeNS);
            this.tabTT.Controls.Add(this.textQQ);
            this.tabTT.Controls.Add(this.textDC);
            this.tabTT.Controls.Add(this.textSDT);
            this.tabTT.Controls.Add(this.textCMT);
            this.tabTT.Controls.Add(this.textTenNV);
            this.tabTT.Controls.Add(this.textMaNV);
            this.tabTT.Controls.Add(this.label12);
            this.tabTT.Controls.Add(this.label11);
            this.tabTT.Controls.Add(this.label10);
            this.tabTT.Controls.Add(this.labelNgayKetThuc);
            this.tabTT.Controls.Add(this.label8);
            this.tabTT.Controls.Add(this.label7);
            this.tabTT.Controls.Add(this.label6);
            this.tabTT.Controls.Add(this.label5);
            this.tabTT.Controls.Add(this.label4);
            this.tabTT.Controls.Add(this.label3);
            this.tabTT.Controls.Add(this.label2);
            this.tabTT.Location = new System.Drawing.Point(4, 24);
            this.tabTT.Name = "tabTT";
            this.tabTT.Size = new System.Drawing.Size(786, 249);
            this.tabTT.TabIndex = 0;
            this.tabTT.Text = "Thông tin";
            // 
            // comboBoxTT
            // 
            this.comboBoxTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.comboBoxTT.FormattingEnabled = true;
            this.comboBoxTT.Items.AddRange(new object[] {
            "Đang làm",
            "Thôi việc"});
            this.comboBoxTT.Location = new System.Drawing.Point(529, 173);
            this.comboBoxTT.Name = "comboBoxTT";
            this.comboBoxTT.Size = new System.Drawing.Size(254, 21);
            this.comboBoxTT.TabIndex = 25;
            this.comboBoxTT.SelectedIndexChanged += new System.EventHandler(this.comboBoxTT_SelectedIndexChanged);
            this.comboBoxTT.TextChanged += new System.EventHandler(this.textBoxChange_TextChanged);
            // 
            // comboBoxGT
            // 
            this.comboBoxGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.comboBoxGT.FormattingEnabled = true;
            this.comboBoxGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGT.Location = new System.Drawing.Point(180, 93);
            this.comboBoxGT.Name = "comboBoxGT";
            this.comboBoxGT.Size = new System.Drawing.Size(239, 21);
            this.comboBoxGT.TabIndex = 24;
            this.comboBoxGT.TextChanged += new System.EventHandler(this.textBoxChange_TextChanged);
            // 
            // dateTimeNgayKT
            // 
            this.dateTimeNgayKT.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.dateTimeNgayKT.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.dateTimeNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNgayKT.Enabled = false;
            this.dateTimeNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayKT.Location = new System.Drawing.Point(529, 207);
            this.dateTimeNgayKT.Name = "dateTimeNgayKT";
            this.dateTimeNgayKT.Size = new System.Drawing.Size(254, 20);
            this.dateTimeNgayKT.TabIndex = 23;
            this.dateTimeNgayKT.Visible = false;
            // 
            // dateTimeNgayBatDau
            // 
            this.dateTimeNgayBatDau.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.dateTimeNgayBatDau.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.dateTimeNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayBatDau.Location = new System.Drawing.Point(529, 133);
            this.dateTimeNgayBatDau.Name = "dateTimeNgayBatDau";
            this.dateTimeNgayBatDau.Size = new System.Drawing.Size(254, 20);
            this.dateTimeNgayBatDau.TabIndex = 22;
            this.dateTimeNgayBatDau.ValueChanged += new System.EventHandler(this.dateTimeChange_ValueChanged);
            // 
            // dateTimeNS
            // 
            this.dateTimeNS.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.dateTimeNS.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.dateTimeNS.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNS.Location = new System.Drawing.Point(180, 207);
            this.dateTimeNS.Name = "dateTimeNS";
            this.dateTimeNS.Size = new System.Drawing.Size(241, 20);
            this.dateTimeNS.TabIndex = 21;
            this.dateTimeNS.ValueChanged += new System.EventHandler(this.dateTimeChange_ValueChanged);
            // 
            // textQQ
            // 
            this.textQQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.textQQ.Location = new System.Drawing.Point(529, 94);
            this.textQQ.Name = "textQQ";
            this.textQQ.Size = new System.Drawing.Size(254, 20);
            this.textQQ.TabIndex = 18;
            this.textQQ.TextChanged += new System.EventHandler(this.textBoxChange_TextChanged);
            // 
            // textDC
            // 
            this.textDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.textDC.Location = new System.Drawing.Point(529, 16);
            this.textDC.Multiline = true;
            this.textDC.Name = "textDC";
            this.textDC.Size = new System.Drawing.Size(254, 72);
            this.textDC.TabIndex = 17;
            this.textDC.TextChanged += new System.EventHandler(this.textBoxChange_TextChanged);
            // 
            // textSDT
            // 
            this.textSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.textSDT.Location = new System.Drawing.Point(180, 173);
            this.textSDT.MaxLength = 10;
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(241, 20);
            this.textSDT.TabIndex = 15;
            this.textSDT.TextChanged += new System.EventHandler(this.textBoxChange_TextChanged);
            this.textSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumber_KeyPress);
            // 
            // textCMT
            // 
            this.textCMT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.textCMT.Location = new System.Drawing.Point(180, 136);
            this.textCMT.MaxLength = 9;
            this.textCMT.Name = "textCMT";
            this.textCMT.Size = new System.Drawing.Size(241, 20);
            this.textCMT.TabIndex = 14;
            this.textCMT.TextChanged += new System.EventHandler(this.textBoxChange_TextChanged);
            this.textCMT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumber_KeyPress);
            // 
            // textTenNV
            // 
            this.textTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.textTenNV.Location = new System.Drawing.Point(180, 54);
            this.textTenNV.Name = "textTenNV";
            this.textTenNV.Size = new System.Drawing.Size(241, 20);
            this.textTenNV.TabIndex = 12;
            this.textTenNV.TextChanged += new System.EventHandler(this.textTenNV_TextChanged);
            // 
            // textMaNV
            // 
            this.textMaNV.Enabled = false;
            this.textMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.textMaNV.Location = new System.Drawing.Point(180, 16);
            this.textMaNV.Name = "textMaNV";
            this.textMaNV.Size = new System.Drawing.Size(241, 20);
            this.textMaNV.TabIndex = 11;
            this.textMaNV.TextChanged += new System.EventHandler(this.textMaNV_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(425, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Địa chỉ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "SĐT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Giới tính:";
            // 
            // labelNgayKetThuc
            // 
            this.labelNgayKetThuc.AutoSize = true;
            this.labelNgayKetThuc.Location = new System.Drawing.Point(427, 213);
            this.labelNgayKetThuc.Name = "labelNgayKetThuc";
            this.labelNgayKetThuc.Size = new System.Drawing.Size(96, 13);
            this.labelNgayKetThuc.TabIndex = 7;
            this.labelNgayKetThuc.Text = "Ngày nghỉ việc:";
            this.labelNgayKetThuc.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tình trạng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày bắt đầu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quê quán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CMT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.labelMaNV);
            this.panel3.Controls.Add(this.labelHoTen);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 247);
            this.panel3.TabIndex = 27;
            // 
            // labelMaNV
            // 
            this.labelMaNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNV.ForeColor = System.Drawing.Color.White;
            this.labelMaNV.Location = new System.Drawing.Point(0, 207);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(794, 30);
            this.labelMaNV.TabIndex = 3;
            this.labelMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMaNV.Visible = false;
            // 
            // labelHoTen
            // 
            this.labelHoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.ForeColor = System.Drawing.Color.White;
            this.labelHoTen.Location = new System.Drawing.Point(0, 177);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(794, 30);
            this.labelHoTen.TabIndex = 1;
            this.labelHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHoTen.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonAvatar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(794, 177);
            this.panel5.TabIndex = 2;
            // 
            // xuiCustomGroupbox3
            // 
            this.xuiCustomGroupbox3.BackColor = System.Drawing.Color.White;
            this.xuiCustomGroupbox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.xuiCustomGroupbox3.BorderWidth = 1;
            this.xuiCustomGroupbox3.Controls.Add(this.buttonCancel);
            this.xuiCustomGroupbox3.Controls.Add(this.buttonFind);
            this.xuiCustomGroupbox3.Controls.Add(this.buttonDelete);
            this.xuiCustomGroupbox3.Controls.Add(this.buttonSave);
            this.xuiCustomGroupbox3.Controls.Add(this.buttonAdd);
            this.xuiCustomGroupbox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xuiCustomGroupbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiCustomGroupbox3.Location = new System.Drawing.Point(0, 524);
            this.xuiCustomGroupbox3.Name = "xuiCustomGroupbox3";
            this.xuiCustomGroupbox3.ShowText = true;
            this.xuiCustomGroupbox3.Size = new System.Drawing.Size(794, 87);
            this.xuiCustomGroupbox3.TabIndex = 25;
            this.xuiCustomGroupbox3.TabStop = false;
            this.xuiCustomGroupbox3.Text = "Chức năng";
            this.xuiCustomGroupbox3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.buttonCancel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.buttonCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCancel.IconSize = 32;
            this.buttonCancel.Location = new System.Drawing.Point(679, 30);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Rotation = 0D;
            this.buttonCancel.Size = new System.Drawing.Size(108, 45);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Hủy bỏ";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFind.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonFind.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.buttonFind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonFind.IconSize = 32;
            this.buttonFind.Location = new System.Drawing.Point(518, 30);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Rotation = 0D;
            this.buttonFind.Size = new System.Drawing.Size(108, 45);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Tìm kiếm";
            this.buttonFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.buttonDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.buttonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDelete.IconSize = 32;
            this.buttonDelete.Location = new System.Drawing.Point(350, 30);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Rotation = 0D;
            this.buttonDelete.Size = new System.Drawing.Size(108, 45);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Enabled = false;
            this.buttonSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.buttonSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.buttonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSave.IconSize = 32;
            this.buttonSave.Location = new System.Drawing.Point(179, 30);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Rotation = 0D;
            this.buttonSave.Size = new System.Drawing.Size(108, 45);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.buttonAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.buttonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAdd.IconSize = 32;
            this.buttonAdd.Location = new System.Drawing.Point(6, 30);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Rotation = 0D;
            this.buttonAdd.Size = new System.Drawing.Size(108, 45);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // toolTip
            // 
            this.toolTip.AnimationSpeed = 0;
            // 
            // buttonAvatar
            // 
            this.buttonAvatar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAvatar.BorderColor = System.Drawing.Color.White;
            this.buttonAvatar.BorderRadiusBottomLeft = 150;
            this.buttonAvatar.BorderRadiusBottomRight = 150;
            this.buttonAvatar.BorderRadiusTopLeft = 150;
            this.buttonAvatar.BorderRadiusTopRight = 150;
            this.buttonAvatar.BorderWidth = 5F;
            this.buttonAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAvatar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonAvatar.IconColor = System.Drawing.Color.White;
            this.buttonAvatar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAvatar.IconSize = 150;
            this.buttonAvatar.Location = new System.Drawing.Point(330, 12);
            this.buttonAvatar.Name = "buttonAvatar";
            this.buttonAvatar.Size = new System.Drawing.Size(150, 150);
            this.buttonAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonAvatar.TabIndex = 3;
            this.buttonAvatar.TabStop = false;
            this.buttonAvatar.Visible = false;
            this.buttonAvatar.Click += new System.EventHandler(this.buttonAvatar_Click);
            // 
            // FormPanelEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.Name = "FormPanelEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FormPanelEmployee";
            this.Load += new System.EventHandler(this.FormPanelEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelInforEmployee.ResumeLayout(false);
            this.tabTT.ResumeLayout(false);
            this.tabTT.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.xuiCustomGroupbox3.ResumeLayout(false);
            this.xuiCustomGroupbox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel panelDisplayEmployee;
        private FontAwesome.Sharp.IconButton buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxTK;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox3;
        private FontAwesome.Sharp.IconButton buttonAdd;
        public XanderUI.XUIFlatTab panelInforEmployee;
        private System.Windows.Forms.TabPage tabTT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelNgayKetThuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHoTen;
        private FontAwesome.Sharp.IconButton buttonFind;
        private FontAwesome.Sharp.IconButton buttonDelete;
        private FontAwesome.Sharp.IconButton buttonSave;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textQQ;
        private System.Windows.Forms.TextBox textDC;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.TextBox textCMT;
        private System.Windows.Forms.TextBox textTenNV;
        private System.Windows.Forms.TextBox textMaNV;
        private System.Windows.Forms.ComboBox comboBoxTT;
        private System.Windows.Forms.ComboBox comboBoxGT;
        private System.Windows.Forms.DateTimePicker dateTimeNgayKT;
        private System.Windows.Forms.DateTimePicker dateTimeNgayBatDau;
        private System.Windows.Forms.DateTimePicker dateTimeNS;
        private FontAwesome.Sharp.IconButton buttonCancel;
        private CustomControls.RadiusIconPictureBox buttonAvatar;
        private Zeroit.Framework.Tooltip.ZeroitTetraToolTip toolTip;
    }
}