using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom13_QLShopBanQuanAo.Forms;

namespace Nhom13_QLShopBanQuanAo
{
    public partial class MainMenu : Form
    {
        private Button currentButton;
        // private Random random;
        private int tempIndex;
        private Form activateForm;
        public MainMenu(string role)
        {
            InitializeComponent();
            //access(pos);
            string userrole = role;
            if (userrole == "nhanvien")
            {
                picNhanVien.Enabled = false;
                btnNhanVien.Enabled = false;
                picTKDT.Enabled = false;
                btnTKDoanhThu.Enabled = false;
            }
        }

        void access(int type)
        {
            btnNhanVien.Enabled = type == 1;
            picNhanVien.Enabled = type == 1;
            btnQuanAo.Enabled = type == 1;
            picQuanAo.Enabled = type == 1;
            btnHoaDon.Enabled = type == 1;
            picHoaDon.Enabled = type == 1;
            btnTTKhachHang.Enabled = type == 1;
            picTTKH.Enabled = type == 1;
            btnDatHang.Enabled = type == 1;
            picDatHang.Enabled = type == 1;
            btnTKDoanhThu.Enabled = type == 1;
            picTKDT.Enabled = type == 1;

        }
        private void openChildForm(Form childForm, Object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            // ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

            //QLNhanVien emp = new QLNhanVien();
            //emp.ShowDialog();
            TopLabel.Text = "Nhân Viên";
            openChildForm(new Forms.QLNhanVien(), sender);
        }

        private void picNhanVien_Click(object sender, EventArgs e)
        {
            TopLabel.Text = "Nhân Viên";
            openChildForm(new Forms.QLNhanVien(), sender);
        }

        private void btnQuanAo_Click(object sender, EventArgs e)
        {
            TopLabel.Text = "Sản Phẩm";
            openChildForm(new Forms.QLSanPham(), sender);
        }

        private void picQuanAo_Click(object sender, EventArgs e)
        {
            TopLabel.Text = "Sản Phẩm";
            openChildForm(new Forms.QLSanPham(), sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            TopLabel.Text = "Thông Tin Đơn Đặt Hàng";
            openChildForm(new Forms.TTDonDatHang(), sender);
        }

        private void picHoaDon_Click(object sender, EventArgs e)
        {
            TopLabel.Text = "Thông Tin Đơn Đặt Hàng";
            openChildForm(new Forms.TTDonDatHang(), sender);
        }

        private void btnTTKhachHang_Click(object sender, EventArgs e)
        {
            TopLabel.Text = "Thông Tin Khách Hàng";
            openChildForm(new Forms.TTKhachHang(), sender);
        }

        private void picTTKH_Click(object sender, EventArgs e)
        {
            TopLabel.Text = "Thông Tin Khách Hàng";
            openChildForm(new Forms.TTKhachHang(), sender);
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            TopLabel.Text = "Đặt Hàng";
            openChildForm(new Forms.DatHang(), sender);
        }

        private void picDatHang_Click(object sender, EventArgs e)
        {
            TopLabel.Text = "Đặt Hàng";
            openChildForm(new Forms.DatHang(), sender);

        }

        private void btnTKDoanhThu_Click(object sender, EventArgs e)
        {
            TopLabel.Text = "Báo Cáo Thống Kê";
            openChildForm(new Forms.BaoCao_ThongKe(), sender);
        }

        private void picTKDT_Click(object sender, EventArgs e)
        {
            TopLabel.Text = "Báo Cáo Thống Kê";
            openChildForm(new Forms.BaoCao_ThongKe(), sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
