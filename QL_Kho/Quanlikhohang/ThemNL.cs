using Quanlikhohang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlikhohang
{
    public partial class ThemNL : Form
    {
        N11_QLNguyenLieuNhaHang_T5Entities dt = new N11_QLNguyenLieuNhaHang_T5Entities();
        KhoHangContext context = new KhoHangContext();
        private string donvi;
        private string luachon;
        string tennl;
        public ThemNL()
        {
            InitializeComponent();
            loadten();
            //loadtenxoa();
        }
        private void loadten()
        {
                cb_luachon.DataSource= context.NguyenLieux.ToList();
                cb_luachon.DisplayMember = "TenNL";
                cb_maxoa.DataSource = context.NguyenLieux.ToList();
                cb_maxoa.DisplayMember = "TenNL";
        }
        private bool kiemtra(string a)
        {
            bool luachon=true;
            if (a == "0")
            {
                luachon = false;
            }
            else
                luachon = true;
            return luachon;
        }
        private void add()
        {
            string con = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=N11_QLNguyenLieuNhaHang_T5;Integrated Security=True";
            string query = "exec dbo.themnl N'"+ tb_nguyenlieu.Text+"',"+kiemtra(tb_loai.Text)+","+tb_soluong.Text+","+tb_gia.Text+",N'"+donvi+"'";
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        private void sua()
        {
            string con = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=N11_QLNguyenLieuNhaHang_T5;Integrated Security=True";
            string query = "exec dbo._Suanguyenlieu N'" + luachon + "'," + kiemtra(tb_loaisua.Text)+","+tb_giasua.Text+","+tb_soluongsua.Text+ ", N'" + donvi + "'";
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
            if(tb_nguyenlieu.Text=="")
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel);
            }
            else
            {
                add();
                MessageBox.Show("Bạn vừa thêm thành công nguyên liệu: "+tb_nguyenlieu.Text, "Thông báo", MessageBoxButtons.OKCancel);
            }
        }

        private void cb_donvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            donvi = combo.SelectedItem.ToString();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            sua();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OKCancel);
        }

        private void cb_suadonvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            donvi = combo.SelectedItem.ToString();
        }

        private void cb_luachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            luachon = combo.SelectedItem.ToString();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            tennl=combo.SelectedItem.ToString();
            
        }
        private void Xoa()
        {
            string con = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=N11_QLNguyenLieuNhaHang_T5;Integrated Security=True";
            string query = "delete dbo.NguyenLieu where TenNl=N'"+tennl+"'";
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        private void bn_Thoat_Click(object sender, EventArgs e)
        {
            FrmDanhmuc f = new FrmDanhmuc();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            
            DialogResult result= MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
            switch(result)
            {
                case DialogResult.OK:
                    {
                        Xoa();
                        MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK);
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
