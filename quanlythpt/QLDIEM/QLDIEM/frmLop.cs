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
    public partial class frmLop : Form
    {
        public string state;
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
        public void Dongtxt()
        {
            txtMaLop.Enabled = false;
            txtSiSo.Enabled = false;
            txtTenGV.Enabled = false;
            txtTenLop.Enabled = false;
            cmbKhoi.Enabled = false;
            cmbMaGV.Enabled = false;
        }
        public void Motxt()
        {
            txtMaLop.Enabled = true;
            txtSiSo.Enabled = true;
            txtTenGV.Enabled = false;
            txtTenLop.Enabled = true;
            cmbKhoi.Enabled = true;
            cmbMaGV.Enabled = true;
        }
        public void setnull()
        {
            txtTenLop.Clear();
            txtTenGV.Clear();
            txtSiSo.Clear();
            txtMaLop.Clear();
            
        }
        public void hienthi()
        {
            gridLop.DataSource = KetNoiDB.Getdatatable("SELECT  MaLop, TenLop, Khoi, MaGV, SiSo FROM  Lop");
        }

        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            cmbMaGV.DataSource = KetNoiDB.Getdatatable("SELECT  MaGV FROM  GiaoVien");
            cmbMaGV.DisplayMember = "MaGV";
            cmbMaGV.ValueMember = "MaGV";
            hienthi();
            Dongtxt();
            Mobtn();
        }

        private void gridLop_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = 0;
                if (gridLop.CurrentRow != null)
                {
                    dong = gridLop.CurrentRow.Index;
                    txtMaLop.Text = gridLop.Rows[dong].Cells[0].Value.ToString();
                    cmbMaGV.Text = gridLop.Rows[dong].Cells[3].Value.ToString();
                    txtSiSo.Text = gridLop.Rows[dong].Cells[4].Value.ToString();
                    cmbKhoi.Text = gridLop.Rows[dong].Cells[2].Value.ToString();
                    txtTenLop.Text = gridLop.Rows[dong].Cells[1].Value.ToString();
                }
            }
            catch
            {
                //}

            }
        }

        private void cmbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string str = "select TenGV From GiaoVien Where MaGV='";
                string Ma = cmbMaGV.Text;
                DataTable dt = new DataTable();
                dt = KetNoiDB.Getdatatable(str + Ma + "'");
                txtTenGV.Text = dt.Rows[0][0].ToString();
            }
            catch
            {
            }
        }

        private void cmbMaGV_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string str = "select TenGV From GiaoVien Where MaGV='";
                string Ma = cmbMaGV.Text;
                DataTable dt = new DataTable();
                dt = KetNoiDB.Getdatatable(str + Ma + "'");
                txtTenGV.Text = dt.Rows[0][0].ToString();
            }
            catch
            {
            }
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
            Dongbtn();
            Motxt();
            txtMaLop.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            state = "delete";
            Dongbtn();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == "add")
                {
                    KetNoiDB.ExcuteNonQR("INSERT INTO Lop  (MaLop, Khoi, TenLop, MaGV, SiSo) VALUES ('" + txtMaLop.Text + "',N'" + cmbKhoi.Text + "',N'" + txtTenLop.Text + "','" + cmbMaGV.Text + "','" + txtSiSo.Text + "')");
                    MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                //MessageBox.Show("Thêm thành công","Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi không thể thêm !!!");
            }
            try
            {

                if (state == "update")
                {
                    KetNoiDB.ExcuteNonQR("UPDATE  Lop SET  Khoi =N'" + cmbKhoi.Text + "', TenLop =N'" + txtTenLop.Text + "', MaGV ='" + cmbMaGV.Text + "', SiSo ='" + txtSiSo.Text + "' Where MaLop='" + txtMaLop.Text + "'");
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể Sửa !!!");
            }
            try
            {
                if (state == "delete")
                {
                    KetNoiDB.ExcuteNonQR("DELETE FROM Lop Where MaLop='" + txtMaLop.Text + "'");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể thêm !!!");
            }
            hienthi();
            Dongtxt();
            Mobtn();
        }
    }
}
