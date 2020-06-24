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
    public partial class frmQL_Diem : Form
    {
       
        public frmQL_Diem(string name)
        {
            InitializeComponent();
            lblNguoiDung.Text = name;
        }

        private void thôngTinLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmMonHoc frm = new frmMonHoc();
           frm.ShowDialog();
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiemKyI frm = new frmDiemKyI();
            frm.ShowDialog();
        }

        private void frmQL_Diem_Load(object sender, EventArgs e)
        {
          
        }

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHocSinh frm = new frmHocSinh();
            frm.ShowDialog();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaoVien frm = new frmGiaoVien();
            frm.ShowDialog();
        }

        private void thôngTinLớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDiemK2 frm = new frmDiemK2();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýĐiểmKỳIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop frm = new frmLop();
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMK frm = new frmDoiMK(lblNguoiDung.Text);
            frm.ShowDialog();
        }

        private void điểmKỳIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BCKyI frm = new BCKyI();
            frm.ShowDialog();
        }

        private void hạnhKiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void điểmKỳIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BCKyII frm = new BCKyII();
            frm.ShowDialog();
        }
    }
}
