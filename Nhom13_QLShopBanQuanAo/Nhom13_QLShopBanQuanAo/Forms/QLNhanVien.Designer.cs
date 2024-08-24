
namespace Nhom13_QLShopBanQuanAo.Forms
{
    partial class QLNhanVien
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
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.cbmVaiTro = new System.Windows.Forms.ComboBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textManv = new System.Windows.Forms.TextBox();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.textBoxphone = new System.Windows.Forms.TextBox();
            this.textTennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Xoa = new System.Windows.Forms.PictureBox();
            this.Sua = new System.Windows.Forms.PictureBox();
            this.Them = new System.Windows.Forms.PictureBox();
            this.cbHienThiMK = new System.Windows.Forms.CheckBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Them)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(465, 186);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(159, 20);
            this.textBoxPass.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(388, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 65;
            this.label7.Text = "Mật Khẩu: ";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(68, 244);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(665, 185);
            this.dgvNhanVien.TabIndex = 64;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            this.dgvNhanVien.SelectionChanged += new System.EventHandler(this.dgvNhanVien_SelectionChanged);
            // 
            // cbmVaiTro
            // 
            this.cbmVaiTro.FormattingEnabled = true;
            this.cbmVaiTro.Location = new System.Drawing.Point(465, 111);
            this.cbmVaiTro.Name = "cbmVaiTro";
            this.cbmVaiTro.Size = new System.Drawing.Size(159, 21);
            this.cbmVaiTro.TabIndex = 60;
            this.cbmVaiTro.SelectedIndexChanged += new System.EventHandler(this.cbmVaiTro_SelectedIndexChanged);
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(465, 68);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(159, 20);
            this.textAddress.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "Vai trò: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 57;
            this.label5.Text = "Địa chỉ:";
            // 
            // textManv
            // 
            this.textManv.Location = new System.Drawing.Point(172, 68);
            this.textManv.Margin = new System.Windows.Forms.Padding(2);
            this.textManv.Name = "textManv";
            this.textManv.Size = new System.Drawing.Size(157, 20);
            this.textManv.TabIndex = 56;
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(253, 152);
            this.radioButtonNu.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNu.TabIndex = 55;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Location = new System.Drawing.Point(172, 152);
            this.radioButtonNam.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(47, 17);
            this.radioButtonNam.TabIndex = 54;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // textBoxphone
            // 
            this.textBoxphone.Location = new System.Drawing.Point(172, 198);
            this.textBoxphone.Name = "textBoxphone";
            this.textBoxphone.Size = new System.Drawing.Size(157, 20);
            this.textBoxphone.TabIndex = 53;
            // 
            // textTennv
            // 
            this.textTennv.Location = new System.Drawing.Point(170, 112);
            this.textTennv.Name = "textTennv";
            this.textTennv.Size = new System.Drawing.Size(159, 20);
            this.textTennv.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Giới tính :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // Xoa
            // 
            this.Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoa.Image = global::Nhom13_QLShopBanQuanAo.Properties.Resources.xoa;
            this.Xoa.Location = new System.Drawing.Point(658, 177);
            this.Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 49);
            this.Xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Xoa.TabIndex = 63;
            this.Xoa.TabStop = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Sua
            // 
            this.Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sua.Image = global::Nhom13_QLShopBanQuanAo.Properties.Resources.sua;
            this.Sua.Location = new System.Drawing.Point(658, 119);
            this.Sua.Margin = new System.Windows.Forms.Padding(2);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 49);
            this.Sua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sua.TabIndex = 62;
            this.Sua.TabStop = false;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Them
            // 
            this.Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Them.Image = global::Nhom13_QLShopBanQuanAo.Properties.Resources.them;
            this.Them.Location = new System.Drawing.Point(658, 59);
            this.Them.Margin = new System.Windows.Forms.Padding(2);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 49);
            this.Them.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Them.TabIndex = 61;
            this.Them.TabStop = false;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // cbHienThiMK
            // 
            this.cbHienThiMK.AutoSize = true;
            this.cbHienThiMK.Location = new System.Drawing.Point(465, 213);
            this.cbHienThiMK.Name = "cbHienThiMK";
            this.cbHienThiMK.Size = new System.Drawing.Size(115, 17);
            this.cbHienThiMK.TabIndex = 67;
            this.cbHienThiMK.Text = "Hiển Thị Mật Khẩu";
            this.cbHienThiMK.UseVisualStyleBackColor = true;
            this.cbHienThiMK.CheckedChanged += new System.EventHandler(this.cbHienThiMK_CheckedChanged);
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã Nhân Viên",
            "Tên Nhân Viên",
            "Vai Trò"});
            this.cboTimKiem.Location = new System.Drawing.Point(74, 12);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(145, 21);
            this.cboTimKiem.TabIndex = 70;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(658, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 34);
            this.btnTimKiem.TabIndex = 69;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(238, 12);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(386, 34);
            this.txtTimKiem.TabIndex = 68;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(465, 148);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(159, 20);
            this.txtUserName.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(388, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 71;
            this.label8.Text = "Tài Khoản: ";
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cbHienThiMK);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.cbmVaiTro);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textManv);
            this.Controls.Add(this.radioButtonNu);
            this.Controls.Add(this.radioButtonNam);
            this.Controls.Add(this.textBoxphone);
            this.Controls.Add(this.textTennv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLNhanVien";
            this.Text = "QLNhanVien";
            this.Load += new System.EventHandler(this.QLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Them)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.PictureBox Xoa;
        private System.Windows.Forms.PictureBox Sua;
        private System.Windows.Forms.PictureBox Them;
        private System.Windows.Forms.ComboBox cbmVaiTro;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textManv;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.TextBox textBoxphone;
        private System.Windows.Forms.TextBox textTennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbHienThiMK;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label8;
    }
}