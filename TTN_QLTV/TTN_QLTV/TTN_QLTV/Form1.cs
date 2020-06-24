using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QLTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Sach frm = new Sach();
            frm.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            NhuCauMuonSach frm = new NhuCauMuonSach();
            frm.Show();
        }

        private void chiTiếtMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DocGia frm = new DocGia();
            frm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            NhanVien frm = new NhanVien();
            frm.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            TacGia frm = new TacGia();
            frm.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            TheLoai frm = new TheLoai();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult bt = MessageBox.Show("Bạn muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (bt == DialogResult.OK)
                Application.Exit();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            TaiKhoan frm = new TaiKhoan();
            frm.Show();
        }
    }
}
