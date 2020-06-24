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
    public partial class BCKyI : Form
    {
        public static float DiemKy1;
        public void HienThiBaoCao()
        {
            DataTable dt = new DataTable();
            dt = KetNoiDB.Getdatatable("SELECT TBHK1, HocLuc FROM  BCHK1 where MaHS ='"+lblMHS.Text+"'");
            lblDTB.Text = dt.Rows[0][0].ToString();
            lblHL.Text = dt.Rows[0][1].ToString();
        }
       
        public BCKyI()
        {
            InitializeComponent();
        }
        public float TinhDiemTB()
        {
            float tong = 0;
            int dem = gridDiem.RowCount - 1;
            if (dem != 0)
            {

                for (int i = 0; i < gridDiem.RowCount - 1; i++)
                {

                    string s = gridDiem.Rows[i].Cells[6].Value.ToString();
                    if (s.Length != 0)
                    {

                        tong = tong + float.Parse(s);
                    }
                }
                tong = tong / dem;
            }
            return tong;
        }
        public string KtHocLuc()
        {
            string s;
            if (TinhDiemTB() < 3.5)
            {
                s = "Kém";

            }
            else
            {
                if (TinhDiemTB() < 5)
                {
                    s = "Yếu";
                }
                else
                {
                    if (TinhDiemTB() < 6.5)
                    {
                        s = "Trung bình";
                    }
                    else
                    {
                        if (TinhDiemTB() < 8)
                        {
                            s = "Khá";
                        }
                        else
                        {
                            s = "Giỏi";
                        }
                    }
                }
            }
            return s;
        }
        public void hienthi()
        {
            string s = cmbDSHS.SelectedValue.ToString();
            gridDiem.DataSource = KetNoiDB.Getdatatable("SELECT  MaMH, DMK1, D15K1, D45K11, D45K12, DTK1, DTBMK1 FROM  DiemKyI where MaHS='" + s + "'");
        }
        private void BCKyI_Load(object sender, EventArgs e)
        {
            try
            {
                cmbLop.DataSource = KetNoiDB.Getdatatable("select * from Lop");
                cmbLop.DisplayMember = "TenLop";
                cmbLop.ValueMember = "MaLop";
               
                hienthi();
            }
            catch
            {
            }
            btnLuuBC.Enabled = false;
        }

        private void cmbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            string a = cmbLop.SelectedValue.ToString();
            DataTable dt = new DataTable();
            dt = KetNoiDB.Getdatatable("select * from HocSinh where MaLop ='" + a + "'");
            cmbDSHS.DataSource = dt;
            cmbDSHS.DisplayMember = "TenHS";
            cmbDSHS.ValueMember = "MaHS";
        }

        private void cmbDSHS_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string a = "";
                if (cmbDSHS.Items.Count > 0)
                {
                    cmbDSHS.SelectedValue.ToString();
                    DataTable dt = new DataTable();
                    dt = KetNoiDB.Getdatatable("select MaHS, TenHS from HocSinh where MaHS='" + a + "'");
                    lblMHS.Text = a;
                    lblTenHS.Text = cmbDSHS.Text;
                    lblDTB.Text = "";
                    lblHL.Text = "";
                    hienthi();
                    HienThiBaoCao();
                    btnLuuBC.Enabled = false;
                }
            }
            catch
            {
            }
            
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            float a = TinhDiemTB();
            lblDTB.Text = a.ToString();
            lblHL.Text = KtHocLuc();
            DiemKy1 = a;
            btnLuuBC.Enabled = true;
            //MessageBox.Show(a.ToString());
           
            
        }

        private void btnLuuBC_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDTB.Text.Trim() != "0")
                {
                    KetNoiDB.ExcuteNonQR("INSERT INTO BCHK1 (MaHS, TenHS, HocLuc, TBHK1) VALUES ('" + lblMHS.Text + "',N'" + lblTenHS.Text + "',N'" + lblHL.Text + "','" + float.Parse(lblDTB.Text) + "')");
                    btnLuuBC.Enabled = false;
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    MessageBox.Show("Đề nghị nhập điểm cho học sinh");
                    btnLuuBC.Enabled = false;
                    lblHL.Text = "";
                    lblDTB.Text = "";
                }
            }
            catch
            {
                //MessageBox.Show("Đã có điểm báo cáo");
                KetNoiDB.ExcuteNonQR("UPDATE    BCHK1 SET   TBHK1 ='" + lblDTB.Text + "', HocLuc =N'" + lblHL.Text + "' where MaHS='" + lblMHS.Text + "'");
                MessageBox.Show("Lưu thành công");
                btnLuuBC.Enabled = false;
            }
        }

        private void lblDTB_Click(object sender, EventArgs e)
        {

        }
    }
}
