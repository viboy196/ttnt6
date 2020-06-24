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
    public partial class frmDoiMK : Form
    {
        public frmDoiMK(string name)
        {
            InitializeComponent();
            lblNameUser.Text = name;
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            QLDiemTableAdapters.QueriesTableAdapter ds = new QLDiemTableAdapters.QueriesTableAdapter();
            if (ds.DangNhap(lblNameUser.Text, txtMKCu.Text) == 1)
            {
                if (txtMKMoi.Text.Length != 0 && txtMKMoi.Text == txtRepeat.Text)
                {
                    KetNoiDB.ExcuteNonQR("UPDATE    DangNhap SET  MatKhau ='" + txtMKMoi.Text + "'where TenDN='" + lblNameUser.Text + "'");
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
  

