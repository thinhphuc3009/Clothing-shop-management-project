
namespace Nhom13_QLShopBanQuanAo.Forms
{
    partial class DatHang
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "HÓA ĐƠN ĐẶT HÀNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(504, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "                                             Thông Tin Đơn Đặt Hàng              " +
    "                        ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã đơn đặt hàng: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mã nhà cung cấp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Mã nhân viên:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 88);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Ngày lập:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(591, 77);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 36);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(591, 160);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 36);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(591, 117);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 39);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(112, 109);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(92, 20);
            this.txtMaNCC.TabIndex = 13;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(283, 55);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(132, 20);
            this.txtMaNV.TabIndex = 17;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(283, 109);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(132, 20);
            this.txtNgayLap.TabIndex = 18;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.Location = new System.Drawing.Point(111, 55);
            this.txtMaDDH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(92, 20);
            this.txtMaDDH.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaDDH);
            this.panel2.Controls.Add(this.dgvHD);
            this.panel2.Controls.Add(this.txtNgayLap);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.txtMaNCC);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(11, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 344);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(8, 154);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.Size = new System.Drawing.Size(499, 176);
            this.dgvHD.TabIndex = 19;
            this.dgvHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDDH_CellContentClick);
            // 
            // DatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "DatHang";
            this.Text = "DatHang";
            this.Load += new System.EventHandler(this.DatHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtMaDDH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHD;
    }
}