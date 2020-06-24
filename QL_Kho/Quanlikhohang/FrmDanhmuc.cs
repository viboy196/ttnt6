using Quanlikhohang.NghiepVu;
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
    public partial class FrmDanhmuc : Form
    {
        N16_QLNguyenLieuNhaHang_T6Entities dta = new N16_QLNguyenLieuNhaHang_T6Entities();
        public FrmDanhmuc()
        {
            InitializeComponent();
            dataGridView1.DataSource = Show().Tables[0];
            biding();
        }
        private void biding()
        {
                tb_nguyenlieu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tên nguyên liệu", true, DataSourceUpdateMode.Never));
                tb_loai.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Loại tươi khô", true, DataSourceUpdateMode.Never));
                tb_gia.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Giá tiền", true, DataSourceUpdateMode.Never));
                tb_soluong.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
                tb_donvi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tên đơn vị", true, DataSourceUpdateMode.Never));
        }
        private DataSet Show()
        {
            DataSet dt = new DataSet();
            string query = "select MaNL N'Mã NL',TenNL N'Tên nguyên liệu',LoaiTuoiKho N'Loại tươi khô',GiaTien N'Giá tiền',SoLuong N'Số lượng',TenDonVi N'Tên đơn vị' from dbo.NguyenLieu";
            using (SqlConnection connection = new SqlConnection(@"data source=(local)\SQLEXPRESS;initial catalog=N16_QLNguyenLieuNhaHang_T6;integrated security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
        private DataSet Nhacungcap()
        {
            DataSet dt = new DataSet();
            string query = "select MaNCC N'Mã nhà cung cấp',TenNCC N'Tên nhà cung cấp',DiaChi N'Địa chỉ',SDT N'Số điện thoại' from dbo.NhaCungCap";
            using (SqlConnection connection = new SqlConnection(@"data source=(local)\SQLEXPRESS;initial catalog=N16_QLNguyenLieuNhaHang_T6;integrated security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
        private DataSet Timkiem()
        {
            DataSet dt = new DataSet();
                string query = "select MaNL N'Mã NL',TenNL N'Tên nguyên liệu',LoaiTuoiKho N'Loại tươi khô',GiaTien N'Giá tiền',SoLuong N'Số lượng',TenDonVi N'Tên đơn vị' from dbo.NguyenLieu where MaNL like N'" + tb_timkiem.Text + "%' or TenNL like N'" + tb_timkiem.Text + "%'";
                using (SqlConnection connection = new SqlConnection(@"data source=(local)\SQLEXPRESS;initial catalog=N16_QLNguyenLieuNhaHang_T6;integrated security=True"))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dt);
                    connection.Close();
                }
            return dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNL f = new ThemNL();
            this.Visible = false;
            f.ShowDialog();
        }

        

        private void cmdTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Timkiem().Tables[0]; 
        }

        private void bn_quaylai_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Show().Tables[0];
            biding();
        }
        private void btnDanhMucKhoHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_NghiepVu_Click(object sender, EventArgs e)
        {
            new frmNghiepVu().Show();
        }
        private void bt_nhacc_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap f = new FrmNhaCungCap();
            this.Visible = false;
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            this.Visible = false;
            f.ShowDialog();
        }
    }

    internal class N16_QLNguyenLieuNhaHang_T6Entities
    {
        public N16_QLNguyenLieuNhaHang_T6Entities()
        {
        }
    }
}
