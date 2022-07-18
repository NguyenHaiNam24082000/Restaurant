namespace Restaurant.UserControls
{
    partial class UserControlListFoodHDB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTenMonAn = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTenMonAn
            // 
            this.labelTenMonAn.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTenMonAn.Location = new System.Drawing.Point(0, 0);
            this.labelTenMonAn.Name = "labelTenMonAn";
            this.labelTenMonAn.Size = new System.Drawing.Size(141, 40);
            this.labelTenMonAn.TabIndex = 0;
            this.labelTenMonAn.Text = "label1";
            this.labelTenMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSoLuong.Location = new System.Drawing.Point(141, 0);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(48, 40);
            this.labelSoLuong.TabIndex = 1;
            this.labelSoLuong.Text = "label1";
            this.labelSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDonGia
            // 
            this.labelDonGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDonGia.Location = new System.Drawing.Point(189, 0);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(76, 40);
            this.labelDonGia.TabIndex = 2;
            this.labelDonGia.Text = "label1";
            this.labelDonGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTongTien
            // 
            this.labelTongTien.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTongTien.Location = new System.Drawing.Point(265, 0);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(95, 40);
            this.labelTongTien.TabIndex = 3;
            this.labelTongTien.Text = "label1";
            this.labelTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlListFoodHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.labelDonGia);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.labelTenMonAn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.Name = "UserControlListFoodHDB";
            this.Size = new System.Drawing.Size(360, 40);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelTenMonAn;
        public System.Windows.Forms.Label labelSoLuong;
        public System.Windows.Forms.Label labelDonGia;
        public System.Windows.Forms.Label labelTongTien;
    }
}
