using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDIEM
{
    public partial class frmDangNhap : Form
    {
       
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            var username = txtTenDangNhap.Text;
            var password = txtMatKhau.Text;
            string sql = "select * from DangNhap where TenDN='" + username + "' and MatKhau = '" + password + "'";
            var dt = KetNoiDB.Getdatatable(sql);
            if ((txtTenDangNhap.Text.Length==0) || (txtMatKhau.Text.Length==0))
            {
                MessageBox.Show("Bạn chưa nhập tên hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    frmQL_Diem frm = new frmQL_Diem(txtTenDangNhap.Text);
                    frm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK);
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    txtTenDangNhap.Focus();
                }
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
