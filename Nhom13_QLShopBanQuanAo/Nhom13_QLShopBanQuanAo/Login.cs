using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System;
using System.Drawing;
using Nhom13_QLShopBanQuanAo.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace Nhom13_QLShopBanQuanAo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0FBHG0N\\SQLEXPRESS;Initial Catalog=clothst;Integrated Security=True");



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
           );


        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2
                );
            panel1.Anchor = AnchorStyles.None;
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseDown_1(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        public void checkdn()
        {
            conn.Open();
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == null || password == null)
                MessageBox.Show("Vui lòng không để trống");
            string sql = "select * FROM NHANVIEN WHERE TENDN = N'" + username + "'AND MATKHAU = N'" + password + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read() == true)
            {

                string role = dt.GetString(dt.GetOrdinal("tendn"));
                MessageBox.Show("Đăng nhập thành công");
                MainMenu fr = new MainMenu(role);
                this.Hide();
                fr.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            conn.Close();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            checkdn();
        }

        private void pictureBox5_MouseDown_2(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox5_MouseUp_1(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}