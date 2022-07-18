namespace Restaurant.Forms
{
    partial class FormPanelAddNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelAddNguyenLieu));
            this.txtAddGhiChu = new System.Windows.Forms.TextBox();
            this.btnAddExit = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbAddType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddDonVi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddGhiChu
            // 
            this.txtAddGhiChu.Location = new System.Drawing.Point(368, 240);
            this.txtAddGhiChu.Name = "txtAddGhiChu";
            this.txtAddGhiChu.Size = new System.Drawing.Size(121, 20);
            this.txtAddGhiChu.TabIndex = 85;
            // 
            // btnAddExit
            // 
            this.btnAddExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddExit.BackgroundImage")));
            this.btnAddExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddExit.Location = new System.Drawing.Point(408, 304);
            this.btnAddExit.Name = "btnAddExit";
            this.btnAddExit.Size = new System.Drawing.Size(48, 45);
            this.btnAddExit.TabIndex = 84;
            this.btnAddExit.UseVisualStyleBackColor = true;
            this.btnAddExit.Click += new System.EventHandler(this.btnAddExit_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSave.BackgroundImage")));
            this.btnAddSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSave.Location = new System.Drawing.Point(330, 304);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(53, 45);
            this.btnAddSave.TabIndex = 83;
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(368, 171);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 82;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fillNumber);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label14.Location = new System.Drawing.Point(282, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 81;
            this.label14.Text = "Ghi chú";
            // 
            // cbAddType
            // 
            this.cbAddType.FormattingEnabled = true;
            this.cbAddType.Location = new System.Drawing.Point(368, 203);
            this.cbAddType.Name = "cbAddType";
            this.cbAddType.Size = new System.Drawing.Size(121, 21);
            this.cbAddType.TabIndex = 80;
            this.cbAddType.Text = "---Chọn Loại---";
            this.cbAddType.Click += new System.EventHandler(this.cbAddType_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label13.Location = new System.Drawing.Point(282, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 79;
            this.label13.Text = "Loại";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label12.Location = new System.Drawing.Point(282, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 78;
            this.label12.Text = "Số Lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label11.Location = new System.Drawing.Point(518, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 77;
            // 
            // txtAddDonVi
            // 
            this.txtAddDonVi.Location = new System.Drawing.Point(368, 134);
            this.txtAddDonVi.Name = "txtAddDonVi";
            this.txtAddDonVi.Size = new System.Drawing.Size(121, 20);
            this.txtAddDonVi.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Location = new System.Drawing.Point(282, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Đơn vị";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(368, 102);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(121, 20);
            this.txtAddName.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Location = new System.Drawing.Point(282, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Tên nguyên liệu";
            // 
            // FormPanelAddNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAddGhiChu);
            this.Controls.Add(this.btnAddExit);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbAddType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAddDonVi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.label8);
            this.Name = "FormPanelAddNguyenLieu";
            this.Text = "FormAddNguyenLieu";
            this.Load += new System.EventHandler(this.FormPanelAddNguyenLieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddGhiChu;
        private System.Windows.Forms.Button btnAddExit;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbAddType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddDonVi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label8;
    }
}