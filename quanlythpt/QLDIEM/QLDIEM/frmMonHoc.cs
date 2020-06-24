using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDIEM
{
    public partial class frmMonHoc : Form
    {

        public string state;
      
        public void Dongtxt()
        {
            txtMaMonHoc.Enabled = false;
            txtTenMonHoc.Enabled = false;
            cmbHSMon.Enabled = false;
        }
        public void Motxt()
        {
            txtMaMonHoc.Enabled = true;
            txtTenMonHoc.Enabled = true;
            cmbHSMon.Enabled = true;
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
            txtMaMonHoc.Clear();
            txtTenMonHoc.Clear();
        }
        public void hienthi()
        {
            gridThongTinMon.DataSource = KetNoiDB.Getdatatable("SELECT MaMH, TenMH, HeSoMon FROM MonHoc");
           
        }
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            hienthi();
            Dongtxt();
            Mobtn();
            
        }
       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "add";
            Motxt();
            Dongbtn();
            setnull();
        }

        private void gridThongTinMon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                int dong = 0;
                if (gridThongTinMon.CurrentRow != null)
                {
                    dong = gridThongTinMon.CurrentRow.Index;
                    txtMaMonHoc.Text = gridThongTinMon.Rows[dong].Cells[0].Value.ToString();
                    txtTenMonHoc.Text = gridThongTinMon.Rows[dong].Cells[1].Value.ToString();
                    cmbHSMon.Text = gridThongTinMon.Rows[dong].Cells[2].Value.ToString();
                }
            }
            catch
            {
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "update";
            Motxt();
            Dongbtn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            state = "delete";
            Dongbtn();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                if (state == "add")
                {
                    KetNoiDB.ExcuteNonQR("INSERT INTO MonHoc (MaMH, HeSoMon, TenMH) VALUES ('" + txtMaMonHoc.Text + "','" + cmbHSMon.Text + "',N'" + txtTenMonHoc.Text + "')");
                    MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi không thể thêm mới !!!");
            }
            try
            {
            if(state=="update")
            {
                //int dong = gridThongTinMon.CurrentRow.Index;
                //string MaMH = gridThongTinMon[0, dong].Value.ToString();
                KetNoiDB.ExcuteNonQR("UPDATE MonHoc SET MaMH = '"+txtMaMonHoc.Text+"',HeSoMon ='"+cmbHSMon.Text+"', TenMH =N'"+txtTenMonHoc.Text+"' Where MaMH ='"+txtMaMonHoc.Text+"'");
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể sửa !!!");
            }
            try
            {
            if (state == "delete")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                KetNoiDB.ExcuteNonQR("DELETE FROM MonHoc Where MaMH ='"+txtMaMonHoc.Text+"'");
            }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa !!!");
            }
            hienthi();
            Dongtxt();
            Mobtn();
        }
    }
}
