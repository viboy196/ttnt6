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
    public partial class TheLoai : Form
    {
        public TheLoai()
        {
            InitializeComponent();
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            mobtn();
            dongtxt();
            hien();
        }
        private bool validate()
        {
            if (txtma.Text == "" || txtten.Text == "" )
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường !");
                return false;
            }
            return true;
        }

        private void hien()
        {
            string sql = @"select *from TheLoai";

            dtgvtheloai.DataSource = KetNoi.getTable(sql);
        }

        private void binding()
        {
            txtma.DataBindings.Clear();
            txtten.DataBindings.Clear();
           



            txtma.DataBindings.Add("Text", dtgvtheloai.DataSource, "MaTheLoai");
            txtten.DataBindings.Add("Text", dtgvtheloai.DataSource, "TenTheLoai");

         


        }
        private void motxt()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;

           


        }

        private void dongtxt()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;

         

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

                    string sql = @"INSERT INTO TheLoai(MaTheLoai,TenTheLoai)
     VALUES
           ('" + txtma.Text + @"'
           ,N'" + txtten.Text + @"'
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
                    string sql = @"UPDATE [QLTV_LOAN].[dbo].[TheLoai]
       SET    
            [TenTheLoai]=N'" + txtten.Text + @"'
          
            WHERE MaTheLoai= " + txtma.Text;


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
                string sql = @"DELETE TheLoai
             WHERE MaTheLoai = " + txtma.Text;


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

        private void bttim_Click(object sender, EventArgs e)
        {
            string sql = @"select* from TheLoai";
            DataTable data = KetNoi.getTable(sql);  //lấy dữ liệu từ bảng KhachHang
            if (txttim.Text != "")
            {
                data.DefaultView.RowFilter = "TenTheLoai LIKE '%" + txttim.Text + "%'   ";  //filter lọc dữ liệu
            }
            else
            {
                data.DefaultView.RowFilter = "";
            }

            dtgvtheloai.DataSource = data;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {

            mobtn();
            dongtxt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Visible = true;
        }
    }
}
