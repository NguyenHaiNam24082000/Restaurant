namespace Restaurant.Forms
{
    partial class FormPanelDoiTac
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
            this.dgvDoiTac = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiTac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoiTac
            // 
            this.dgvDoiTac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoiTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoiTac.Location = new System.Drawing.Point(11, 11);
            this.dgvDoiTac.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDoiTac.Name = "dgvDoiTac";
            this.dgvDoiTac.RowHeadersWidth = 82;
            this.dgvDoiTac.RowTemplate.Height = 33;
            this.dgvDoiTac.Size = new System.Drawing.Size(778, 428);
            this.dgvDoiTac.TabIndex = 2;
            // 
            // FormPanelDoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDoiTac);
            this.Name = "FormPanelDoiTac";
            this.Text = "FormPanelDoiTac";
            this.Load += new System.EventHandler(this.FormPanelDoiTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiTac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoiTac;
    }
}