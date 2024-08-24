
namespace Nhom13_QLShopBanQuanAo.Forms
{
    partial class QLSanPham
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
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoaiMH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDDonGiaBan = new System.Windows.Forms.NumericUpDown();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.picXoa = new System.Windows.Forms.PictureBox();
            this.picSua = new System.Windows.Forms.PictureBox();
            this.picThem = new System.Windows.Forms.PictureBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDonGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(681, 216);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(101, 20);
            this.txtDVT.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(582, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Đơn vị tính:";
            // 
            // txtLoaiMH
            // 
            this.txtLoaiMH.Location = new System.Drawing.Point(681, 128);
            this.txtLoaiMH.Name = "txtLoaiMH";
            this.txtLoaiMH.Size = new System.Drawing.Size(101, 20);
            this.txtLoaiMH.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Loại mặt hàng:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(681, 87);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(101, 20);
            this.txtMaMH.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Mã mặt hàng:";
            // 
            // nUDSoLuong
            // 
            this.nUDSoLuong.Location = new System.Drawing.Point(681, 300);
            this.nUDSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.nUDSoLuong.Name = "nUDSoLuong";
            this.nUDSoLuong.Size = new System.Drawing.Size(101, 20);
            this.nUDSoLuong.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Số lượng: ";
            // 
            // nUDDonGiaBan
            // 
            this.nUDDonGiaBan.Location = new System.Drawing.Point(681, 260);
            this.nUDDonGiaBan.Margin = new System.Windows.Forms.Padding(2);
            this.nUDDonGiaBan.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nUDDonGiaBan.Name = "nUDDonGiaBan";
            this.nUDDonGiaBan.Size = new System.Drawing.Size(101, 20);
            this.nUDDonGiaBan.TabIndex = 48;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(681, 172);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(188, 20);
            this.txtTenMH.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Đơn giá bán :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(582, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên mặt hàng:";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(22, 87);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(552, 298);
            this.dgvSanPham.TabIndex = 44;
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);
            // 
            // picXoa
            // 
            this.picXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picXoa.Image = global::Nhom13_QLShopBanQuanAo.Properties.Resources.xoa;
            this.picXoa.Location = new System.Drawing.Point(781, 336);
            this.picXoa.Margin = new System.Windows.Forms.Padding(2);
            this.picXoa.Name = "picXoa";
            this.picXoa.Size = new System.Drawing.Size(75, 49);
            this.picXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXoa.TabIndex = 59;
            this.picXoa.TabStop = false;
            this.picXoa.Click += new System.EventHandler(this.picXoa_Click);
            // 
            // picSua
            // 
            this.picSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSua.Image = global::Nhom13_QLShopBanQuanAo.Properties.Resources.sua;
            this.picSua.Location = new System.Drawing.Point(681, 336);
            this.picSua.Margin = new System.Windows.Forms.Padding(2);
            this.picSua.Name = "picSua";
            this.picSua.Size = new System.Drawing.Size(75, 49);
            this.picSua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSua.TabIndex = 58;
            this.picSua.TabStop = false;
            this.picSua.Click += new System.EventHandler(this.picSua_Click);
            // 
            // picThem
            // 
            this.picThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picThem.Image = global::Nhom13_QLShopBanQuanAo.Properties.Resources.them;
            this.picThem.Location = new System.Drawing.Point(585, 336);
            this.picThem.Margin = new System.Windows.Forms.Padding(2);
            this.picThem.Name = "picThem";
            this.picThem.Size = new System.Drawing.Size(75, 49);
            this.picThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThem.TabIndex = 57;
            this.picThem.TabStop = false;
            this.picThem.Click += new System.EventHandler(this.picThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(206, 29);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(460, 34);
            this.txtTimKiem.TabIndex = 60;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(700, 29);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(82, 34);
            this.btnTimKiem.TabIndex = 61;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã Mặt Hàng",
            "Tên Mặt Hàng"});
            this.cboTimKiem.Location = new System.Drawing.Point(22, 29);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(152, 21);
            this.cboTimKiem.TabIndex = 62;
            // 
            // QLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 500);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.picXoa);
            this.Controls.Add(this.picSua);
            this.Controls.Add(this.picThem);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLoaiMH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nUDSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUDDonGiaBan);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSanPham);
            this.Name = "QLSanPham";
            this.Text = "QLSanPham";
            this.Load += new System.EventHandler(this.QLSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDonGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picXoa;
        private System.Windows.Forms.PictureBox picSua;
        private System.Windows.Forms.PictureBox picThem;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoaiMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDDonGiaBan;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboTimKiem;
    }
}