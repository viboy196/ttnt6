using Quanlikhohang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlikhohang.NghiepVu
{
    public partial class frmNghiepVu : Form
    {
        KhoHangContext context = new KhoHangContext();

        public frmNghiepVu()
        {
            InitializeComponent();
        }

        private void TaiTatCaChiTietBBTL(Models.BienBanThanhLy bienBan)
        {
            ChiTietBBTLGridView.Columns.Clear();

            ChiTietBBTLGridView.DataSource = bienBan.ChiTietBBTLs.ToList();
            ChiTietBBTLGridView.Columns.Add("ThanhTien", "Thành tiền");

            foreach(DataGridViewRow row in ChiTietBBTLGridView.Rows)
            {
                row.Cells["ThanhTien"].Value
                    = (int)row.Cells["Gia"].Value * (double)row.Cells["SoLuong"].Value;
            }

            Utilities.HideAllColumns(ChiTietBBTLGridView);
            Utilities.SetColumnsHeaderText
            (
                ChiTietBBTLGridView,
                Tuple.Create("NguyenLieu", "Tên nguyên liệu"),
                Tuple.Create("SoLuong", "Số lượng"),
                Tuple.Create("Gia", "Giá tiền"),
                Tuple.Create("ThanhTien", "Thành tiền")
            );
            Utilities.SetColumnsOrder(ChiTietBBTLGridView, 
                "NguyenLieu", "Gia", "SoLuong", "ThanhTien");
            Utilities.SetColumnsFormat
            (
                ChiTietBBTLGridView,
                Tuple.Create("Gia", "N0"),
                Tuple.Create("ThanhTien", "N0")
            );

            TinhTongTien();
        }

        private void TinhTongTien()
        {
            int tongTien = 0;
            foreach (DataGridViewRow row in ChiTietBBTLGridView.Rows)
            {
                tongTien += Convert.ToInt32(row.Cells["ThanhTien"].Value);
            }
            TongTien_NumericUpDown.Value = tongTien;
        }

        private void TaiTatCaNguyenLieu()
        {
            NguyenLieuComboBox.DataSource = context.NguyenLieux.ToList();
            NguyenLieuComboBox.ValueMember = "MaNL";
            NguyenLieuComboBox.DisplayMember = "TenNL";
        }

        private void TaiTatCaBienBan()
        {
            BienBanListBox.DataSource = context.BienBanThanhLies.ToList();
            BienBanListBox.ValueMember = "MaBB";
            BienBanListBox.DisplayMember = "";
        }

        private void TaiTatCaNhanVien()
        {
            NhanVienComboBox.DataSource = context.NhanViens.ToList();
            NhanVienComboBox.ValueMember = "MaNV";
            NhanVienComboBox.DisplayMember = "HoTen";
        }

        private void frmNghiepVu_Load(object sender, EventArgs e)
        {
            TaiTatCaNguyenLieu();
            TaiTatCaBienBan();
            TaiTatCaNhanVien();

            ChiTietBBTLGridView.RowEnter += ChiTietBBTLGridView_RowEnter;
        }

        private void TaiChiTietLenKhung(Models.ChiTietBBTL chiTiet)
        {
            if (chiTiet == null)
                return;

            NguyenLieuComboBox.SelectedItem = chiTiet.NguyenLieu;
            SoLuongNumericUpDown.Value = (decimal)chiTiet.SoLuong;
            GiaTienNumericUpDown.Value = chiTiet.Gia;
            TinhThanhTien();
        }

        private void TinhThanhTien()
        {
            ThanhTienNumericUpDown.Value = SoLuongNumericUpDown.Value * GiaTienNumericUpDown.Value;
        }

        private void ChiTietBBTLGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (ChiTietBBTLGridView.SelectedRows.Count == 0)
                return;
            
            Models.ChiTietBBTL chiTiet = (Models.ChiTietBBTL)ChiTietBBTLGridView.SelectedRows[0].DataBoundItem;
            TaiChiTietLenKhung(chiTiet);
            Utilities.SetControlsEnabled(taoBienBanMoi, CacNutThaoTacDuLieu);
        }

        private void BienBanListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Models.BienBanThanhLy bienBan = (Models.BienBanThanhLy)BienBanListBox.SelectedItem;
            taoBienBanMoi = false;
            Utilities.SetControlsEnabled(taoBienBanMoi, CacNutThaoTacDuLieu);
            NhanVienComboBox.SelectedItem = bienBan.NhanVien;
            TaiTatCaChiTietBBTL(bienBan);
        }

        private void SoLuongNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ThanhTienNumericUpDown.Value = SoLuongNumericUpDown.Value * GiaTienNumericUpDown.Value;
        }

        private void ChiTiet_DatLaiButton_Click(object sender, EventArgs e)
        {
            NguyenLieuComboBox.SelectedIndex = -1;
            SoLuongNumericUpDown.Value = 0;
        }

        private void NguyenLieuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(NguyenLieuComboBox.SelectedIndex == -1)
            {
                GiaTienNumericUpDown.Value = 0;
                return;
            }

            Models.NguyenLieu nguyenLieu = NguyenLieuComboBox.SelectedItem as Models.NguyenLieu;
            GiaTienNumericUpDown.Value = nguyenLieu.GiaTien.GetValueOrDefault();
            TinhThanhTien();
        }

        private void BienBan_DatLaiButton_Click(object sender, EventArgs e)
        {
            TongTien_NumericUpDown.Value = 0;

            ChiTietBBTLGridView.DataSource = null;
            ChiTietBBTLGridView.Columns.Clear();

            ChiTiet_DatLaiButton_Click(sender, e);

            BienBanListBox.SelectedIndex = -1;
        }

        private Control[] CacNutThaoTacDuLieu
        {
            get
            {
                return new Control[]
                {
                    NguyenLieuComboBox, SoLuongNumericUpDown, GiaTienNumericUpDown,
                    BienBan_LuuMoiButton, NhanVienComboBox,

                    ChiTiet_DatLaiButton, ChiTiet_ThemButton,
                    ChiTiet_SuaButton, ChiTiet_XoaButton
                };
            }
        }

        Models.BienBanThanhLy bienBanMoi;
        bool taoBienBanMoi = false;
        private void BienBan_TaoMoiButton_Click(object sender, EventArgs e)
        {
            BienBan_DatLaiButton_Click(sender, e);

            bienBanMoi = new Models.BienBanThanhLy();
            taoBienBanMoi = true;
            Utilities.SetControlsEnabled(taoBienBanMoi, CacNutThaoTacDuLieu);
        }

        private Models.ChiTietBBTL TaoThanhChiTietTuThongTinDaDien()
        {
            return new Models.ChiTietBBTL
            {
                NguyenLieu = NguyenLieuComboBox.SelectedItem as Models.NguyenLieu,
                SoLuong = (double)SoLuongNumericUpDown.Value,
                Gia = (int)GiaTienNumericUpDown.Value,
            };
        }

        private void ChiTiet_ThemButton_Click(object sender, EventArgs e)
        {
            if(SoLuongNumericUpDown.Value == 0)
            {
                MessageBox.Show("Số lượng không thể để bằng 0!");
                return;
            }
            if(NguyenLieuComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn nguyên liệu trước khi thêm!");
                return;
            }

            bool chiTietTonTai = false;
            Models.ChiTietBBTL chiTietMoi = TaoThanhChiTietTuThongTinDaDien();
            foreach (Models.ChiTietBBTL chiTiet in bienBanMoi.ChiTietBBTLs)
            {
                if(chiTiet.NguyenLieu == chiTietMoi.NguyenLieu)
                {
                    chiTiet.SoLuong += chiTietMoi.SoLuong;
                    chiTietTonTai = true;
                }
            }

            if(!chiTietTonTai)
            {
                bienBanMoi.ChiTietBBTLs.Add(chiTietMoi);
            }
            
            TaiTatCaChiTietBBTL(bienBanMoi);
        }

        private void ChiTiet_SuaButton_Click(object sender, EventArgs e)
        {
            int index = Utilities.GetSelectedIndex(ChiTietBBTLGridView);
            if(index == -1)
            {
                MessageBox.Show("Phải chọn một chi tiết bất kỳ trước khi sửa!");
                return;
            }

            LazyUtilities<Models.ChiTietBBTL>.QuickMap
            (
                TaoThanhChiTietTuThongTinDaDien(),
                bienBanMoi.ChiTietBBTLs.ElementAt(index)
            );

            TaiTatCaChiTietBBTL(bienBanMoi);
        }

        private void ChiTiet_XoaButton_Click(object sender, EventArgs e)
        {
            int index = Utilities.GetSelectedIndex(ChiTietBBTLGridView);
            if (index == -1)
            {
                MessageBox.Show("Phải chọn một chi tiết bất kỳ trước khi sửa!");
                return;
            }

            if(MessageBox.Show(null, "Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bienBanMoi.ChiTietBBTLs.Remove(bienBanMoi.ChiTietBBTLs.ElementAt(index));
                TaiTatCaChiTietBBTL(bienBanMoi);
            }
        }

        private void BienBan_LuuMoiButton_Click(object sender, EventArgs e)
        {
            if(NhanVienComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn nhân viên trước khi lưu hóa đơn mới!");
                return;
            }

            bienBanMoi.NhanVien = NhanVienComboBox.SelectedItem as Models.NhanVien;
            bienBanMoi.NgayLap = DateTime.Now;
            context.BienBanThanhLies.Add(bienBanMoi);
            context.SaveChanges();
            TaiTatCaBienBan();

            MessageBox.Show("Tạo mới thành công!");

            taoBienBanMoi = false;
            Utilities.SetControlsEnabled(false, CacNutThaoTacDuLieu);
        }

        private void BienBan_XoaButton_Click(object sender, EventArgs e)
        {
            if(BienBanListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn một biên bản trước khi có thể xóa!");
                return;
            }

            if (MessageBox.Show(null, "Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Models.BienBanThanhLy bienBan = BienBanListBox.SelectedItem as Models.BienBanThanhLy;
                context.BienBanThanhLies.Remove(bienBan);
                context.SaveChanges();

                MessageBox.Show("Xóa thành công!");

                TaiTatCaBienBan();
            }
        }

        private void BienBan_XuatButton_Click(object sender, EventArgs e)
        {
            if(BienBanListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn một biên bản trước khi có thể xuất!");
                return;
            }

            if(BienBanFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Exporter.ExportToFile(BienBanListBox.SelectedItem as Models.BienBanThanhLy,
                    BienBanFileDialog.FileName);
                    MessageBox.Show("Xuất thành công!");
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra! Vui lòng thử lại sau.");
                }
            }
        }
    }
}
