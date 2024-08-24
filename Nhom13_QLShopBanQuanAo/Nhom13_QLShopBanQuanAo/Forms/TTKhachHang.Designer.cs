
namespace Nhom13_QLShopBanQuanAo.Forms
{
    partial class TTKhachHang
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.tenkh = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.sdt = new System.Windows.Forms.TextBox();
            this.makh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(574, 307);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 37);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tenkh
            // 
            this.tenkh.Location = new System.Drawing.Point(113, 138);
            this.tenkh.Margin = new System.Windows.Forms.Padding(2);
            this.tenkh.Name = "tenkh";
            this.tenkh.Size = new System.Drawing.Size(324, 20);
            this.tenkh.TabIndex = 51;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(113, 65);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(324, 20);
            this.search.TabIndex = 50;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tìm kiếm khách hàng";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(331, 307);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 37);
            this.btnSua.TabIndex = 48;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(223, 307);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 37);
            this.btnXoa.TabIndex = 47;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(450, 307);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 37);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "TRỞ VỀ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(113, 307);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 37);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.Them_Click);
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(113, 218);
            this.diachi.Margin = new System.Windows.Forms.Padding(2);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(324, 20);
            this.diachi.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Mã khách hàng";
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(450, 58);
            this.dgvKH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(555, 188);
            this.dgvKH.TabIndex = 42;
            this.dgvKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellContentClick);
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(113, 174);
            this.sdt.Margin = new System.Windows.Forms.Padding(2);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(324, 20);
            this.sdt.TabIndex = 41;
            // 
            // makh
            // 
            this.makh.Location = new System.Drawing.Point(113, 101);
            this.makh.Margin = new System.Windows.Forms.Padding(2);
            this.makh.Name = "makh";
            this.makh.Size = new System.Drawing.Size(324, 20);
            this.makh.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "SĐT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "                                             THÔNG TIN KHÁCH HÀNG                " +
    "                         \r\n";
            // 
            // TTKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 340);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tenkh);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.makh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TTKhachHang";
            this.Text = "TTKhachHang";
            this.Load += new System.EventHandler(this.TTKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tenkh;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox makh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}