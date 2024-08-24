using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Nhom13_QLShopBanQuanAo.Forms;

namespace Nhom13_QLShopBanQuanAo
{
    public class KetNoi
    {
        //public SqlConnection con;
        //public KetNoi()
        //{
        //    con = new SqlConnection("Data Source = DESKTOP - 0FBHG0N\\SQLEXPRESS; Initial Catalog = QL_ShopBanQA; Integrated Security = True");
        //}
        //public KetNoi(string strcn)
        //{
        //    con = new SqlConnection(strcn);
        //}
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-0FBHG0N\\SQLEXPRESS;Initial Catalog=clothst;Integrated Security=True");
        public bool checkkey(string s)
        {
            SqlCommand cmd = new SqlCommand(s, con);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
                return false;
            else
                return true;
        }
        public bool checkkey2(string s)
        {
            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                rd.Close();
                return false;
            }
            else
            {
                rd.Close();
                return true;
            }
        }
        public bool checkkey3(string sql)
        {

            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return false;
            else
                return true;

        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
