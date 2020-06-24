using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLDIEM
{
    public partial class frmHocSinh : Form
    {
        public string state;
        public void hienthi(int dong)
        {
            if (gridThongTinHS.Rows[dong].Cells[3].Value.ToString() == "1")
            {

                txtMaHS.Text = gridThongTinHS.Rows[dong].Cells[0].Value.ToString();
                txtTenHS.Text = gridThongTinHS.Rows[dong].Cells[1].Value.ToString();
                cmbMaLop.Text = gridThongTinHS.Rows[dong].Cells[2].Value.ToString();
                radNam.Checked = true;
                mskNgaySinh.Text = gridThongTinHS.Rows[dong].Cells[4].Value.ToString();
                txtDiaChi.Text = gridThongTinHS.Rows[dong].Cells[5].Value.ToString();
                txtDanToc.Text = gridThongTinHS.Rows[dong].Cells[6].Value.ToString();
            }
            if (gridThongTinHS.Rows[dong].Cells[3].Value.ToString() == "0")
            {

                txtMaHS.Text = gridThongTinHS.Rows[dong].Cells[0].Value.ToString();
                txtTenHS.Text = gridThongTinHS.Rows[dong].Cells[1].Value.ToString();
                cmbMaLop.Text = gridThongTinHS.Rows[dong].Cells[2].Value.ToString();
                radNu.Checked = true;
                mskNgaySinh.Text = gridThongTinHS.Rows[dong].Cells[4].Value.ToString();
                txtDiaChi.Text = gridThongTinHS.Rows[dong].Cells[5].Value.ToString();
                txtDanToc.Text = gridThongTinHS.Rows[dong].Cells[6].Value.ToString();
            }
        }
        public void Dongtxt()
        {
            txtDanToc.Enabled = false;
            txtDiaChi.Enabled = false;
            txtMaHS.Enabled = false;
            txtTenHS.Enabled = false;
            //cmbMaLop.Enabled = false;
            mskNgaySinh.Enabled = false;
        }
        public void Motxt()
        {
            txtDanToc.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMaHS.Enabled = true;
            txtTenHS.Enabled = true;
            cmbMaLop.Enabled = true;
            mskNgaySinh.Enabled = true;
        }
        public void Dongbtn()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        public void Mobtn()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        public void setnull()
        {
            txtDanToc.Clear();
            txtDiaChi.Clear();
            txtMaHS.Clear();
            txtTenHS.Clear();
            mskNgaySinh.Clear();
            
        }
        public void hienthi()
        {
            gridThongTinHS.DataSource = KetNoiDB.Getdatatable("SELECT   MaHS, TenHS, MaLop, GioiTinh, NamSinh, DiaChi, DanToc FROM HocSinh ORDER BY MaHS");
        }

        DataTable dttths = new DataTable();
        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = KetNoiDB.Getdatatable("SELECT  MaLop FROM Lop ");
            cmbMaLop.DataSource = dt;
            cmbMaLop.DisplayMember = "MaLop";
            cmbMaLop.ValueMember = "MaLop";
            Dongtxt();          
            Mobtn();
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "add";
            Dongbtn();
            Motxt();
            setnull();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "update";
            Motxt();
            Dongbtn();
            txtMaHS.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            state = "delete";
            Dongbtn();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                try
                {
                    if (radNam.Checked == true)
                    {
                        KetNoiDB.ExcuteNonQR("INSERT INTO HocSinh (MaHS, TenHS, MaLop, GioiTinh, DiaChi, NamSinh, DanToc) VALUES ('" + txtMaHS.Text + "',N'" + txtTenHS.Text + "','" + cmbMaLop.Text + "','1',N'" + txtDiaChi.Text + "','" + DateTime.Parse(mskNgaySinh.Text) + "',N'" + txtDanToc.Text + "')");
                    }
                    else
                    {
                        KetNoiDB.ExcuteNonQR("INSERT INTO HocSinh (MaHS, TenHS, MaLop, GioiTinh, DiaChi, NamSinh, DanToc) VALUES ('" + txtMaHS.Text + "',N'" + txtTenHS.Text + "','" + cmbMaLop.Text + "','0',N'" + txtDiaChi.Text + "','" + DateTime.Parse(mskNgaySinh.Text) + "',N'" + txtDanToc.Text + "')");
                    }
                    MessageBox.Show("Thêm mới thành công.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch
               {
                   MessageBox.Show("Lỗi không thể thêm");
               }
                hienthi();
                Mobtn();
                Dongtxt();
                txtMaHS.Focus();
                
            }
            //-------------------
            if (state == "update")
            {
                try
                {
                    if (radNam.Checked == true)
                    {
                        KetNoiDB.ExcuteNonQR("UPDATE    HocSinh SET TenHS =N'"+txtTenHS.Text+"', MaLop ='"+cmbMaLop.Text+"', GioiTinh ='1', NamSinh ='"+DateTime.Parse(mskNgaySinh.Text)+"', DiaChi =N'"+txtDiaChi.Text+"', DanToc =N'"+txtDanToc.Text+"' Where MaHS = '"+txtMaHS.Text+"'");
                    }
                    else
                    {
                        KetNoiDB.ExcuteNonQR("UPDATE    HocSinh SET TenHS =N'" + txtTenHS.Text + "', MaLop ='" + cmbMaLop.Text + "', GioiTinh ='0', NamSinh ='" + DateTime.Parse(mskNgaySinh.Text) + "', DiaChi =N'" + txtDiaChi.Text + "', DanToc =N'" + txtDanToc.Text + "'Where MaHS = '"+txtMaHS.Text+"'");
                    }
                    MessageBox.Show("Sửa thành công","Thông báo");
                }
                catch
                {
                    MessageBox.Show("Lỗi không thể sửa");
                }
                hienthi();
                Mobtn();
                Dongtxt();

            }
            //-----------------
            if (state == "delete")
            {
                try
                {
                   
                        KetNoiDB.ExcuteNonQR("DELETE  FROM HocSinh Where MaHS='"+txtMaHS.Text+"'");
                        MessageBox.Show("Bạn có chắc chắn muốn xóa","Thông báo");
                        MessageBox.Show("Xóa thành công !!!","Thông báo");
                   
                }
                catch
                {
                    MessageBox.Show("Lỗi không thể xóa");
                }
                setnull();
                hienthi();
                Mobtn();
                Dongtxt();

            }
        }

        private void gridThongTinHS_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = 0;
                if (gridThongTinHS.CurrentRow != null)
                {
                    dong = gridThongTinHS.CurrentRow.Index;
                    if (gridThongTinHS.Rows[dong].Cells[3].Value.ToString() == "1")
                    {

                        txtMaHS.Text = gridThongTinHS.Rows[dong].Cells[0].Value.ToString();
                        txtTenHS.Text = gridThongTinHS.Rows[dong].Cells[1].Value.ToString();
                        cmbMaLop.Text = gridThongTinHS.Rows[dong].Cells[2].Value.ToString();
                        radNam.Checked = true;
                        mskNgaySinh.Text = gridThongTinHS.Rows[dong].Cells[4].Value.ToString();
                        txtDiaChi.Text = gridThongTinHS.Rows[dong].Cells[5].Value.ToString();
                        txtDanToc.Text = gridThongTinHS.Rows[dong].Cells[6].Value.ToString();
                    }
                    if (gridThongTinHS.Rows[dong].Cells[3].Value.ToString() == "0")
                    {

                        txtMaHS.Text = gridThongTinHS.Rows[dong].Cells[0].Value.ToString();
                        txtTenHS.Text = gridThongTinHS.Rows[dong].Cells[1].Value.ToString();
                        cmbMaLop.Text = gridThongTinHS.Rows[dong].Cells[2].Value.ToString();
                        radNu.Checked = true;
                        mskNgaySinh.Text = gridThongTinHS.Rows[dong].Cells[4].Value.ToString();
                        txtDiaChi.Text = gridThongTinHS.Rows[dong].Cells[5].Value.ToString();
                        txtDanToc.Text = gridThongTinHS.Rows[dong].Cells[6].Value.ToString();
                    }
                }
            }
            catch
            {
            }
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //try
            // {
            //     string a = txtTimKiem.Text.Trim();

            //     int dong = 1;

            //     while ((gridThongTinHS.Rows[dong].Cells[0].Value.ToString().Trim() != a) )
            //     {
            //         gridThongTinHS.Rows[dong - 1].Selected = false;
            //         dong = dong + 1;
            //         if (gridThongTinHS.Rows[dong].Cells[0].Value == null)
            //             break;

            //     }

            //     gridThongTinHS.Rows[dong].Selected = true;
            //     hienthi(dong);

            // }
            // catch
            // {
            //     MessageBox.Show("Không tìm thấy ");
            //     txtTimKiem.Clear();
            // }
            dttths = KetNoiDB.Getdatatable("SELECT   MaHS, TenHS, MaLop, GioiTinh, NamSinh, DiaChi, DanToc FROM HocSinh ORDER BY MaHS");
            DataView dv = dttths.DefaultView;
            dv.RowFilter = string.Format("TenHS like '%{0}%'", txtTimKiem.Text);
            gridThongTinHS.DataSource = dv.ToTable();


        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
