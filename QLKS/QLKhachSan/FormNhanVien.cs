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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            Load();

        }

        public void Load()
        {
            DataTable dt = new NhanVienDao().DSNV();

            dgvDSNV.DataSource = dt;

            DataTable da = new NhanVienDao().DSCV();
            cbChucVu.DataSource = da;
            cbChucVu.ValueMember = "MaCV";
            cbChucVu.DisplayMember = "TenCV";
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int numrow;
                numrow = e.RowIndex;
                txtMaNV.Text = dgvDSNV.Rows[numrow].Cells[0].Value.ToString();
                cbChucVu.SelectedIndex = Int32.Parse(dgvDSNV.Rows[numrow].Cells[1].Value.ToString()) - 1;
                txtTenNV.Text = dgvDSNV.Rows[numrow].Cells[2].Value.ToString();
                if (dgvDSNV.Rows[numrow].Cells[3].Value.ToString().Equals("nam"))
                {
                    rbNam.Checked = true;
                }
                else
                {
                    rbNu.Checked = true;
                }
                dtpNS.Value = Convert.ToDateTime(dgvDSNV.Rows[numrow].Cells[4].Value.ToString());
                txtDiaChi.Text = dgvDSNV.Rows[numrow].Cells[5].Value.ToString();
                txtSoDT.Text = dgvDSNV.Rows[numrow].Cells[6].Value.ToString();
                txtCMND.Text = dgvDSNV.Rows[numrow].Cells[7].Value.ToString();
                txtTenDN.Text = dgvDSNV.Rows[numrow].Cells[8].Value.ToString();
                txtMK.Text = dgvDSNV.Rows[numrow].Cells[9].Value.ToString();
            }
            catch
            {
                txtMaNV.Text = "";
                cbChucVu.SelectedIndex = 0;
                txtTenNV.Text = "";
                txtDiaChi.Text = "";
                txtSoDT.Text = "";
                txtCMND.Text = "";
                txtTenDN.Text = "";
                txtMK.Text = "";
                MessageBox.Show("Vui lòng chọn nhân viên !", "Thong bao");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
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
            int c = new NhanVienDao().addNV(new NHANVIEN { MaNV = Int32.Parse(txtMaNV.Text),idChucVu = Int32.Parse(cbChucVu.SelectedValue.ToString()), TenNV = txtTenNV.Text, GioiTinh = GT, NgaySinh = dtpNS.Value, DiaChi = txtDiaChi.Text, SoDT = txtSoDT.Text, CMT = txtCMND.Text, TenDangNhap = txtTenDN.Text, MatKhau = txtMK.Text });
            if (c > 0)
            {
                MessageBox.Show("Thêm thành công !", "Thông báo");
                dgvDSNV.DataSource = new NhanVienDao().DSNV();
            }
            else if (c == 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại !", "Thông báo");
            }
            else
                MessageBox.Show("Thêm không thành công !", "Thông báo");
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
            bool c = new NhanVienDao().updateNV(new NHANVIEN { MaNV = Int32.Parse(txtMaNV.Text), idChucVu = Int32.Parse(cbChucVu.SelectedValue.ToString()), TenNV = txtTenNV.Text, GioiTinh = GT, NgaySinh = dtpNS.Value, DiaChi = txtDiaChi.Text, SoDT = txtSoDT.Text, CMT = txtCMND.Text, TenDangNhap = txtTenDN.Text, MatKhau = txtMK.Text });
            if (c)
            {
                MessageBox.Show("Cập nhật thành công !", "Thông báo");
                dgvDSNV.DataSource = new NhanVienDao().DSNV();
            }
           
            else
                MessageBox.Show("Thêm không thành công !", "Thông báo");
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
            bool c = new NhanVienDao().xoaNV(Int32.Parse(txtMaNV.Text));
            if (c)
            {
                MessageBox.Show("Xóa thành công !");
                txtMaNV.Text = "";
                txtTenNV.Text = "";
                rbNam.Checked = true;
                dtpNS.Value = DateTime.Now;
                txtDiaChi.Text = "";
                txtSoDT.Text = "";
                txtCMND.Text = "";
                txtTenDN.Text = "";
                txtMK.Text = "";

                dgvDSNV.DataSource = new NhanVienDao().DSNV();
            }
            else
                MessageBox.Show("Xóa không thành công !");
        }
    }
}
