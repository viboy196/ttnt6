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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

            mobtn();
            dongtxt();
            hien();
        }
        private bool validate()
        {
            if (txtma.Text == "" || txtten.Text == "" || dtngaysinh.Text == "" || txtgioitinh.Text == "" || txtdiachi.Text == "" || txtsdt.Text == ""|| txtluong.Text=="")
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường !");
                return false;
            }
            return true;
        }

        private void hien()
        {
            string sql = @"select *from NhanVien";

            dtgvnhanvien.DataSource = KetNoi.getTable(sql);
        }

        private void binding()
        {
            txtma.DataBindings.Clear();
            txtten.DataBindings.Clear();
            dtngaysinh.DataBindings.Clear();
            txtgioitinh.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            txtsdt.DataBindings.Clear();
            txtluong.DataBindings.Clear();


            txtma.DataBindings.Add("Text", dtgvnhanvien.DataSource, "MaNV");
            txtten.DataBindings.Add("Text", dtgvnhanvien.DataSource, "TenNV");
            dtngaysinh.DataBindings.Add("Text", dtgvnhanvien.DataSource, "NgaySinh");
            txtgioitinh.DataBindings.Add("Text", dtgvnhanvien.DataSource, "GioiTinh");
            txtdiachi.DataBindings.Add("Text", dtgvnhanvien.DataSource, "DiaChi");
            txtsdt.DataBindings.Add("Text", dtgvnhanvien.DataSource, "SDT");
            txtluong.DataBindings.Add("Text", dtgvnhanvien.DataSource, "Luong");


        }
        private void motxt()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            dtngaysinh.Enabled = true;
            txtdiachi.Enabled = true;
            txtgioitinh.Enabled = true;
            txtsdt.Enabled = true;
            txtluong.Enabled = true;

        }

        private void dongtxt()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            dtngaysinh.Enabled = false;
            txtdiachi.Enabled = false;
            txtgioitinh.Enabled = false;
            txtsdt.Enabled = false;
            txtluong.Enabled = false;
        }

        private void mobtn()
        {
            btLuu.Enabled = false;
            btHuy.Enabled = false;
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }

        private void dongbtn()
        {
            btLuu.Enabled = true;
            btHuy.Enabled = true;
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        string state = "";

        private void btThem_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "insert";
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            motxt();
            dongbtn();
            state = "update";
            binding();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "delete";
            binding();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (validate())
            {



                if (state == "insert")
                {

                    string sql = @"INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,SDT,Luong)
     VALUES
           ('" + txtma.Text + @"'
           ,N'" + txtten.Text + @"'
            ,'" + dtngaysinh.Value.ToString("yyyy/MM/dd") + @"'
            ,N'" + txtgioitinh.Text + @"'
              ,N'" + txtdiachi.Text + @"'
              ," + txtsdt.Text + @"
              ,N'" + txtluong.Text + @"'
            )";


                    if (KetNoi.Query(sql) != -1)
                    {
                        MessageBox.Show("Thêm thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm");
                    }
                }
                //end add
                else if (state == "update")
                {
                    string sql = @"UPDATE [QLTV_LOAN].[dbo].[NhanVien]
       SET    
            [TenNV]=N'" + txtten.Text + @"'
            ,[NgaySinh]='" + dtngaysinh.Value.ToString("yyyy/MM/dd") + @"'
              ,[GioiTinh]=N'" + txtgioitinh.Text + @"'
             ,[DiaChi]= N'" + txtdiachi.Text + @"'
            ,[SDT]=" + txtsdt.Text + @"
              ,[Luong]=N'" + txtluong.Text + @"'
             WHERE MaNV= " + txtma.Text;


                    if (KetNoi.Query(sql) != -1)
                    {
                        MessageBox.Show("Sửa thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình Sửa");
                    }

                }

                hien();
                dongtxt();
                mobtn();
            }//end validate
            if (state == "delete" && validate())
            {
                string sql = @"DELETE NhanVien
             WHERE MaNV = " + txtma.Text;


                if (KetNoi.Query(sql) != -1)
                {
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình Xóa");
                }

                hien();
                dongtxt();
                mobtn();
            }

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            mobtn();
            dongtxt();
        }

        private void bthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Visible = true;
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string sql = @"select* from NhanVien";
            DataTable data = KetNoi.getTable(sql);  //lấy dữ liệu từ bảng KhachHang
            if (txttim.Text != "")
            {
                data.DefaultView.RowFilter = "TenNV LIKE '%" + txttim.Text + "%' or DiaChi LIKE '%" + txttim.Text + "%' or  GioiTinh LIKE '%" + txttim.Text + "%' ";  //filter lọc dữ liệu
            }
            else
            {
                data.DefaultView.RowFilter = "";
            }

            dtgvnhanvien.DataSource = data;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
