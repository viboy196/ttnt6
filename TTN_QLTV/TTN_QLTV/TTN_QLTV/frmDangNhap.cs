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
namespace TTN_QLTV
{
    public partial class frmDangNhap : Form
    {

        string Strcon = @"Data Source=localhost;Initial Catalog=QLTV_LOAN;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(Strcon);
                conn.Open();
                string sql = "select count(*)  from TaiKhoan where Usename=@taikhoan and Password= @matkhau";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@taikhoan", txtten.Text));
                cmd.Parameters.Add(new SqlParameter("@matkhau", txtmatkhau.Text));

                int x = (int)cmd.ExecuteScalar();
                if (x == 1)
                {
                    // MessageBox.Show("thành công");
                    this.Hide();
                    Form1 fm = new Form1();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập thất bại");
                    txtten.Text = "";
                    txtmatkhau.Text = "";
                    txtten.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult bt = MessageBox.Show("Bạn muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (bt == DialogResult.OK)
                Application.Exit();

        }

        private void ckhienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckhienthi.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
        }
    }
}
