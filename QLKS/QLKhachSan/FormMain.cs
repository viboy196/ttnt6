using QLKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLKhachSan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            MainDao md = new MainDao();
            lblTenDN.Text = FormLogin.tenDN;
            lblSPT.Text = md.loadSPT().ToString();
            lblSPDD.Text = md.loadSPDD().ToString();
            lblSPDT.Text = md.loadSPDT().ToString();
            loadImage();
        }

        public void loadImage()
        {
            DataTable dt = new MainDao().DSP();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["MaPhong"].ToString();
                if (row["TinhTrang"].ToString().Equals("Trong"))
                {
                    item.ImageIndex = 0;
                }
                if (row["TinhTrang"].ToString().Equals("Da dat"))
                {
                    item.ImageIndex = 1;
                }
                if (row["TinhTrang"].ToString().Equals("Da thue"))
                {
                    item.ImageIndex = 2;
                }
                lvPhong.Items.Add(item);
            }
        }
        private void mnDoiMatKhau_Click(object sender, EventArgs e)
        {
            new FormDoiMatKhau().Show();
        }
     
        private void mnDatPhong_Click(object sender, EventArgs e)
        {
            new FormDatPhong().Show();
        }

        private void mnThuePhong_Click(object sender, EventArgs e)
        {
            new FormThuePhong().Show();
        }

        private void mnPhong_Click(object sender, EventArgs e)
        {
            new FormPhong().Show();
        }

        private void mnThietBiPhong_Click(object sender, EventArgs e)
        {
            new FormThietBiPhong().Show();
        }

        private void mnDichVu_Click(object sender, EventArgs e)
        {
            new FormDichVu().Show();
        }

        private void mnNhanVien_Click(object sender, EventArgs e)
        {
            new FormNhanVien().Show();
        }

        private void mnThongTin_Click(object sender, EventArgs e)
        {
            new FormThongTin().Show();
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
        }

        private void mnKhachHang_Click(object sender, EventArgs e)
        {
            new FormKhachHang().Show();
        }

       
    }
}
