using QLKhachSan.Model;
using QLKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class FormThietBiPhong : Form
    {
        public FormThietBiPhong()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            DataTable dt = new ThietBiDao().DSPhong();
            cbMaPhong.DataSource = dt;
            cbMaPhong.DisplayMember = "MaPhong";
            cbMaPhong.SelectedIndex = -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int c = new ThietBiDao().addTB(new THIETBI { idPhong = Int32.Parse(cbMaPhong.Text), TenThietBi = txtTenTB.Text, SoLuong = Int32.Parse(txtSoLuong.Text) });
            if (c > 0)
            {
                MessageBox.Show("Thêm thiết bị thành công!");
                dgvDS.DataSource = new ThietBiDao().DsTBTheoPhong(cbMaPhong.Text);
            }
            else
            {
                MessageBox.Show("Thêm thất bại !");
            }
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtTenTB.Text = dgvDS.Rows[numrow].Cells[0].Value.ToString();
            txtSoLuong.Text = dgvDS.Rows[numrow].Cells[1].Value.ToString();
        }

        private void cbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]+");
            if (regex.IsMatch(cbMaPhong.Text))
            {
                dgvDS.DataSource = new ThietBiDao().DsTBTheoPhong(cbMaPhong.Text);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool c = new ThietBiDao().xoaTB(new THIETBI { idPhong = Int32.Parse(cbMaPhong.Text), TenThietBi = txtTenTB.Text, SoLuong = Int32.Parse(txtSoLuong.Text) });
            if (c)
            {
                MessageBox.Show("Xóa thiết bị thành công!");
                dgvDS.DataSource = new ThietBiDao().DsTBTheoPhong(cbMaPhong.Text);
                txtTenTB.Text = "";
                txtSoLuong.Text = "";
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }
    }
}
