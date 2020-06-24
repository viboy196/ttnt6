using QLKhachSan.Model;
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
    public partial class FormDichVu : Form
    {
        public FormDichVu()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            DataTable da = new DichVuDao().DSDV();

            dgvDV.DataSource = da;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int c = new DichVuDao().addDV(new DICHVU { MaDV = Int32.Parse(txtMaDV.Text), TenDichVu = txtTenDV.Text, Gia = float.Parse(txtGia.Text)});
            if (c > 0)
            {
                MessageBox.Show("Thêm thành công !");
                dgvDV.DataSource = new DichVuDao().DSDV();
            }
            else
                MessageBox.Show("Thêm không thành công !");
        }

        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaDV.Text = dgvDV.Rows[numrow].Cells[0].Value.ToString();
            txtTenDV.Text = dgvDV.Rows[numrow].Cells[1].Value.ToString();
            txtGia.Text = dgvDV.Rows[numrow].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool c = new DichVuDao().updateDV(new DICHVU { MaDV = Int32.Parse(txtMaDV.Text), TenDichVu = txtTenDV.Text, Gia = float.Parse(txtGia.Text) });
            if (c)
            {
                MessageBox.Show("Cập nhật thành công !");
                dgvDV.DataSource = new DichVuDao().DSDV();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool c = new DichVuDao().xoaDV(Int32.Parse(txtMaDV.Text));
            if (c)
            {
                MessageBox.Show("Xóa thành công !");                
                txtMaDV.Text = "";
                txtTenDV.Text = "";
                txtGia.Text = "";

                dgvDV.DataSource = new DichVuDao().DSDV();
            }
            else
                MessageBox.Show("Xóa không thành công !");
        }
    }
}
