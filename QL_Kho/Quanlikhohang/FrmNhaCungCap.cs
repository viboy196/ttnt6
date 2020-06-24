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
    public partial class FrmNhaCungCap : Form
    {
        public FrmNhaCungCap()
        {
            InitializeComponent();
            dataGridView1.DataSource = danhsach().Tables[0];
            biding();
        }
        private void biding()
        {
            tb_ma.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Mã nhà cung cấp", true, DataSourceUpdateMode.Never));
            tb_nhacc.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tên nhà cung cấp", true, DataSourceUpdateMode.Never));
            tb_diachi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            tb_sdt.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
        }
        private DataSet danhsach()
        {
            DataSet dt = new DataSet();
            string query = "select MaNCC N'Mã nhà cung cấp',TenNCC N'Tên nhà cung cấp',DiaChi N'Địa chỉ',SDT N'Số điện thoại' from dbo.NhaCungCap";
            using (SqlConnection connection = new SqlConnection(@"data source=(local)\SQLEXPRESS;initial catalog=N11_QLNguyenLieuNhaHang_T5;integrated security=True"))
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
            string query = "select MaNCC N'Mã nhà cung cấp',TenNCC N'Tên nhà cung cấp',DiaChi N'Địa chỉ',SDT N'Số điện thoại' from dbo.NhaCungCap where MaNCC like '" + tb_timkiem.Text + "%' or TenNCC like N'" + tb_timkiem.Text + "%'";
            using (SqlConnection connection = new SqlConnection(@"data source=(local)\SQLEXPRESS;initial catalog=N11_QLNguyenLieuNhaHang_T5;integrated security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
        private void cmdTimkiem_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Timkiem().Tables[0];
        }

        private void btnChucnang_Click(object sender, EventArgs e)
        {
            Themncc f = new Themncc();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bn_quaylai_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = danhsach().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDanhmuc f = new FrmDanhmuc();
            this.Visible = false;
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
