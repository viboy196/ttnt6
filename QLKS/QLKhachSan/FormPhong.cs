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
    public partial class FormPhong : Form
    {
        public FormPhong()
        {
            InitializeComponent();
            Load();

        }

        public void Load()
        {
            DataTable dt = new PhongDao().DSLoaiPhong();
            cbLoaiPhong.DataSource = dt;
            cbLoaiPhong.ValueMember = "MaLoai";
            cbLoaiPhong.DisplayMember = "TenLoai";

            dgvLoaiPhong.DataSource = dt;

            dgvPhong.DataSource = new PhongDao().DSPhong();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaPhong.Text = dgvPhong.Rows[numrow].Cells[0].Value.ToString();
            cbLoaiPhong.SelectedIndex =Int32.Parse(dgvPhong.Rows[numrow].Cells[1].Value.ToString()) - 1;          
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaLoai.Text = dgvLoaiPhong.Rows[numrow].Cells[0].Value.ToString();
            txtTenLoai.Text = dgvLoaiPhong.Rows[numrow].Cells[1].Value.ToString();
            txtSoNguoi.Text = dgvLoaiPhong.Rows[numrow].Cells[2].Value.ToString();
            txtGia.Text = dgvLoaiPhong.Rows[numrow].Cells[3].Value.ToString();

        }

        private void btnThemLP_Click(object sender, EventArgs e)
        {
            int c = new PhongDao().addLP(new LOAIPHONG { MaLoai =Int32.Parse(txtMaLoai.Text) , TenLoai = txtTenLoai.Text, SoNguoi = Int32.Parse(txtSoNguoi.Text), Gia = float.Parse(txtGia.Text)});
            if (c > 0)
            {
                MessageBox.Show("Thêm thành công !");
                dgvLoaiPhong.DataSource = new PhongDao().DSLoaiPhong();
            }
            else
                MessageBox.Show("Thêm không thành công !");
        }

        private void btnXoaLP_Click(object sender, EventArgs e)
        {
            bool c = new PhongDao().xoaLP(Int32.Parse(txtMaLoai.Text));
            if (c)
            {
                MessageBox.Show("Xóa thành công !");
                dgvLoaiPhong.DataSource = new PhongDao().DSLoaiPhong();
                txtMaLoai.Text = "";
                txtTenLoai.Text = "";
                txtSoNguoi.Text = "";
                txtGia.Text = "";

                dgvLoaiPhong.DataSource = new PhongDao().DSLoaiPhong();
            }
            else
                MessageBox.Show("Xóa không thành công !");
        }

        private void btnSuaLP_Click(object sender, EventArgs e)
        {
            bool c = new PhongDao().updateLP(new LOAIPHONG { MaLoai = Int32.Parse(txtMaLoai.Text), TenLoai = txtTenLoai.Text, SoNguoi = Int32.Parse(txtSoNguoi.Text), Gia = float.Parse(txtGia.Text) });
            if (c)
            {
                MessageBox.Show("Cập nhật thành công !");
                dgvLoaiPhong.DataSource = new PhongDao().DSLoaiPhong();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại !");
            }
        }

        private void btnThemP_Click(object sender, EventArgs e)
        {
            int c = new PhongDao().addPhong(new PHONG { MaPhong = Int32.Parse(txtMaPhong.Text), idLoaiPhong = Int32.Parse(cbLoaiPhong.SelectedValue.ToString()), TinhTrang = "Trong"});
            if (c > 0)
            {
                MessageBox.Show("Thêm thành công !");
                dgvPhong.DataSource = new PhongDao().DSPhong();
            }
            else
                MessageBox.Show("Thêm không thành công !");
        }

        private void btnXoaP_Click(object sender, EventArgs e)
        {
            bool c = new PhongDao().xoaPhong(Int32.Parse(txtMaPhong.Text));
            if (c)
            {
                MessageBox.Show("Xóa thành công !");
                dgvPhong.DataSource = new PhongDao().DSPhong();
                txtMaPhong.Text = "";
                txtTenLoai.Text = "";

                dgvPhong.DataSource = new PhongDao().DSPhong();
            }
            else
                MessageBox.Show("Xóa không thành công !");
        }

        private void btnSuaP_Click(object sender, EventArgs e)
        {
            bool c = new PhongDao().updatePhong(new PHONG { MaPhong = Int32.Parse(txtMaPhong.Text), idLoaiPhong = Int32.Parse(cbLoaiPhong.SelectedValue.ToString()), TinhTrang = "Trong" });
            if (c)
            {
                MessageBox.Show("Cập nhật thành công !");
                dgvPhong.DataSource = new PhongDao().DSPhong();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại !");
            }
        }
    }
}
