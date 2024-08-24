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
    public partial class DatHang : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        KetNoi kn = new KetNoi();
        SqlConnection connsql;
        public DatHang()
        {
            InitializeComponent();
            connsql = kn.con;
        }

        void Load_DgvHD()
        {
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from DONDATHANG", connsql);
            da1.Fill(ds1, "DONDATHANG");
            dgvHD.DataSource = ds1.Tables["DONDATHANG"];
        }

        private void DatHang_Load(object sender, EventArgs e)
        {
            Load_DgvHD();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            TTKhachHang KH = new TTKhachHang();
            this.Hide();
            KH.ShowDialog();
            this.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
        }

        private void cbmMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDDH.Text.Trim().Length == 0 || txtMaNCC.Text.Trim().Length == 0 || txtMaNV.Text.Trim().Length == 0 || txtNgayLap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            String sqlInsert = string.Format("Insert into DONDATHANG Values('{0}','{1}','{2}','{3}')", txtMaDDH.Text.ToString(), txtMaNCC.Text.ToString(), txtMaNV.Text.ToString(), txtNgayLap.Text.ToString());
            string sql = "select count(*) from DONDATHANG where MADDH='" + txtMaDDH.Text + "'";
            if (kn.checkkey(sql) == true)
            {
                try
                {
                    //dgv.DataSource = kt.taobang(sqlInsert);
                    SqlCommand cmd = new SqlCommand(sqlInsert, connsql);
                    cmd.ExecuteNonQuery();
                    Load_DgvHD();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDDH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            try
            {
                string updatestr;
                updatestr = "update DONDATHANG set MANCC = N'" + txtMaNCC.Text + "', MANV = N'" + txtMaNV.Text + "', NGAYLAP = '" + txtNgayLap.Text + "'where MADDH='" + txtMaDDH.Text + "'";
                SqlCommand cmd = new SqlCommand(updatestr, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                Load_DgvHD();
                MessageBox.Show("Sửa Thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Sửa Thất bại", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDDH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            try
            {
                string deletestr;
                deletestr = "delete DONDATHANG where MADDH ='" + txtMaDDH.Text + "'";
                SqlCommand cmd = new SqlCommand(deletestr, connsql);
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    Load_DgvHD();
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
