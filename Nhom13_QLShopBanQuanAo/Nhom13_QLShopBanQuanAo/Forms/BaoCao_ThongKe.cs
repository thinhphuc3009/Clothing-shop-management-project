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
    public partial class BaoCao_ThongKe : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        KetNoi kn = new KetNoi();
        SqlConnection connsql;
        public BaoCao_ThongKe()
        {
            InitializeComponent();
            connsql = kn.con;
        }
        void Load_DgvBaoCao_ThongKe()
        {
            ds = new DataSet();
            string sql = "SELECT m.TENMH, ct.SOLUONG,hd.NGAYLAP, m.DONGIA, ct.SOLUONG* m.DONGIA AS 'Doanh Thu' FROM CT_HOADON ct JOIN MATHANG m ON ct.MAMH = m.MAMH JOIN HOADON hd ON ct.MAHD = hd.MAHD";
            da = new SqlDataAdapter(sql, connsql);
            da.Fill(ds, "MATHANG_CT_HD_HOADON");
            dgvThongKe.DataSource = ds.Tables["MATHANG_CT_HD_HOADON"];

        }
        void Load_DgvTongDoanhThu()
        {
            ds = new DataSet();
            string sql = "SELECT SUM(ct.SOLUONG) AS N'Tổng Số Lượng', SUM(ct.SOLUONG * m.DONGIA) AS 'Tổng Doanh Thu' FROM CT_HOADON ct JOIN MATHANG m ON ct.MAMH = m.MAMH JOIN HOADON hd ON ct.MAHD = hd.MAHD";
            da = new SqlDataAdapter(sql, connsql);
            da.Fill(ds, "MATHANG_CT_HD_HOADON");
            dgvSoLuong_DoanhThu.DataSource = ds.Tables["MATHANG_CT_HD_HOADON"];

        }
        void Load_DgvTongSL_DTTheoNgay()
        {
            DateTime value = dtpNgayBD.Value;
            DateTime value1 = dtpNgayKT.Value;
            DateTime newDateTimeFrom = new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second);
            DateTime newDateTimeTo = new DateTime(value1.Year, value1.Month, value1.Day, value1.Hour, value1.Minute, value1.Second);
            ds = new DataSet();
            string sql = "SELECT CONVERT(VARCHAR(10), hd.NGAYLAP, 101) AS NGAYLAP, SUM(ct.SOLUONG) AS N'Tổng số lượng', SUM(ct.SOLUONG * m.DONGIA) AS N'Tổng doanh thu' FROM CT_HOADON ct JOIN MATHANG m ON ct.MAMH = m.MAMH JOIN HOADON hd ON ct.MAHD = hd.MAHD WHERE hd.NGAYLAP BETWEEN '" + newDateTimeFrom + "' AND '" + newDateTimeTo + "' GROUP BY CONVERT(VARCHAR(10), hd.NGAYLAP, 101) ORDER BY NGAYLAP";
            da = new SqlDataAdapter(sql, connsql);
            da.Fill(ds, "MATHANG_CT_HD_HOADON");
            dgvSoLuong_DoanhThu.DataSource = ds.Tables["MATHANG_CT_HD_HOADON"];

        }
        void Load_DgvDoanhThuTheoNgay()
        {
            DateTime value = dtpNgayBD.Value;
            DateTime value1 = dtpNgayKT.Value;
            DateTime newDateTimeFrom = new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second);
            DateTime newDateTimeTo = new DateTime(value1.Year, value1.Month, value1.Day, value1.Hour, value1.Minute, value1.Second);
            ds = new DataSet();
            string sql = "SELECT m.TENMH, ct.SOLUONG, hd.NGAYLAP, m.DONGIA, ct.SOLUONG* m.DONGIA AS 'Doanh Thu' FROM CT_HOADON ct JOIN MATHANG m ON ct.MAMH = m.MAMH JOIN HOADON hd ON ct.MAHD = hd.MAHD WHERE hd.NGAYLAP BETWEEN '" + newDateTimeFrom + "' AND '" + newDateTimeTo + "'";
            da = new SqlDataAdapter(sql, connsql);
            da.Fill(ds, "MATHANG_CT_HD_HOADON");
            dgvThongKe.DataSource = ds.Tables["MATHANG_CT_HD_HOADON"];
        }


        private void BaoCao_ThongKe_Load(object sender, EventArgs e)
        {
            Load_DgvBaoCao_ThongKe();
            Load_DgvTongDoanhThu();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (rdoMacDinh.Checked)
            {
                Load_DgvBaoCao_ThongKe();
                Load_DgvTongDoanhThu();
            }
            else
            {
                Load_DgvDoanhThuTheoNgay();
                Load_DgvTongSL_DTTheoNgay();
            }
        }
    }
}
