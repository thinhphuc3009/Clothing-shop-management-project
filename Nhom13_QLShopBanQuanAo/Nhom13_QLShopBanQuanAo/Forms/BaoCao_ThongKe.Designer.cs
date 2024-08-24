
namespace Nhom13_QLShopBanQuanAo.Forms
{
    partial class BaoCao_ThongKe
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoMacDinh = new System.Windows.Forms.RadioButton();
            this.rdoTheoNgay = new System.Windows.Forms.RadioButton();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.dgvSoLuong_DoanhThu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoLuong_DoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Từ ngày";
            // 
            // rdoMacDinh
            // 
            this.rdoMacDinh.AutoSize = true;
            this.rdoMacDinh.Checked = true;
            this.rdoMacDinh.Location = new System.Drawing.Point(492, 56);
            this.rdoMacDinh.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMacDinh.Name = "rdoMacDinh";
            this.rdoMacDinh.Size = new System.Drawing.Size(97, 17);
            this.rdoMacDinh.TabIndex = 25;
            this.rdoMacDinh.TabStop = true;
            this.rdoMacDinh.Text = "Theo mặc định";
            this.rdoMacDinh.UseVisualStyleBackColor = true;
            // 
            // rdoTheoNgay
            // 
            this.rdoTheoNgay.AutoSize = true;
            this.rdoTheoNgay.Location = new System.Drawing.Point(372, 56);
            this.rdoTheoNgay.Margin = new System.Windows.Forms.Padding(2);
            this.rdoTheoNgay.Name = "rdoTheoNgay";
            this.rdoTheoNgay.Size = new System.Drawing.Size(76, 17);
            this.rdoTheoNgay.TabIndex = 24;
            this.rdoTheoNgay.TabStop = true;
            this.rdoTheoNgay.Text = "Theo ngày";
            this.rdoTheoNgay.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(426, 11);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(69, 35);
            this.btnThongKe.TabIndex = 23;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKT.Location = new System.Drawing.Point(591, 20);
            this.dtpNgayKT.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(151, 20);
            this.dtpNgayKT.TabIndex = 22;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(228, 20);
            this.dtpNgayBD.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(151, 20);
            this.dtpNgayBD.TabIndex = 21;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(68, 94);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(784, 256);
            this.dgvThongKe.TabIndex = 20;
            // 
            // dgvSoLuong_DoanhThu
            // 
            this.dgvSoLuong_DoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoLuong_DoanhThu.Location = new System.Drawing.Point(68, 354);
            this.dgvSoLuong_DoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSoLuong_DoanhThu.Name = "dgvSoLuong_DoanhThu";
            this.dgvSoLuong_DoanhThu.RowHeadersWidth = 51;
            this.dgvSoLuong_DoanhThu.RowTemplate.Height = 24;
            this.dgvSoLuong_DoanhThu.Size = new System.Drawing.Size(380, 103);
            this.dgvSoLuong_DoanhThu.TabIndex = 28;
            // 
            // BaoCao_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 459);
            this.Controls.Add(this.dgvSoLuong_DoanhThu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdoMacDinh);
            this.Controls.Add(this.rdoTheoNgay);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.dgvThongKe);
            this.Name = "BaoCao_ThongKe";
            this.Text = "BaoCao_ThongKe";
            this.Load += new System.EventHandler(this.BaoCao_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoLuong_DoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoMacDinh;
        private System.Windows.Forms.RadioButton rdoTheoNgay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DataGridView dgvSoLuong_DoanhThu;
    }
}