using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Nhom13_QLShopBanQuanAo.Forms
{
    public partial class TTDonDatHang : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        KetNoi kn = new KetNoi();
        SqlConnection connsql;
        public TTDonDatHang()
        {
            InitializeComponent();
            connsql = kn.con;
        }

        void Load_DgvNhanVien()
        {
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from HOADON", connsql);
            da1.Fill(ds1, "HOADON");
            dgvHD.DataSource = ds1.Tables["HOADON"];
        }
        private void TTDonDatHang_Load(object sender, EventArgs e)
        {
            Load_DgvNhanVien();
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            String sqlInsert = string.Format("Insert into HOADON Values('{0}','{1}','{2}','{3}','{4}','{5}')", txtMaHD.Text.ToString(), txtMaNV.Text.ToString(), txtMaKH.Text.ToString(), txtNgayLap.Text.ToString(), txtPT_ThanhToan.Text.ToString(), txtTongTien.Text.ToString());
            string sql = "select count(*) from HOADON where MAHD='" + txtMaHD.Text + "'";
            if (kn.checkkey(sql) == true)
            {
                try
                {
                    //dgv.DataSource = kt.taobang(sqlInsert);
                    SqlCommand cmd = new SqlCommand(sqlInsert, connsql);
                    cmd.ExecuteNonQuery();
                    Load_DgvNhanVien();
                    MessageBox.Show("Thêm Thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi !", "Thông báo");
                }
                finally
                {
                    connsql.Close();
                }
            }
            else
            {
                MessageBox.Show("Trùng mã nhân viên, vui lòng nhập lại!!!", "Thông báo");
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            try
            {
                string updatestr;
                updatestr = "update HOADON set MANV = N'" + txtMaNV.Text + "', MAKH = N'" + txtMaKH.Text + "', NGAYLAP = '" + txtNgayLap.Text + "', PT_THANHTOAN = N'" + txtPT_ThanhToan.Text + "', TONGTIEN = '" + txtTongTien.Text + "'where MAHD='" + txtMaHD.Text + "'";
                SqlCommand cmd = new SqlCommand(updatestr, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                Load_DgvNhanVien();
                MessageBox.Show("Sửa Thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Sửa Thất bại", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            try
            {
                string deletestr;
                deletestr = "delete HOADON where MAHD ='" + txtMaHD.Text + "'";
                SqlCommand cmd = new SqlCommand(deletestr, connsql);
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    Load_DgvNhanVien();
                    MessageBox.Show("Xoá Thành công", "Thông báo");
                }
                else
                {
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xoá Thất bại", "Thông báo");
            }
        }
    }
}
