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
    public partial class FormThuePhong : Form
    {
        public float giaPhong= 0;
        public int maThue, maPhong;
        public FormThuePhong()
        {
            InitializeComponent();

            Load();
        }

        public void Load()
        {
            DataTable data = new KHDao().DSKh();
            cbMaKH.DataSource = data;
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.ValueMember = "MaKH";
            cbMaKH.SelectedIndex = -1;

            DataTable dt = new ThuePhongDao().DSPT();
            cbMaPhong.DataSource = dt;
            cbMaPhong.DisplayMember = "MaPhong";
            cbMaPhong.SelectedIndex = -1;

            dgvDSThue.DataSource = new ThuePhongDao().DSThuePhong();
        }
        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]+");
            if (regex.IsMatch(cbMaKH.Text))
            {
                string ma = cbMaKH.Text;
                DataTable dt = new ThuePhongDao().GetKH(ma);

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

        private void cbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

            lvPhong.Items.Clear();
            Regex regex = new Regex(@"[0-9]+");
            if (regex.IsMatch(cbMaPhong.Text))
            {
                DataTable room = new ThuePhongDao().DSPChon(cbMaPhong.Text);
                for (int i = 0; i < room.Rows.Count; i++)
                {
                    DataRow dr = room.Rows[i];
                    ListViewItem item = new ListViewItem(dr["MaPhong"].ToString());
                    item.SubItems.Add(dr["TenLoai"].ToString());
                    item.SubItems.Add(dr["SoNguoi"].ToString());
                    item.SubItems.Add(dr["Gia"].ToString());
                    lvPhong.Items.Add(item);
                    giaPhong = float.Parse(dr["Gia"].ToString());
                }
           
            }           
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            try
            {
                int c = new ThuePhongDao().addPT(new THUEPHONG { MaThue = int.Parse(txtMaThue.Text), idKhachHang = int.Parse(cbMaKH.Text), idPhong = int.Parse(cbMaPhong.Text), NgayDi = dtpNgayDi.Value, NgayDen = dtpNgayDen.Value, GiaTien = float.Parse(txtTongTien.Text) });
                if (c > 0)
                {
                    FormMain f = new FormMain();
                    MessageBox.Show("Thuê phòng thành công !", "Thông báo");
                    new ThuePhongDao().updateRoom(int.Parse(cbMaPhong.Text), "Da thue");
                    Load();
                    cbMaKH.ValueMember = "";

                }
                else
                {
                    MessageBox.Show("Thuê thất bại !","Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Thuê thất bại !", "Thông báo");
            }
        }

     

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show( "Xác nhận trả phòng ?","Trả Phòng", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                bool c = new ThuePhongDao().xoaPT(maThue);
                if (c)
                {
                    MessageBox.Show("Trả phòng thành công !");
                    new ThuePhongDao().updateRoom(maPhong, "Trong");
                    dgvDSThue.DataSource = new ThuePhongDao().DSThuePhong();
                    Load();
                }
                
            }
            
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (giaPhong != 0)
            {
                float tongtien = 0;
                TimeSpan time = dtpNgayDi.Value - dtpNgayDen.Value;
                double tongSoNgay = Math.Ceiling(time.TotalDays) + 1;
                tongtien =(float) tongSoNgay * giaPhong;
                txtTongTien.Text = tongtien.ToString();
            }
            else
            {
                MessageBox.Show("Hãy chọn phòng và thời gian bạn muốn ở !");
            }
            
        }

        private void cbMaPhong_Click(object sender, EventArgs e)
        {

    
        }

        private void dgvDSThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            maThue =int.Parse(dgvDSThue.Rows[numrow].Cells[0].Value.ToString());
            maPhong = int.Parse(dgvDSThue.Rows[numrow].Cells[2].Value.ToString());
        }
    }
}
