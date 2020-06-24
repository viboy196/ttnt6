using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhachSan.Model;
using QLKhachSan.DAO;

namespace QLKhachSan
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            dtgKhachHang.DataSource = new KHDao().DSKh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string GT = "";
            if(rbNam.Checked)
            {
                GT = "nam";
            }
            if (rbNu.Checked)
            {
                GT = "nữ";
            }
            int c = new KHDao().addKH(new KHACHHANG { MaKH = Int32.Parse(txtMaKH.Text), TenKH = txtTenKH.Text, GioiTinh = GT,NgaySinh = dateTimePickerNS.Value , DiaChi = txtDiaChi.Text, SoDT = txtSDT.Text , CMT = txtCMND.Text, GhiChu = txtGhiChu.Text });
            if (c > 0)
            {
                MessageBox.Show("Thêm thành công !");
                dtgKhachHang.DataSource = new KHDao().DSKh();
            } else
                MessageBox.Show("Thêm không thành công !");
        }

        private void dtgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            int numrow;
            numrow = e.RowIndex;
            txtMaKH.Text = dtgKhachHang.Rows[numrow].Cells[0].Value.ToString();
            txtTenKH.Text = dtgKhachHang.Rows[numrow].Cells[1].Value.ToString();
            if (dtgKhachHang.Rows[numrow].Cells[2].Value.ToString().Equals("nam"))
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
            dateTimePickerNS.Value = Convert.ToDateTime(dtgKhachHang.Rows[numrow].Cells[3].Value.ToString());
            txtDiaChi.Text = dtgKhachHang.Rows[numrow].Cells[4].Value.ToString();
            txtSDT.Text = dtgKhachHang.Rows[numrow].Cells[5].Value.ToString();
            txtCMND.Text = dtgKhachHang.Rows[numrow].Cells[6].Value.ToString();
            txtGhiChu.Text = dtgKhachHang.Rows[numrow].Cells[7].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string GT = "";
            if (rbNam.Checked)
            {
                GT = "nam";
            }
            if (rbNu.Checked)
            {
                GT = "nữ";
            }
            bool c = new KHDao().xoaKH(Int32.Parse(txtMaKH.Text));
            if (c)
            {
                MessageBox.Show("Xóa thành công !");
                dtgKhachHang.DataSource = new KHDao().DSKh();
                txtMaKH.Text = "";
                txtTenKH.Text = "";
                rbNam.Checked = true;
                dateTimePickerNS.Value = DateTime.Now;
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtCMND.Text = "";
                txtGhiChu.Text = "";

                dtgKhachHang.DataSource = new KHDao().DSKh();
            }
            else
                MessageBox.Show("Xóa không thành công !");
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string GT = "";
            if (rbNam.Checked)
            {
                GT = "nam";
            }
            if (rbNu.Checked)
            {
                GT = "nữ";
            }
            bool c = new KHDao().updateKH(new KHACHHANG { MaKH = Int32.Parse(txtMaKH.Text), TenKH = txtTenKH.Text, GioiTinh = GT, NgaySinh = dateTimePickerNS.Value, DiaChi = txtDiaChi.Text, SoDT = txtSDT.Text, CMT = txtCMND.Text, GhiChu = txtGhiChu.Text });
            if(c)
            {
                MessageBox.Show("Cập nhật thành công !");
                dtgKhachHang.DataSource = new KHDao().DSKh();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại !");              
            }
        }
    }
}
