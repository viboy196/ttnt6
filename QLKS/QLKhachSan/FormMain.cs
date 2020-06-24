using QLKhachSan.DAO;
using System;
using System.Data;
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

        private bool checkquyen()
        {
            if (FormLogin.quyen.Equals("admin"))
            {
                return true;
            }
            else
            {
                return false;
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
            this.Hide();
            new FormThuePhong().ShowDialog();
            this.Show();
        }

        private void mnPhong_Click(object sender, EventArgs e)
        {
            if (checkquyen())
            {
                new FormPhong().Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa đủ quyền để thao tác !");
            }
        }

        private void mnThietBiPhong_Click(object sender, EventArgs e)
        {
            if (checkquyen())
            {
                new FormThietBiPhong().Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa đủ quyền để thao tác !");
            }
        }

        private void mnDichVu_Click(object sender, EventArgs e)
        {
            if (checkquyen())
            {
               new FormDichVu().Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa đủ quyền để thao tác !");
            }
            
        }

        private void mnNhanVien_Click(object sender, EventArgs e)
        {
            if (checkquyen())
            {
                new FormNhanVien().Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa đủ quyền để thao tác !");
            }
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
