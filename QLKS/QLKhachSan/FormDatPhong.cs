using QLKhachSan.Model;
using QLKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class FormDatPhong : Form
    {
        private int maPhong;
        private int maPhieuDat = 0;
        public FormDatPhong()
        {
            InitializeComponent();
            
            Load();
        
        }
         public void Load()
        {          
            DataTable data = new KHDao().DSKh();
            cbKH.DataSource = data;           
            cbKH.DisplayMember = "MaKH";
            cbKH.ValueMember = "MaKH";
            cbKH.SelectedIndex = -1;
            dgvDSDat.DataSource = new DatPhongDao().DSDatPhong();
            
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DatPhongDao().DSPT(txtSoNguoi.Text);
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có phòng phù hợp !");
                }
                else
                {
                    dgvPhong.DataSource = dt;
                }           
            }
            catch (Exception ex)
            {
                if (String.IsNullOrEmpty(txtSoNguoi.Text))
                {
                    MessageBox.Show("Nhập vào số người !");
                }                             
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtTienCoc.Text = (float.Parse(dgvPhong.Rows[numrow].Cells[3].Value.ToString())/2).ToString();
            maPhong = int.Parse(dgvPhong.Rows[numrow].Cells[0].Value.ToString());
        }
        private void ChonPhong()
        {
            lvPhong.Items.Clear();
            if (dgvPhong.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvPhong.SelectedRows.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    DataGridViewRow row = dgvPhong.SelectedRows[i];
                    item.SubItems.Add(row.Cells["MaPhong"].Value.ToString());
                    item.SubItems.Add(row.Cells["TenLoai"].Value.ToString());
                    item.SubItems.Add(row.Cells["SoNguoi"].Value.ToString());
                    item.SubItems.Add(row.Cells["Gia"].Value.ToString());
                    lvPhong.Items.Add(item);
                }

            }
        }
        private void cbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]+");            
            if (regex.IsMatch(cbKH.Text))
            {
                string ma = cbKH.Text;
                DataTable dt = new DatPhongDao().GetKH(ma);

                if (dt.Rows.Count > 0)
                {
                    lvKH.Items[0].SubItems[1].Text = dt.Rows[0]["MaKH"].ToString();
                    lvKH.Items[1].SubItems[1].Text = dt.Rows[0]["TenKH"].ToString();
                    lvKH.Items[2].SubItems[1].Text = dt.Rows[0]["GioiTinh"].ToString();
                    lvKH.Items[3].SubItems[1].Text = String.Format("{0:MM/dd/yyyy}", dt.Rows[0]["NgaySinh"]);
                    lvKH.Items[4].SubItems[1].Text = dt.Rows[0]["DiaChi"].ToString();
                    lvKH.Items[5].SubItems[1].Text = dt.Rows[0]["SoDT"].ToString();
                    lvKH.Items[6].SubItems[1].Text = dt.Rows[0]["CMT"].ToString();
                }
            }                        
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            int c = new DatPhongDao().addDP(new DATPHONG { MaPhieuDat = Int32.Parse(txtMPDat.Text), idPhong = maPhong, idKhachHang = int.Parse(cbKH.Text), SoNguoi = int.Parse(txtSoNguoi.Text), NgayDen = dtpNgayDen.Value, NgayDi = dtpNgayDi.Value, TienCoc = float.Parse(txtTienCoc.Text)  });
            if (c > 0)
            {
                MessageBox.Show("Đặt phòng thành công !");
                dgvDSDat.DataSource = new DatPhongDao().DSDatPhong();
                bool d = new DatPhongDao().updateRoom(maPhong);
            }
            else
            {
                MessageBox.Show("Đặt thất bại !");
            }

        }

        private void dgvPhong_SelectionChanged(object sender, EventArgs e)
        {
            ChonPhong();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(maPhieuDat != 0)
            {
                bool d = new DatPhongDao().xoaPD(maPhieuDat);
                if (d)
                {
                    MessageBox.Show("Hủy thành công !");
                    dgvDSDat.DataSource = new DatPhongDao().DSDatPhong();
                }
                else
                {
                    MessageBox.Show("Huỷ thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phiếu để hủy !");
            }
           
        }
      
        private void dgvDSDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            maPhieuDat = Int32.Parse(dgvDSDat.Rows[numrow].Cells[0].Value.ToString());
        }
    }
}
