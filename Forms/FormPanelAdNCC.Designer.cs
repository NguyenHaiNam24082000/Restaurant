namespace Restaurant.Forms
{
    partial class FormPanelAdNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelAdNCC));
            this.txtThue = new System.Windows.Forms.TextBox();
            this.btnAddExit = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtThue
            // 
            this.txtThue.Location = new System.Drawing.Point(394, 206);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(121, 20);
            this.txtThue.TabIndex = 96;
            this.txtThue.TextChanged += new System.EventHandler(this.txtThue_TextChanged);
            // 
            // btnAddExit
            // 
            this.btnAddExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddExit.BackgroundImage")));
            this.btnAddExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddExit.Location = new System.Drawing.Point(416, 303);
            this.btnAddExit.Name = "btnAddExit";
            this.btnAddExit.Size = new System.Drawing.Size(48, 45);
            this.btnAddExit.TabIndex = 95;
            this.btnAddExit.UseVisualStyleBackColor = true;
            this.btnAddExit.Click += new System.EventHandler(this.btnAddExit_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSave.BackgroundImage")));
            this.btnAddSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSave.Location = new System.Drawing.Point(357, 303);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(53, 45);
            this.btnAddSave.TabIndex = 94;
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(394, 166);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(121, 20);
            this.txtSoDienThoai.TabIndex = 93;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fillNumber);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label14.Location = new System.Drawing.Point(276, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "Mã Số Thuế";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label12.Location = new System.Drawing.Point(276, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 91;
            this.label12.Text = "Số Điện Thoại";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label11.Location = new System.Drawing.Point(525, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 90;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(394, 133);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(121, 20);
            this.txtDiaChi.TabIndex = 89;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Location = new System.Drawing.Point(276, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "Địa Chỉ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(394, 102);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(121, 20);
            this.txtTenNCC.TabIndex = 87;
            this.txtTenNCC.TextChanged += new System.EventHandler(this.txtTenNCC_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Location = new System.Drawing.Point(276, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "Tên nhà cung cấp";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // FormPanelAdNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtThue);
            this.Controls.Add(this.btnAddExit);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.label8);
            this.Name = "FormPanelAdNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPanelAdNCC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.Button btnAddExit;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label8;
    }
}