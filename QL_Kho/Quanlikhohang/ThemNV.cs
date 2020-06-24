using Quanlikhohang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlikhohang
{
    public partial class ThemNV : Form
    {
        KhoHangContext context = new KhoHangContext();
        private string luachon, tenxoa;
        public ThemNV()
        {
            InitializeComponent();
            loadten();
        }
        private void loadten()
        {
            var model = context.NhanViens.Select(p => p.HoTen).ToList();
            foreach (string item in model)
            {
                cb_luachon.Items.Add(item);
                cb_maxoa.Items.Add(item);
            }
        }
        private void add()
        {
            string con = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=N11_QLNguyenLieuNhaHang_T5;Integrated Security=True";
            string query = "insert dbo.NhanVien(HoTen,NgaySinh,DiaChi,SDT) values(N'"+tb_ten.Text+"','"+dt_ngaysinh.Value+"',N'"+tb_diachi.Text+"',N'"+tb_sdt.Text+"')";
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void delete()
        {
            string con = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=N11_QLNguyenLieuNhaHang_T5;Integrated Security=True";
            string query = "exec dbo.Xoanhannvien N'"+tenxoa+"'";
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void update()
        {
            string con = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=N11_QLNguyenLieuNhaHang_T5;Integrated Security=True";
            string query = "update dbo.NhanVien set NgaySinh= '"+dt_suangaysinh.Value+"', DiaChi= N'"+tb_diachisua.Text+"', SDT= N'"+tb_sdtsua.Text+"' where MaNV in (select MaNV from dbo.NhanVien where HoTen= N'"+luachon+"')";
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_ten.Text))
            {
                MessageBox.Show("Bạn phải nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                add();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    }

    private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cb_maxoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            tenxoa = combo.SelectedItem.ToString();
        }

        private void bn_Thoat_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            this.Visible = false;
            f.ShowDialog();
        }
        
        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_luachon.Text))
            {
                MessageBox.Show("Bạn phải nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                update();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cb_maxoa.Text))
            {
                MessageBox.Show("Bạn phải nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            delete();
            MessageBox.Show("Đã xóa nhân viên " + tenxoa, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ThemNV_Load(object sender, EventArgs e)
        {

        }

        private void cb_luachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            luachon = combo.SelectedItem.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
