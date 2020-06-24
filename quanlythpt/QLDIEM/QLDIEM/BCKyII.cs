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
    public partial class BCKyII : Form
    {
        public string state;
        public BCKyII()
        {
            InitializeComponent();
        }
        public void HienThiBaoCao()
        {
            DataTable dt = new DataTable();
            dt = KetNoiDB.Getdatatable("SELECT TBHK2, HocLuc FROM  BCHK2 where MaHS ='" + lblMHS.Text + "'");
            lblDTB.Text = dt.Rows[0][0].ToString();
            lblHL.Text = dt.Rows[0][1].ToString();
            dt.Dispose();
            dt = KetNoiDB.Getdatatable("SELECT  HocLucCN, TBCN FROM BCCN where MaHS ='" + lblMHS.Text + "'");
            lblHLNam.Text = dt.Rows[0][0].ToString();
            lblTBNam.Text = dt.Rows[0][1].ToString();
            dt.Dispose();
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
            gridDiem.DataSource = KetNoiDB.Getdatatable("SELECT  MaMH, DMK2, D15K2, D45K21, D45K22, DTK2, DTBMK2 FROM  DiemKyII where MaHS='" + s + "'");
        }
        
        private void BCKyII_Load(object sender, EventArgs e)
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

        private void btnBC_Click(object sender, EventArgs e)
        {
            float a = TinhDiemTB();
            lblDTB.Text = a.ToString();
            lblHL.Text = KtHocLuc();
            //DiemKy1 = a;
            btnLuuBC.Enabled = true;
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
                    lblHLNam.Text = "";
                    lblTBNam.Text = "";
                    hienthi();
                    HienThiBaoCao();
                    btnLuuBC.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void lblHLNam_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuBC_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDTB.Text.Trim() != "0")
                {
                    KetNoiDB.ExcuteNonQR("INSERT INTO BCHK2 (MaHS, TenHS, HocLuc, TBHK2) VALUES ('" + lblMHS.Text + "',N'" + lblTenHS.Text + "',N'" + lblHL.Text + "','" + float.Parse(lblDTB.Text) + "')");
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
                KetNoiDB.ExcuteNonQR("UPDATE  BCHK2 SET  TBHK2 ='"+lblDTB.Text+"', HocLuc =N'"+lblHL.Text+"' where MaHS='"+lblMHS.Text+"'");
                MessageBox.Show("Lưu thành công");
            }

        }

        private void btnBCCN_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = KetNoiDB.Getdatatable("select count(*) from BCHK1 where MaHS='"+lblMHS.Text+"'");
            int a = int.Parse(dt.Rows[0][0].ToString());
            dt.Dispose();
            dt = KetNoiDB.Getdatatable("select count(*) from BCHK2 where MaHS='" + lblMHS.Text + "'");
            int b = int.Parse(dt.Rows[0][0].ToString());
            dt.Dispose();
            dt = KetNoiDB.Getdatatable("select count(*) from BCCN where MaHS='" + lblMHS.Text + "'");
            int c = int.Parse(dt.Rows[0][0].ToString());
            dt.Dispose();
            if (a == 0)
            {
                MessageBox.Show("Học sinh này chưa có điểm tổng kết kỳ 1");
            }
            if (b == 0)
            {
                MessageBox.Show("Học sinh này chưa có điểm tổng kết kỳ 2");
            }
            if (a != 0 && b != 0)
            {
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                dt1 = KetNoiDB.Getdatatable("select TBHK1 from BCHK1 where MaHS='"+lblMHS.Text+"'");
                dt2 = KetNoiDB.Getdatatable("select TBHK2 from BCHK2 where MaHS='" + lblMHS.Text + "'");
                float x = float.Parse(dt1.Rows[0][0].ToString());
                float y = float.Parse(dt2.Rows[0][0].ToString());
                dt1.Dispose();
                dt2.Dispose();
                float k = (x + 2 * y) / 3;
                lblTBNam.Text = k.ToString();
                if (k < 3.5)
                {
                    lblHLNam.Text = "Kém";

                }
                else
                {
                    if (k < 5)
                    {
                        lblHLNam.Text = "Yếu";
                    }
                    else
                    {
                        if (k < 6.5)
                        {
                            lblHLNam.Text = "Trung bình";
                        }
                        else
                        {
                            if (k< 8)
                            {
                                lblHLNam.Text = "Khá";
                            }
                            else
                            {
                                lblHLNam.Text = "Giỏi";
                            }
                        }
                    }
                }
                if (c == 0)
                {
                    KetNoiDB.ExcuteNonQR("INSERT INTO BCCN (MaHS, TenHS, HocLucCN, TBCN) VALUES  ('" + lblMHS.Text + "',N'" + lblTenHS.Text + "',N'" + lblHLNam.Text + "','" + k.ToString() + "')");
                }
                else
                {
                    KetNoiDB.ExcuteNonQR("UPDATE BCCN SET  HocLucCN =N'"+lblHLNam.Text+"', TBCN ='"+k.ToString()+"'");
                }
                MessageBox.Show("Báo cáo thành công !!!");
            }
           
            
        }
     }
}



