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
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM TheLoai";

            cmbMaTL.DataSource = KetNoi.getTable(sql);

            cmbMaTL.DisplayMember = "TenTheLoai";

            cmbMaTL.ValueMember = "MaTheLoai";


            string sql1 = @"SELECT * FROM TacGia";

            cmbMaTG.DataSource = KetNoi.getTable(sql1);

            cmbMaTG.DisplayMember = "TenTG";

            cmbMaTG.ValueMember = "MaTG";


            mobtn();
            dongtxt();
            hien();
        }
        private bool validate()
        {
            if (cmbMaTL.Text == "" || cmbMaTG.Text == "" || txttensach.Text == "" || txtmasach.Text == "" || txtnxb.Text == "" || txtnamxb.Text == "" || txtgiatien.Text == "" || txtsotrang.Text == ""|| txtsoluong.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường !");
                return false;
            }
            return true;
        }

        private void hien()
        {
            string sql = @"select MaSach,TenSach,S.MaTheLoai,TheLoai.TenTheLoai,S.MaTG,TacGia.TenTG,NXB,NamXB,GiaTien,SoTrang,TinhTrangSach,SoLuong
from Sach S
inner join TheLoai on S.MaTheLoai=TheLoai.MaTheLoai
inner join TacGia ON S.MaTG=TacGia.MaTG";

            dtgvsach.DataSource = KetNoi.getTable(sql);
        }

        private void binding()
        {
            cmbMaTL.DataBindings.Clear();
            cmbMaTG.DataBindings.Clear();
            txtmasach.DataBindings.Clear();
            txttensach.DataBindings.Clear();
            txtnxb.DataBindings.Clear();
            txtnamxb.DataBindings.Clear();
            txtgiatien.DataBindings.Clear();
            txtsotrang.DataBindings.Clear();
            txttinhtrangsach.DataBindings.Clear();
            txtsoluong.DataBindings.Clear();

            cmbMaTL.DataBindings.Add("Text", dtgvsach.DataSource, "MaTheLoai");
            cmbMaTG.DataBindings.Add("Text", dtgvsach.DataSource, "MaTG");
            txtmasach.DataBindings.Add("Text", dtgvsach.DataSource, "MaSach");
            txttensach.DataBindings.Add("Text", dtgvsach.DataSource, "TenSach");
            txtnxb.DataBindings.Add("Text", dtgvsach.DataSource, "NXB");
            txtnamxb.DataBindings.Add("Text", dtgvsach.DataSource, "NamXB");
            txtgiatien.DataBindings.Add("Text", dtgvsach.DataSource, "GiaTien");
            txtsotrang.DataBindings.Add("Text", dtgvsach.DataSource, "SoTrang");
            txttinhtrangsach.DataBindings.Add("Text", dtgvsach.DataSource, "TinhTrangSach");
            txtsoluong.DataBindings.Add("Text", dtgvsach.DataSource, "SoLuong");

        }
        private void motxt()
        {
            cmbMaTL.Enabled = true;
            cmbMaTG.Enabled = true;
            txtnxb.Enabled = true;
            txtnamxb.Enabled = true;
            txtsotrang.Enabled = true;
            txttinhtrangsach.Enabled = true;
            txtmasach.Enabled = true;
            txttensach.Enabled = true;
            txtsoluong.Enabled = true;
            txtgiatien.Enabled = true;
        }

        private void dongtxt()
        {
            cmbMaTL.Enabled = false;
            cmbMaTG.Enabled = false;
            txtnxb.Enabled = false;
            txtnamxb.Enabled = false;
            txtsotrang.Enabled = false;
            txttinhtrangsach.Enabled = false;
            txtmasach.Enabled = false;
            txttensach.Enabled = false;
            txtsoluong.Enabled = false;
            txtgiatien.Enabled = false;
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
            
                    string sql = @"INSERT INTO [QLTV_LOAN].[dbo].[Sach]([MaSach],[TenSach],[NXB],[NamXB],[GiaTien],[SoTrang],[TinhTrangSach],[MaTheLoai],[MaTG],[SoLuong])
     VALUES
           ('" + txtmasach.Text + @"'
           ,N'" + txttensach.Text + @"'
            ,N'" + txtnxb.Text + @"'
            ," + txtnamxb.Text + @"
              ," + txtgiatien.Text + @"
              ," + txtsotrang.Text + @"
             ,N'" + txttinhtrangsach.Text + @"'
           ,'" + cmbMaTL.SelectedValue + @"'
           ," + cmbMaTG.SelectedValue + @" 
            ," + Convert.ToInt64(txtsoluong.Text) + @"  )";


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
                    string sql = @"UPDATE [QLTV_LOAN].[dbo].[Sach]
       SET    [TenSach]=N'" + txttensach.Text + @"'
            ,[NXB]=N'" + txtnxb.Text + @"'
            ,[NamXB]=" + txtnamxb.Text + @"
              ,[GiaTien]=" + txtgiatien.Text + @"
             ,[SoTrang]= " + txtsotrang.Text + @"
            ,[TinhTrangSach]=N'" + txttinhtrangsach.Text + @"'
           ,[MaTheLoai]='" + cmbMaTL.SelectedValue + @"'
           ,[MaTG]=" + cmbMaTG.SelectedValue + @"
             ,[SoLuong]=" + Convert.ToInt64(txtsoluong.Text) + @"
          WHERE MaSach = " + txtmasach.Text ;



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
                string sql = @"DELETE Sach
             WHERE MaSach = " + txtmasach.Text;


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

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Visible = true;
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string sql = @"select MaSach,TenSach,S.MaTheLoai,S.MaTG,NXB,NamXB,GiaTien,SoTrang,TinhTrangSach,TheLoai.TenTheLoai,TacGia.TenTG,SoLuong
from Sach S
inner join TheLoai on S.MaTheLoai=TheLoai.MaTheLoai
inner join TacGia ON S.MaTG=TacGia.MaTG";
            DataTable data = KetNoi.getTable(sql);  //lấy dữ liệu từ bảng KhachHang
            if (txttim.Text != "")
            {
                data.DefaultView.RowFilter = "TenSach LIKE '%" + txttim.Text + "%' or  NXB LIKE '%" + txttim.Text + "%' or TenTG LIKE '%" + txttim.Text + "%' or TenTheLoai LIKE '%" + txttim.Text + "%'";  //filter lọc dữ liệu
            }
            else
            {
                data.DefaultView.RowFilter = "";
            }

            dtgvsach.DataSource = data;  //gán giá trị vào datagridview
        }
    }
}
