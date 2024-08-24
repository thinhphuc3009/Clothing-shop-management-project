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
    public partial class QLNhanVien : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        KetNoi kn = new KetNoi();
        SqlConnection connsql;
        public QLNhanVien()
        {
            InitializeComponent();
            connsql = kn.con;
        }
        
        void Load_ComboBox()
        {
            ds = new DataSet();

            string strselect = "Select DISTINCT CHUCVU from NHANVIEN";
            da = new SqlDataAdapter(strselect, connsql);
            da.Fill(ds, "NHANVIEN");

            // Tạo một danh sách mới để lưu trữ các giá trị VAITRO không trùng nhau
            List<string> values = new List<string>();

            // Duyệt qua danh sách VAITRO trong dataset
            foreach (DataRow row in ds.Tables["NHANVIEN"].Rows)
            {
                // Lấy giá trị VAITRO từ dataset
                string value = row["CHUCVU"].ToString();

                // Kiểm tra xem giá trị VAITRO đã có trong danh sách hay chưa
                if (!values.Contains(value))
                {
                    // Nếu giá trị VAITRO chưa có trong danh sách thì thêm giá trị đó vào danh sách
                    values.Add(value);
                }
            }

            // Gán danh sách VAITRO không trùng nhau cho combobox
            cbmVaiTro.DataSource = values;
            cbmVaiTro.DisplayMember = "CHUCVU";
        }
        void Load_DgvNhanVien()
        {
            foreach (Control control in dgvNhanVien.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;

                    // Làm gì đó với radiobutton
                }
            }
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("Select MANV, TENNV, DIACHI, SDT, GIOITINH, CHUCVU from NHANVIEN", connsql);
            da1.Fill(ds1, "NHANVIEN");
            dgvNhanVien.DataSource = ds1.Tables["NHANVIEN"];
        }
        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            cboTimKiem.Text = "Mã Nhân Viên";
            Load_ComboBox();
            Load_DgvNhanVien();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            string sex = radioButtonNam.Checked ? "Nam" : "Nữ";
            if (textManv.Text.Trim().Length == 0 || textTennv.Text.Trim().Length == 0 || textBoxphone.Text.Trim().Length == 0 || textAddress.Text.Trim().Length == 0|| txtUserName.Text.Trim().Length == 0|| textBoxPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            String sqlInsert = string.Format("Insert into NHANVIEN(MANV, TENNV, DIACHI, SDT, GIOITINH, TENDN, MATKHAU, CHUCVU) Values('{0}',N'{1}',N'{2}','{3}',N'{4}','{5}','{6}', N'{7}')", textManv.Text.ToString(), textTennv.Text.ToString(), textAddress.Text.ToString(),textBoxphone.Text.ToString(),sex.ToString(), txtUserName.Text.ToString(), textBoxPass.Text.ToString(), cbmVaiTro.SelectedValue);
            string sql = "select count(*) from NHANVIEN where MANV='" + textManv.Text + "'";
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

        private void Sua_Click(object sender, EventArgs e)
        {
            string sex = radioButtonNam.Checked ? "Nam" : "Nữ";
            if (textManv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            try
            {
                string updatestr;
                updatestr = "update NHANVIEN set TENNV = N'" + textTennv.Text + "', DIACHI = N'" + textAddress.Text + "', SDT = '" + textBoxphone.Text + "', GIOITINH = N'" + sex.ToString() + "', TENDN = '" + txtUserName.Text + "', MATKHAU = '" + textBoxPass.Text + "', CHUCVU = N'" + cbmVaiTro.Text + "'where MANV='" + textManv.Text + "'";
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

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (textManv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo");
                return;
            }
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            try
            {
                string deletestr;
                deletestr = "delete NHANVIEN where MANV ='" + textManv.Text + "'";
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

        private void cbmVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvNhanVien.SelectedRows[0];
                textManv.Text = row.Cells["MANV"].Value.ToString();
                textTennv.Text = row.Cells["TENNV"].Value.ToString();
                textAddress.Text = row.Cells["DIACHI"].Value.ToString();
                textBoxphone.Text = row.Cells["SDT"].Value.ToString();
                if (row.Cells["GIOITINH"].Value.ToString() == "Nam")
                    radioButtonNu.Checked = row.Cells["GIOITINH"].Value.ToString() == "Nam";
                else if (row.Cells["GIOITINH"].Value.ToString() == "Nữ")
                    radioButtonNam.Checked = row.Cells["GIOITINH"].Value.ToString() == "Nữ";
                //txtUserName.Text = row.Cells["TENDN"].Value.ToString();
                //textBoxPass.Text = row.Cells["MATKHAU"].Value.ToString();
                cbmVaiTro.Text = row.Cells["CHUCVU"].Value.ToString();
            }
        }

        private void cbHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMK.Checked)
            {
                textBoxPass.PasswordChar = (char)0;
            }
            else
            {
                textBoxPass.PasswordChar = '*';
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
            if (cboTimKiem.Text == "Mã Nhân Viên")
            {
                dgvNhanVien.DataSource = XemDL("select * from NHANVIEN where MANV like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            else if (cboTimKiem.Text == "Tên Nhân Viên")
            {
                dgvNhanVien.DataSource = XemDL("select * from NHANVIEN where TENNV like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            else if (cboTimKiem.Text == "Vai Trò")
            {
                dgvNhanVien.DataSource = XemDL("select * from NHANVIEN where CHUCVU like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "Mã Nhân Viên")
            {
                dgvNhanVien.DataSource = XemDL("select * from NHANVIEN where MANV like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            else if (cboTimKiem.Text == "Tên Nhân Viên")
            {
                dgvNhanVien.DataSource = XemDL("select * from NHANVIEN where TENNV like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            else if (cboTimKiem.Text == "Vai Trò")
            {
                dgvNhanVien.DataSource = XemDL("select * from NHANVIEN where CHUCVU like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
