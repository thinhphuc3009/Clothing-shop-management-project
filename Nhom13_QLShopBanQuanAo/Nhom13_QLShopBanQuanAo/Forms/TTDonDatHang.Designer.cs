
namespace Nhom13_QLShopBanQuanAo.Forms
{
    partial class TTDonDatHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtPT_ThanhToan = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "                        THÔNG TIN HÓA ĐƠN                      ";
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(12, 56);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.Size = new System.Drawing.Size(448, 247);
            this.dgvHD.TabIndex = 16;
            this.dgvHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(506, 263);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 40);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(707, 263);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 40);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(608, 263);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 40);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(572, 53);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã Hoá Đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã Khách Hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ngày Lập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "PT_Thanh Toán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tổng Tiền";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(572, 84);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 27;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(572, 119);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 20);
            this.txtMaKH.TabIndex = 28;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(572, 149);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(100, 20);
            this.txtNgayLap.TabIndex = 29;
            // 
            // txtPT_ThanhToan
            // 
            this.txtPT_ThanhToan.Location = new System.Drawing.Point(572, 183);
            this.txtPT_ThanhToan.Name = "txtPT_ThanhToan";
            this.txtPT_ThanhToan.Size = new System.Drawing.Size(100, 20);
            this.txtPT_ThanhToan.TabIndex = 30;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(572, 215);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 31;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(793, 263);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(64, 40);
            this.btnIn.TabIndex = 32;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // TTDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 329);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtPT_ThanhToan);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.label1);
            this.Name = "TTDonDatHang";
            this.Text = "TTDonDatHang";
            this.Load += new System.EventHandler(this.TTDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtPT_ThanhToan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnIn;
    }
}