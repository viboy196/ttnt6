using QLKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class FormLogin : Form
    {
        public static string tenDN;
        public static string matKhau;
        public static string quyen;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            LoginDao loginDao = new LoginDao();
            bool c = loginDao.check(txtTenDN.Text, txtMatKhau.Text);
            if(c == true)
            {
                FormMain f = new FormMain();
                
                this.Hide();           
                tenDN = txtTenDN.Text;
                matKhau = txtMatKhau.Text;
                DataTable dt = loginDao.quyen(tenDN);
                DataRow dr = dt.Rows[0];
                int d = Int32.Parse(dr["idChucVu"].ToString());
                if (d == 1)
                {
                    quyen = "admin";
                }
                else
                {
                    quyen = "nhanvien";
                }
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !", "Thong bao");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat chuong trinh", "Thong bao", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
