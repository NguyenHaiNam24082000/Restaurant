namespace Restaurant.Forms
{
    partial class FormPanelChart
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
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.comboBoxThang = new System.Windows.Forms.ComboBox();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.checkThang = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox();
            this.checkNam = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.xuiCustomGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.comboBoxThang);
            this.xuiCustomGroupbox1.Controls.Add(this.comboBoxNam);
            this.xuiCustomGroupbox1.Controls.Add(this.checkThang);
            this.xuiCustomGroupbox1.Controls.Add(this.checkNam);
            this.xuiCustomGroupbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(45, 27);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(396, 150);
            this.xuiCustomGroupbox1.TabIndex = 2;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Chi tiết";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            // 
            // comboBoxThang
            // 
            this.comboBoxThang.FormattingEnabled = true;
            this.comboBoxThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxThang.Location = new System.Drawing.Point(83, 91);
            this.comboBoxThang.Name = "comboBoxThang";
            this.comboBoxThang.Size = new System.Drawing.Size(273, 28);
            this.comboBoxThang.TabIndex = 16;
            this.comboBoxThang.TextChanged += new System.EventHandler(this.comboBoxThang_TextChanged);
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018"});
            this.comboBoxNam.Location = new System.Drawing.Point(83, 38);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(273, 28);
            this.comboBoxNam.TabIndex = 15;
            this.comboBoxNam.TextChanged += new System.EventHandler(this.comboBoxNam_TextChanged);
            // 
            // checkThang
            // 
            this.checkThang.AllowTransparency = true;
            this.checkThang.Checked = false;
            this.checkThang.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.checkThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.checkThang.Location = new System.Drawing.Point(6, 99);
            this.checkThang.Name = "checkThang";
            this.checkThang.RectangleWidth = 1;
            this.checkThang.Size = new System.Drawing.Size(66, 20);
            this.checkThang.TabIndex = 9;
            this.checkThang.Text = "Tháng:";
            this.checkThang.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.checkThang.Click += new System.EventHandler(this.checkChiTiet_Click);
            // 
            // checkNam
            // 
            this.checkNam.AllowTransparency = true;
            this.checkNam.Checked = false;
            this.checkNam.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.checkNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.checkNam.Location = new System.Drawing.Point(6, 43);
            this.checkNam.Name = "checkNam";
            this.checkNam.RectangleWidth = 1;
            this.checkNam.Size = new System.Drawing.Size(57, 20);
            this.checkNam.TabIndex = 3;
            this.checkNam.Text = "Năm:";
            this.checkNam.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.checkNam.Click += new System.EventHandler(this.checkChiTiet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 321);
            this.dataGridView1.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 48;
            this.iconButton1.Location = new System.Drawing.Point(49, 546);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(154, 53);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Hủy";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FormPanelChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(201)))));
            this.Name = "FormPanelChart";
            this.Text = "FormPanelChart";
            this.Load += new System.EventHandler(this.FormPanelChart_Load);
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox checkThang;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox checkNam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox comboBoxThang;
        private System.Windows.Forms.ComboBox comboBoxNam;
    }
}