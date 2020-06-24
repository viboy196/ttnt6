using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDIEM
{
    public partial class frmGiaoVien : Form
    {
        public string state;
        public void Dongtxt()
        {
            txtMaGV.Enabled = false;
            txtTenGV.Enabled = false;
            cmbMaMH.Enabled = false;
            mskSDT.Enabled = false;
            //cmbMaLop.Enabled = false;
            txtDiaChi.Enabled = false;
        }
        public void Motxt()
        {
            txtMaGV.Enabled = true;
            txtTenGV.Enabled = true;
            cmbMaMH.Enabled = true;
            mskSDT.Enabled = true;
            //cmbMaLop.Enabled = true;
            txtDiaChi.Enabled = true;
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
            txtMaGV.Clear();
            txtTenGV.Clear();
            txtDiaChi.Clear();
            //cmbMaMH.Clear();
            mskSDT.Clear();
            txtDiaChi.Clear();

        }
        public void hienthi()
        {
            gridThongTinGV.DataSource = KetNoiDB.Getdatatable("select * from GiaoVien");
        }
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            gridThongTinGV.DataSource = KetNoiDB.Getdatatable("select * from GiaoVien");
            DataTable dt = new DataTable();
            dt = KetNoiDB.Getdatatable("select MaMH from MonHoc");
            cmbMaMH.DataSource = dt;
            cmbMaMH.DisplayMember = "MaMH";
            cmbMaMH.ValueMember = "MaMH";
            Dongtxt();
            Mobtn();
        }

        private void gridThongTinGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = 0;
                if (gridThongTinGV.CurrentRow != null)
                {
                    dong = gridThongTinGV.CurrentRow.Index;
                    txtMaGV.Text = gridThongTinGV.Rows[dong].Cells[0].Value.ToString();
                    txtTenGV.Text = gridThongTinGV.Rows[dong].Cells[1].Value.ToString();
                    txtDiaChi.Text = gridThongTinGV.Rows[dong].Cells[4].Value.ToString();
                    mskSDT.Text = gridThongTinGV.Rows[dong].Cells[5].Value.ToString();
                    cmbMaMH.Text = gridThongTinGV.Rows[dong].Cells[2].Value.ToString();
                    if (gridThongTinGV.Rows[dong].Cells[3].Value.ToString() == "1")
                    {
                        radNam.Checked = true;
                    }
                    else
                    {
                        radNu.Checked = true;
                    }
                }
            }
            catch
            {
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            Close();
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
            txtMaGV.Enabled = false;
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            state = "delete";
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            Dongbtn();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (radNam.Checked == true)
            {
                gt = "1";
            }
            else
            {
                gt = "0";
            }

            if(state =="add")
            {
                KetNoiDB.ExcuteNonQR("INSERT INTO GiaoVien (MaGV, TenGV, MaMH, GioiTinh, DiaChi, SDT) VALUES  ('"+txtMaGV.Text+"','"+txtTenGV.Text +"','"+cmbMaMH.Text +"','"+gt+"','"+txtDiaChi.Text+"','"+mskSDT.Text+"')");
                //if (MessageBox.Show("Thêm thành công!","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk)==DialogResult.Yes)
                hienthi();
                Dongtxt();
                Mobtn();
                MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            //-----------
            if (state == "update")
            {
                KetNoiDB.ExcuteNonQR("UPDATE  GiaoVien SET  TenGV =N'" + txtTenGV.Text+ "', MaMH ='" + cmbMaMH.Text + "', GioiTinh ='" + gt + "', DiaChi =N'" + txtDiaChi.Text + "', SDT ='" + mskSDT.Text + "'  Where MaGV='" + txtMaGV.Text + "'");
                hienthi();
                Dongtxt();
                Mobtn();
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //--------
            if(state=="delete")
            {
                KetNoiDB.ExcuteNonQR("DELETE FROM GiaoVien Where MaGV='" + txtMaGV.Text + "'");               
                hienthi();
                Mobtn();
                Dongtxt();

            }
        }
    }
}
