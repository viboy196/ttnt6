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
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
           hien();
        }
        private bool validate()
        {
            if (txtmatkhau.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường !");
                return false;
            }
            return true;
        }

        private void hien()
        {
            string sql = @"select *from TaiKhoan";
            dtgvtaikhoan.DataSource = KetNoi.getTable(sql);
            binding();
        }

        private void binding()
        {
            txtma.DataBindings.Clear();
            txtmatkhau.DataBindings.Clear();
            txtten.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dtgvtaikhoan.DataSource, "MaTK");
            txtmatkhau.DataBindings.Add("Text", dtgvtaikhoan.DataSource, "Password");
            txtten.DataBindings.Add("Text", dtgvtaikhoan.DataSource, "Usename");

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string sql = @"INSERT INTO [QLTV_LOAN].[dbo].[TaiKhoan]
                                   ([Usename]
                                   ,[Password])
                             VALUES
                                   (N'" + txtten.Text + @"'
                                   ," + txtmatkhau.Text + @"
                                    )";

                if (KetNoi.Query(sql) == -1)
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm !");
                }
                else
                {
                    MessageBox.Show("Thêm thành công !");
                    hien();
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string sql = @"UPDATE [QLTV_LOAN].[dbo].[TaiKhoan]
                               SET [Usename] = '" + txtten.Text + @"'
                              ,[Password] = '" + txtmatkhau.Text + @"'
                             WHERE MaTK = " + Convert.ToInt64(txtma.Text);

                if (KetNoi.Query(sql) == -1)
                {
                    MessageBox.Show("Có lỗi trong quá trình sửa !");
                }
                else
                {
                    MessageBox.Show("Sửa thành công !");
                    hien();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string sql = @"DELETE FROM [QLTV_LOAN].[dbo].[TaiKhoan]
                             WHERE MaTK = " + Convert.ToInt64(txtma.Text);

                if (KetNoi.Query(sql) == -1)
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa !");
                }
                else
                {
                    MessageBox.Show("Xóa thành công !");
                    hien();
                }
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {

            this.Close();
            new Form1().Visible = true;
        }
    }
}
