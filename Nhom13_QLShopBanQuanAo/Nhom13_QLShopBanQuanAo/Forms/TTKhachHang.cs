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
    public partial class TTKhachHang : Form
    {

        SqlDataAdapter da;
        DataSet ds;
        KetNoi kn = new KetNoi();
        SqlConnection connsql;
        public TTKhachHang()
        {
            InitializeComponent();
            connsql = kn.con;
        }
        public void loadatagrid()
        {
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from KHACHHANG", connsql);
            da1.Fill(ds1, "KHACHHANG");
            dgvKH.DataSource = ds1.Tables["KHACHHANG"];
        }

        private void TTKhachHang_Load(object sender, EventArgs e)
        {
            loadatagrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (makh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            try
            {
                string deletestr;
                deletestr = "delete KHACHHANG where MAKH ='" + makh.Text + "'";
                SqlCommand cmd = new SqlCommand(deletestr, connsql);
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    loadatagrid();
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

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvKH.Rows[e.RowIndex];
            makh.Text = Convert.ToString(row.Cells[0].Value);
            tenkh.Text = Convert.ToString(row.Cells[1].Value);
            diachi.Text = Convert.ToString(row.Cells[3].Value);
            sdt.Text = Convert.ToString(row.Cells[2].Value);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (makh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã mặt hàng", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            try
            {
                string updatestr;
                updatestr = "update KHACHHANG set TENKH = N'" + tenkh.Text + "', DIACHI = N'" + diachi.Text + "', SDT = '" + sdt.Text + "'where MAKH='" + makh.Text + "'";
                SqlCommand cmd = new SqlCommand(updatestr, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                loadatagrid();
                MessageBox.Show("Sửa Thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Sửa Thất bại", "Thông báo");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvKH.DataSource = XemDL("select * from KHACHHANG where TENKH like N'%" + search.Text.Trim() + "%'");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (makh.Text.Trim().Length == 0 || tenkh.Text.Trim().Length == 0 || diachi.Text.Trim().Length == 0 || sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            String sqlInsert = string.Format("Insert into KHACHHANG Values('{0}',N'{1}',N'{2}','{3}')", makh.Text.ToString(), tenkh.Text.ToString(), diachi.Text.ToString(), sdt.Text.ToString());
            string sql = "select count(*) from KHACHHANG where MAKH='" + makh.Text + "'";
            if (kn.checkkey(sql) == true)
            {
                try
                {
                    //dgv.DataSource = kt.taobang(sqlInsert);
                    SqlCommand cmd = new SqlCommand(sqlInsert, connsql);
                    cmd.ExecuteNonQuery();
                    loadatagrid();
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

        private void search_TextChanged(object sender, EventArgs e)
        {
            dgvKH.DataSource = XemDL("select * from KHACHHANG where TENKH like N'%" + search.Text.Trim() + "%'");
        }
    }
}
