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
    public partial class NhuCauMuonSach : Form
    {
        public NhuCauMuonSach()
        {
            InitializeComponent();
        }

        private void NhuCauMuonSach_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM Sach";

            cmbsach.DataSource = KetNoi.getTable(sql);

            cmbsach.DisplayMember = "TenSach";

            cmbsach.ValueMember = "MaSach";


            string sql1 = @"SELECT * FROM DocGia";

            cmbdocgia.DataSource = KetNoi.getTable(sql1);

            cmbdocgia.DisplayMember = "TenDocGia";

            cmbdocgia.ValueMember = "MaDocGia";


            string sql2 = @"SELECT * FROM NhanVien";

            cmbnhanvien.DataSource = KetNoi.getTable(sql2);

            cmbnhanvien.DisplayMember = "TenNV";

            cmbnhanvien.ValueMember = "MaNV";


            mobtn();
            dongtxt();
            hien();
        }

        private bool validate()
        {
            if (cmbsach.Text == "" || cmbdocgia.Text == "" || cmbnhanvien.Text == "" || txtsoluong1.Text == "" || dtngaymuon.Text == "" || dtngayhantra.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường !");
                return false;
            }
            return true;
        }

        private void hien()
        {
            string sql = @"select STT,SoPM,Sach.MaSach,Sach.TenSach,SoLuongSachMuon,DocGia.MaDocGia,DocGia.TenDocGia,NgayMuon,NgayHanTra,TinhTrangSach,GhiChu, NhanVien.MaNV, TenNV
from NhuCau
inner join Sach on Sach.MaSach=NhuCau.MaSach
inner join DocGia on DocGia.MaDocGia=NhuCau.MaDocGia
inner join NhanVien on NhanVien.MaNV=NhuCau.MaNV";

            dtgv2.DataSource = KetNoi.getTable(sql);
        }

        private void binding()
        {
            txtstt.DataBindings.Clear();
            txtso.DataBindings.Clear();
            cmbsach.DataBindings.Clear();
            txtsoluong1.DataBindings.Clear();
            cmbdocgia.DataBindings.Clear();
            dtngaymuon.DataBindings.Clear();
            dtngayhantra.DataBindings.Clear();
            txtghichu.DataBindings.Clear();
            cmbnhanvien.DataBindings.Clear();

            txtstt.DataBindings.Add("Text", dtgv2.DataSource, "STT");
            txtso.DataBindings.Add("Text", dtgv2.DataSource, "SoPM");
            cmbsach.DataBindings.Add("Text", dtgv2.DataSource, "MaSach");
            txtsoluong1.DataBindings.Add("Text", dtgv2.DataSource, "SoLuongSachMuon");
           cmbdocgia.DataBindings.Add("Text", dtgv2.DataSource, "MaDocGia");
            dtngaymuon.DataBindings.Add("Text", dtgv2.DataSource, "NgayMuon");
            dtngayhantra.DataBindings.Add("Text", dtgv2.DataSource, "NgayHanTra");
            txtghichu.DataBindings.Add("Text", dtgv2.DataSource, "GhiChu");
            cmbnhanvien.DataBindings.Add("Text", dtgv2.DataSource, "MaNV");

        }
        private void motxt()
        {
            txtstt.Enabled = true;
            txtso.Enabled = true;
            cmbsach.Enabled = true;
            txtsoluong1.Enabled = true;
            cmbdocgia.Enabled = true;
            dtngaymuon.Enabled = true;
            dtngayhantra.Enabled = true;
            txtghichu.Enabled = true;
            cmbnhanvien.Enabled = true;
            
        }

        private void dongtxt()
        {
            txtstt.Enabled = false;
            txtso.Enabled = false;
            cmbsach.Enabled = false;
            txtsoluong1.Enabled = false;
            cmbdocgia.Enabled = false;
            dtngaymuon.Enabled = false;
            dtngayhantra.Enabled = false;
            txtghichu.Enabled = false;
            cmbnhanvien.Enabled = false;
            
        }

        private void mobtn()
        {
            btluu.Enabled = false;
            bthuy.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }

        private void dongbtn()
        {
            btluu.Enabled = true;
            bthuy.Enabled = true;
            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }

        string state = "";

        private void btthem_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "insert";
        }

        private void btsua_Click(object sender, EventArgs e)
        {

            motxt();
            dongbtn();
            state = "update";
            binding();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            motxt();
            dongbtn();
            state = "delete";
            binding();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (validate())
            {



                if (state == "insert")
                {
                    //MessageBox.Show("INSERT INTO PhieuNhap(MaPhieuNhap, TenNCC, TenMH, SoLuongNhap,GiaNhap,TienDaThanhToan,NgayThanhToan) VALUES (" + Convert.ToInt32(txtMaPhieuNhap.Text) + ",N'" + txtTenNCC.Text + "',N'" + txtTenMH.Text + "'," + Convert.ToInt32(txtSoLuongNhap.Text) + "," + Convert.ToInt32(txtGiaNhap.Text) + "," + Convert.ToInt32(txtTienDaThanhToan.Text) + ",'"+txtNgayThanhToan.Value.ToShortDateString().ToString() +"')");
                    string sql = @"INSERT INTO [QLTV_LOAN].[dbo].[NhuCau]
           ([SoPM]
           ,[MaSach]
           ,[SoLuongSachMuon]
           ,[MaDocGia]
           ,[NgayMuon]
            ,[NgayHanTra]
             ,[GhiChu]
             ,[MaNV])
     VALUES
           ( "+txtso.Text+@"
        ," + cmbsach.SelectedValue + @"
       ," + Convert.ToInt64(txtsoluong1.Text) + @"
      ," + cmbdocgia.SelectedValue + @"
      ,'" + dtngaymuon.Value.ToString("yyyy/MM/dd") + @"'
      ,'" + dtngayhantra.Value.ToString("yyyy/MM/dd") + @"'
      , N'" + txtghichu.Text + @"'
      , " + cmbnhanvien.SelectedValue + @"
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
                    string sql = @"UPDATE [QLTV_LOAN].[dbo].[NhuCau]
   SET   [SoPM]="+txtso.Text+@"
       ,[MaSach] =" + cmbsach.SelectedValue + @"
       ,[SoLuongSachMuon] =" + Convert.ToInt64(txtsoluong1.Text) + @"
      ,[MaDocGia] =" + cmbdocgia.SelectedValue + @"
      ,[NgayMuon] ='" + dtngaymuon.Value.ToString("yyyy/MM/dd") + @"'
      ,[NgayHanTra] ='" + dtngayhantra.Value.ToString("yyyy/MM/dd") + @"'
      , [GhiChu] = N'" + txtghichu.Text + @"'
      ,[MaNV] = " + cmbnhanvien.SelectedValue + @"
 WHERE STT = " + Convert.ToInt64(txtstt.Text);



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
                string sql = @"DELETE NhuCau
                WHERE STT = " + Convert.ToInt64(txtstt.Text);


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

        private void bthuy_Click(object sender, EventArgs e)
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
            string sql = @"select STT, SoPM,Sach.MaSach,Sach.TenSach,SoLuongSachMuon,DocGia.MaDocGia,DocGia.TenDocGia,NgayMuon,NgayHanTra,TinhTrangSach,GhiChu, NhanVien.MaNV, TenNV
from NhuCau
inner join Sach on Sach.MaSach=NhuCau.MaSach
inner join DocGia on DocGia.MaDocGia=NhuCau.MaDocGia
inner join NhanVien on NhanVien.MaNV=NhuCau.MaNV";
            DataTable data = KetNoi.getTable(sql);  //lấy dữ liệu từ bảng KhachHang
            if (txttim.Text != "")
            {
                data.DefaultView.RowFilter = "TenDocGia LIKE '%" + txttim.Text + "%' OR TenNV LIKE '%" + txttim.Text + "%' OR TenSach LIKE '%" + txttim.Text + "%'";  //filter lọc dữ liệu
            }
            else
            {
                data.DefaultView.RowFilter = "";
            }

            dtgv2.DataSource = data;  //gán giá trị vào datagridview
        }
    }
}
