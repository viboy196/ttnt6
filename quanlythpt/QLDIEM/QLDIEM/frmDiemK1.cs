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
    public partial class frmDiemKyI : Form
    {
        string state;
        public string TinhDiem()
        {
            string a;
              float mieng,diem15p,diem1tiet1,diem1tiet2,diemthi,DiemTB;
              if (txtMieng.Text.Length == 0)
              {
                  mieng = 0;
              }
              else
              {
                  mieng = float.Parse(txtMieng.Text);
              }
              if (txt15p.Text.Length == 0)
              {
                  diem15p = 0;
              }
              else
              {
                  diem15p = float.Parse(txt15p.Text);
              }
              if (txt1Tiet1.Text.Length == 0)
              {
                  diem1tiet1 = 0;
              }
              else
              {
                  diem1tiet1 = float.Parse(txt1Tiet1.Text);
              }

              if (txt1Tiet2.Text.Length == 0)
              {
                  diem1tiet2 = 0;
              }
              else
              {
                  diem1tiet2 = float.Parse(txt1Tiet2.Text);
              }
              if (txtThi.Text.Length == 0)
              {
                  diemthi = 0;
              }
              else
              {
                  diemthi = float.Parse(txtThi.Text);
              }
              DiemTB = (mieng + diem15p + diem1tiet1 * 2 + diem1tiet2 * 2 + diemthi * 3) / 9;
              Math.Round(DiemTB, 2);
            
             a=DiemTB.ToString();
            return a;
        }

        public int kiemtra()
        {
            for (int i = 0; i < gridDiem.RowCount - 1; i++)
            {
                if(txtMaMH.Text==gridDiem.Rows[i].Cells[0].Value.ToString())
                {
                    return 1;
                    break;
                }

            }
            return 0;
        }
        public void dongtxt()
        {
            txtMaHS.Enabled = false;
            txtTenHS.Enabled = false;
            txtMaMH.Enabled = false;
            txt15p.Enabled = false;
            txt1Tiet1.Enabled = false;
            txt1Tiet2.Enabled = false;
            txtMieng.Enabled = false;
            txtThi.Enabled = false;
            cmbMH.Enabled = false;
            txtDTBM.Enabled = false;
        }
        public void motxt()
        {
            txt15p.Enabled = true;
            txt1Tiet1.Enabled = true;
            txt1Tiet2.Enabled = true;
            txtMieng.Enabled = true;
            txtThi.Enabled = true;
            cmbMH.Enabled = true;
        }
        public void dongbtn()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        public void mobtn()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        public void setnull()
        {
            txt15p.Clear();
            txt1Tiet1.Clear();
            txt1Tiet2.Clear();
            txtMieng.Clear();
            txtThi.Clear();
            txtDTBM.Clear();
        }
        public void hienthi()
        {
            gridDiem.DataSource = KetNoiDB.Getdatatable("SELECT  MaMH, DMK1, D15K1, D45K11, D45K12, DTK1, DTBMK1 FROM  DiemKyI where MaHS='" + txtMaHS.Text + "'");
        }
        public frmDiemKyI()
        {
            InitializeComponent();
        }

        private void frmDiemK1_Load(object sender, EventArgs e)
        {
            try
            {
                cmbLop.DataSource = KetNoiDB.Getdatatable("select * from Lop");
                cmbLop.DisplayMember = "TenLop";
                cmbLop.ValueMember = "MaLop";
                cmbMH.DataSource = KetNoiDB.Getdatatable("select * from MonHoc");
                cmbMH.DisplayMember = "TenMH";
                cmbMH.ValueMember = "MaMH";
                hienthi();
            }
            catch
            {
            }
            dongtxt();
            mobtn();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        
        }

        private void cmbMaMH_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {     
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "add";
            dongbtn();
            motxt();
            setnull();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "update";
            dongbtn();
            motxt();
            cmbMH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            state = "delete";
            dongbtn();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (state == "add")
                {
                    if (kiemtra() == 0)
                    {
                        KetNoiDB.ExcuteNonQR("INSERT INTO DiemKyI  (MaHS, MaMH, DMK1, D15K1, D45K11, D45K12, DTK1, DTBMK1) VALUES  ('" + txtMaHS.Text + "','" + txtMaMH.Text + "','" + txtMieng.Text + "','" + txt15p.Text + "','" + txt1Tiet1.Text + "','" + txt1Tiet2.Text + "','" + txtThi.Text + "','"+TinhDiem()+"')");
                    }
                    else
                    {
                        MessageBox.Show("Môn học của học sinh này đã có trong danh sách");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể thêm !!!");
            }
               

            //---------------------sua---------------
            try
            {
                if (state == "update")
                {
                    KetNoiDB.ExcuteNonQR("UPDATE DiemKyI SET  DMK1 ='" + txtMieng.Text + "', D15K1 ='" + txt15p.Text + "', D45K11 ='" + txt1Tiet1.Text + "', D45K12 ='" + txt1Tiet2.Text + "', DTK1 ='" + txtThi.Text + "', DTBMK1='"+TinhDiem()+"' where MaMH='" + txtMaMH.Text + "'");
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
                    KetNoiDB.ExcuteNonQR("DELETE FROM DiemKyI where MaHS='"+txtMaHS.Text+ "' and MaMH='"+txtMaMH.Text+"'");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể sửa !!!");
            }
           
            hienthi();
            mobtn();
            dongtxt();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void gridDiem_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int dong = 0;
                if (gridDiem.CurrentRow != null)
                {
                    dong = gridDiem.CurrentRow.Index;

                    txtMaMH.Text = gridDiem.Rows[dong].Cells[0].Value.ToString();
                    txtMieng.Text = gridDiem.Rows[dong].Cells[1].Value.ToString();
                    txt15p.Text = gridDiem.Rows[dong].Cells[2].Value.ToString();
                    txt1Tiet1.Text = gridDiem.Rows[dong].Cells[3].Value.ToString();
                    txt1Tiet2.Text = gridDiem.Rows[dong].Cells[4].Value.ToString();
                    txtThi.Text = gridDiem.Rows[dong].Cells[5].Value.ToString();
                    txtDTBM.Text = gridDiem.Rows[dong].Cells[6].Value.ToString();
                    DataTable dt = new DataTable();
                    dt = KetNoiDB.Getdatatable("select TenMH from MonHoc where MaMH='" + txtMaMH.Text + "'");
                    cmbMH.Text = dt.Rows[0][0].ToString();
                }

            }
            catch
            {
            }
                
            
        }

        private void txtMaHS_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenHS_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDSHS_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                String a = "";
                if (cmbDSHS.Items.Count > 0)
                   a = cmbDSHS.SelectedValue.ToString();
                DataTable dt = new DataTable();
                dt = KetNoiDB.Getdatatable("select MaHS, TenHS from HocSinh where MaHS='" + a + "'");
                txtMaHS.Text = dt.Rows[0][0].ToString();
                txtTenHS.Text = dt.Rows[0][1].ToString();
                hienthi();
            }
            catch
            {
            }
        }

        private void cmbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            string a = cmbLop.SelectedValue.ToString();
            DataTable dt = new DataTable();
            dt = KetNoiDB.Getdatatable("select * from HocSinh where MaLop ='"+a+"'");
            cmbDSHS.DataSource = dt;
            cmbDSHS.DisplayMember = "TenHS";
            cmbDSHS.ValueMember = "MaHS";
        }

        private void cmbMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string a = cmbMH.SelectedValue.ToString();
            txtMaMH.Text = a;
        }
        
    }
}
