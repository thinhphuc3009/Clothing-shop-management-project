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
using Nhom13_QLShopBanQuanAo.Forms;

namespace Nhom13_QLShopBanQuanAo.Forms
{
    public partial class QLSanPham : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        KetNoi kn = new KetNoi();
        SqlConnection connsql;
        public QLSanPham()
        {
            InitializeComponent();
            connsql = kn.con;
        }
        void Load_DgvSanPham()
        {
            ds = new DataSet();
            string sql = "Select MAMH, MALOAI, TENMH, DVT, DONGIA, SOLUONGTON from MATHANG";
            da = new SqlDataAdapter(sql, connsql);
            da.Fill(ds, "MATHANG");
            dgvSanPham.DataSource = ds.Tables["MATHANG"];
        }
        private void QLSanPham_Load(object sender, EventArgs e)
        {
            cboTimKiem.Text = "Mã Mặt Hàng";
            Load_DgvSanPham();
            connsql.Close();
        }

        private void picThem_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text.Trim().Length == 0 || txtTenMH.Text.Trim().Length == 0 || txtLoaiMH.Text.Trim().Length == 0 || txtDVT.Text.Trim().Length ==0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            String sqlInsert = string.Format("INSERT INTO MATHANG (MAMH, MALOAI, TENMH, DVT, SOLUONGTON, DONGIA) Values('{0}','{1}',N'{2}',N'{3}','{4}','{5}')", txtMaMH.Text.ToString(), txtLoaiMH.Text.ToString(), txtTenMH.Text.ToString(), txtDVT.Text.ToString(), nUDSoLuong.Value, nUDDonGiaBan.Value);
            string sql = "select count(*) from MATHANG where MAMH='" + txtMaMH.Text + "'";
            if (kn.checkkey(sql) == true)
            {
                try
                {
                    //dgv.DataSource = kt.taobang(sqlInsert);
                    SqlCommand cmd = new SqlCommand(sqlInsert, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    Load_DgvSanPham();
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
                MessageBox.Show("Trùng mã mặt hàng, vui lòng nhập lại!!!", "Thông báo");
                return;
            }
        }

        private void picSua_Click(object sender, EventArgs e)
        {
            if (txtTenMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã mặt hàng", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            try
            {
                string updatestr;
                updatestr = "update MATHANG set MALOAI = '" + txtLoaiMH.Text + "', TENMH = N'" + txtTenMH.Text + "', DVT = N'" + txtDVT.Text + "', DONGIA = '" + nUDDonGiaBan.Value.ToString() + "', SOLUONGTON = '" + nUDSoLuong.Value.ToString() + "'where MAMH='" + txtMaMH.Text + "'";
                SqlCommand cmd = new SqlCommand(updatestr, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                Load_DgvSanPham();
                MessageBox.Show("Sửa Thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Sửa Thất bại", "Thông báo");
            }
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã mặt hàng", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            try
            {
                string deletestr;
                deletestr = "delete MATHANG where MAMH ='" + txtMaMH.Text + "'";
                SqlCommand cmd = new SqlCommand(deletestr, connsql);
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    Load_DgvSanPham();
                    MessageBox.Show("Xoá Thành công", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Xoá Thất bại", "Thông báo");
            }
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSanPham.SelectedRows[0];
                txtMaMH.Text = row.Cells["MAMH"].Value.ToString();
                txtLoaiMH.Text = row.Cells["MALOAI"].Value.ToString();
                txtTenMH.Text = row.Cells["TENMH"].Value.ToString();
                txtDVT.Text = row.Cells["DVT"].Value.ToString();
                nUDDonGiaBan.Text = row.Cells["DONGIA"].Value.ToString();
                nUDSoLuong.Text = row.Cells["SOLUONGTON"].Value.ToString();
            }
        }
        public DataTable XemDL(string sql)
        {
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            SqlDataAdapter adap = new SqlDataAdapter(sql, connsql);
            DataTable dt = new DataTable();
            adap.Fill(dt); 
            if (connsql.State == ConnectionState.Open)
            {
                connsql.Close();
            }
            return dt;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cboTimKiem.Text=="Mã Mặt Hàng")
            {
                dgvSanPham.DataSource = XemDL("select * from MATHANG where MAMH like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            else if (cboTimKiem.Text == "Tên Mặt Hàng")
            {
                dgvSanPham.DataSource = XemDL("select * from MATHANG where TENMH like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "Mã Mặt Hàng")
            {
                dgvSanPham.DataSource = XemDL("select * from MATHANG where MAMH like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            else if (cboTimKiem.Text == "Tên Mặt Hàng")
            {
                dgvSanPham.DataSource = XemDL("select * from MATHANG where TENMH like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
        }
    }
}
