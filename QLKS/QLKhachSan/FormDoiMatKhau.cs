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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
            lblTenDN.Text = FormLogin.tenDN;
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if(txtMKC.Text != "" && txtMKM.Text != "" && txtNLMKM.Text != "")
            {
                if (txtMKC.Text.Equals(FormLogin.matKhau))
                {
                    if(txtMKM.Text.Equals(txtNLMKM.Text))
                    {
                        bool c = new MainDao().updatePass(FormLogin.tenDN, txtMKM.Text);
                        if (c)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công ");
                            FormLogin.matKhau = txtMKM.Text;
                        }
                        else
                        {
                            MessageBox.Show("Đổi thất bại !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu không đúng !");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin !");
            }
        }
    }
}
